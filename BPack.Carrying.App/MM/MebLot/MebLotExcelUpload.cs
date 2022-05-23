using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.MebLot
{
    public partial class MebLotExcelUpload : XtraForm
    {
        public event EventHandler<UploadButtonClickedEventArgs> UploadButtonClicked;

        //대/중포장 컬럼 정보 - 엑셀 업로드파일과 일치해야함
        private string[] lPackMPackColumns = { "PACK_NO", "M_PACK_NO", "CASE_NO", "ORDER_NO", "PART_NO", "QTY", "LOT", "WORK_DATE" };
        //중포장/개별LOT 컬럼정보  - 엑셀 업로드파일과도 일치해야함
        private string[] mPackPartColumns = { "PACK_NO", "PART_LOT", "PACK_DATE", "SHIP_DATE" };

        private MebLotExcelUpload()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gridControl1.AllowDrop = true;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            this.Text = "Upload MEB LOT";
        }
        public MebLotExcelUpload(string uploadType) : this()
        {
            this.UploadType = uploadType;
            InitColumns();
        }
        //컬럼초기화 --선택한 업로드 형태별로 컬럼을 생성한다.
        private void InitColumns()
        {
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            if (UploadType.Equals("MEB_LOT_LPACK"))
            {
                labelControl1.Text = StrapMessageBox.GetMessage("A001", 44); //대포장/중포장 정보를 업로드 합니다.
                foreach (var colName in lPackMPackColumns)
                {
                    gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = colName, Visible = true });
                }
                gridView1.BestFitColumns();

            }
            else if (UploadType.Equals("MEB_LOT_MPACK"))
            {
                labelControl1.Text = StrapMessageBox.GetMessage("A001", 45); //중포장/개별LOT 정보를 업로드 합니다.
                foreach (var colName in mPackPartColumns)
                {
                    gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = colName, Visible = true });
                }
                gridView1.BestFitColumns();
            }
        }
        //컬럼 체크
        private void CheckColumns()
        {
            //대/중포장 업로드 일때
            if (UploadType.Equals("MEB_LOT_LPACK"))
            {
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                {
                    if (!lPackMPackColumns.Contains(col.FieldName))
                    {
                        MessageBox.Show("Is this specified upload file?\r\nCheck Column : " + col.FieldName);
                        InitColumns(); //컬럼이 맞지않으면 초기화 한다.
                        return;
                    }
                }
                foreach (var item in lPackMPackColumns)
                {
                    if (gridView1.Columns[item] == null)
                    {
                        MessageBox.Show("Is this specified upload file?\r\nCheck Column : " + item);
                        InitColumns(); //컬럼이 맞지않으면 초기화 한다.
                        return;
                    }
                }
            }
            //중포장 개별LOT 업로드일때
            else if (UploadType.Equals("MEB_LOT_MPACK"))
            {
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                {
                    if (!mPackPartColumns.Contains(col.FieldName))
                    {
                        MessageBox.Show("Is this specified upload file?\r\nCheck Column : " + col.FieldName);
                        InitColumns(); //컬럼이 맞지않으면 초기화 한다.
                        return;
                    }
                }
                foreach (var item in mPackPartColumns)
                {
                    if (gridView1.Columns[item] == null)
                    {
                        MessageBox.Show("Is this specified upload file?\r\nCheck Column : " + item);
                        InitColumns(); //컬럼이 맞지않으면 초기화 한다.
                        return;
                    }
                }
            }
        }

        public void SetExcelUplaodRange(string sysCodeCellRange)
        {
            //시스템 코드 가져오기
            BPack.Pocket.Core.SysCodeManager.SysCodeManagerPocket sysCode = new Pocket.Core.SysCodeManager.SysCodeManagerPocket();
            var sysCCode = sysCode.SelectCCodeModels(new Model.Core.SysCodeManager.SysCodeManagerModelArgs { Select_PCode = "EXCEL_UPLOAD_RANGE" });
            ExcelUploadRange = sysCCode.Where(a => a.C_CODE == sysCodeCellRange).SingleOrDefault().C_NAME;
        }

        public string UploadType { get; set; }
        public string ExcelUploadRange { get; set; }

        //파일선택버튼
        private void btnFileSeletor_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Excel files(*.xls,*.xlsx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                string workSheetName = GetWorkSheetName(fileName);
                if (!workSheetName.Equals(""))
                {
                    FillExcellData(fileName, workSheetName);
                }
            }
        }
        

        //데이터 바인딩
        private void FillExcellData(string fileName, string workSheetName)
        {
            gridView1.Columns.Clear();
            DevExpress.DataAccess.Excel.ExcelDataSource source = new DevExpress.DataAccess.Excel.ExcelDataSource();
            source.FileName = fileName;

            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            excelWorksheetSettings.WorksheetName = workSheetName;
            //excelWorksheetSettings.CellRange = "B5:E20000";
            //excelWorksheetSettings.CellRange = ExcelUploadRange;

            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions = new DevExpress.DataAccess.Excel.ExcelSourceOptions();
            excelSourceOptions.ImportSettings = excelWorksheetSettings;
            excelSourceOptions.UseFirstRowAsHeader = true;

            source.SourceOptions = excelSourceOptions;

            source.Fill();
            gridControl1.DataSource = source;
            gridView1.BestFitColumns();

            //컬럼 체크
            CheckColumns();
        }

        //파일드래그&드랍
        private void gridControl1_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = e.Data.GetData(DataFormats.FileDrop) as string[];
            string fileName = file[0];
            string ext = System.IO.Path.GetExtension(fileName);
            if (!ext.Equals(".xls") && !ext.Equals(".xlsx"))
            {
                MessageBox.Show("Only Excel File");
                return;
            }
            string workSheetName = GetWorkSheetName(fileName);
            if (!workSheetName.Equals(""))
            {
                FillExcellData(fileName, workSheetName);
            }
        }

        private string GetWorkSheetName(string fileName)
        {
            string worksheetName = "";
            try
            {
                using (DevExpress.SpreadsheetSource.ISpreadsheetSource spreadsheetSource = DevExpress.SpreadsheetSource.SpreadsheetSourceFactory.CreateSource(fileName))
                {
                    DevExpress.SpreadsheetSource.IWorksheetCollection worksheetCollection = spreadsheetSource.Worksheets;
                    string[] workSheetNames;
                    workSheetNames = worksheetCollection.Select(a => a.Name).ToArray();
                    SelectWorkSheet selectWorkSheet = new SelectWorkSheet(workSheetNames);
                    if (selectWorkSheet.ShowDialog() == DialogResult.OK)
                    {
                        worksheetName = selectWorkSheet.SelectedWorkSheetName;
                    }
                    else
                    {
                        return "";
                    }

                    //worksheetName = worksheetCollection[idx].Name;
                }
            }
            catch (System.IO.IOException ioex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ioex));
            }
            return worksheetName;
        }

        private void gridControl1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (gridControl1.DataSource == null || gridView1.RowCount == 0)
            {
                StrapMessageBox.Show("A001", 37); //업로드할 데이터가 존재하지 않습니다.
                return;
            }

            UploadButtonClickedEventArgs args = new UploadButtonClickedEventArgs();
            args.UploadType = "";
            args.DataTable = ToDataTable(gridControl1.DataSource as DevExpress.DataAccess.Excel.ExcelDataSource);
            UploadButtonClicked?.Invoke(this, args);
        }

        public DataTable ToDataTable(DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource)
        {
            IList list = ((IListSource)excelDataSource).GetList();
            DevExpress.DataAccess.Native.Excel.DataView dataView = (DevExpress.DataAccess.Native.Excel.DataView)list;
            List<PropertyDescriptor> props = dataView.Columns.ToList<PropertyDescriptor>();
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (DevExpress.DataAccess.Native.Excel.ViewRow item in list)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

    }
}
