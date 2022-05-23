using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvConfirm2;
using BPack.Pocket.App.SD.DlvConfirm2;
using BPack.Report.App.Common;
using BPack.Report.App.Factory;
using BPack.Strap.FormControls;
using DevExpress.Export.Xl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.SD.DlvConfirm2
{
    public partial class DlvConfirm2Main : StrapMainForm
    {
        private DlvConfirm2Args _dlvConfirm2Args;
        private DlvConfirm2Pocket _dlvConfirm2Pocket;
        private DlvResultList _dlvResultList;
        private DlvResultDetailList _dlvResultDetailList;
        private DlvResultHuList _dlvResultHuList;
        private DlvCMebDetailPopup _dlvCMebDetailPopup;
        public DlvConfirm2Main()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _dlvConfirm2Args = new DlvConfirm2Args();
            _dlvConfirm2Pocket = new DlvConfirm2Pocket();
            _dlvResultList = new DlvResultList(_dlvConfirm2Args, _dlvConfirm2Pocket);
            _dlvResultDetailList = new DlvResultDetailList(_dlvConfirm2Args, _dlvConfirm2Pocket);
            _dlvResultHuList = new DlvResultHuList(_dlvConfirm2Args, _dlvConfirm2Pocket);



            AddSubForm(this, _dlvResultList, layoutControlGroup2);
            AddSubForm(this, _dlvResultDetailList, layoutControlGroup3);
            AddSubForm(this, _dlvResultHuList, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _dlvConfirm2Args,
                InitlistForm = _dlvResultList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            this.SelectedSubFormChanged += DlvConfirm2Main_SelectedSubFormChanged;
            _dlvResultList.ModelSelectedEvent += DlvResultList_ModelSelectedEvent;
            _dlvResultDetailList.ModelSelectedEvent += DlvResultDetailList_ModelSelectedEvent;
            LookUpEditHelper.SetBusinessPartner(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, false, true, true, false, false);
            
            layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never; //출하취소 개발하다가 보류됨 20220509
        }

        private void DlvResultDetailList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drd_No = ((DlvResultDetailModel)e.SelectedModelArgsBase.SelectedModelBase).DRD_NO;
            _dlvResultHuList.DataRefresh(_dlvConfirm2Args);
        }

        private void DlvResultList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_No = ((DlvResultModel)e.SelectedModelArgsBase.SelectedModelBase).DRH_NO;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Doh_No = ((DlvResultModel)e.SelectedModelArgsBase.SelectedModelBase).DOH_NO;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_Status = ((DlvResultModel)e.SelectedModelArgsBase.SelectedModelBase).DRH_STATUS;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Cust_Doh_No = ((DlvResultModel)e.SelectedModelArgsBase.SelectedModelBase).CUST_DOH_NO;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drd_No = null;
            //2021.12.28정수교 추가
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MIN_GR = ((DlvResultModel)e.SelectedModelArgsBase.SelectedModelBase).MIN_GR;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MAX_GR = ((DlvResultModel)e.SelectedModelArgsBase.SelectedModelBase).MAX_GR;


            _dlvResultDetailList.DataRefresh(_dlvConfirm2Args);
            _dlvResultHuList.DataRefresh(_dlvConfirm2Args);
            if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_Status.Equals("PICKING-CLOSE"))
            {
                //출하확정 버튼
                if (this.AuthModel.UPDATE_AUTH)
                {
                    btnConfirm.Enabled = true;
                }
                else
                {
                    btnConfirm.Enabled = false;
                }
                SetRibbonButtonsEnable_ByAuth(true, edit: true, delete: false);
            }
            else
            {
                //출하확정 버튼
                btnConfirm.Enabled = false;
                if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_Status.Equals("CLOSE"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, edit: false, delete: false);
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(true, edit: false, delete: true);
                }

            }
            //2021.12.16 정수교 확정(close)인 경우에만 출하성적서 출력 가능.
            if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_Status.Equals("CLOSE"))
            {
                //ESS 인 경우 
                if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MIN_GR == "ESS"
                    || _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MAX_GR == "ESS"
                    )
                {
                    btnEssInsp.Enabled = true;
                }
                else
                {
                    btnEssInsp.Enabled = false;
                }

                if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MIN_GR == "MEB"
                    || _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MAX_GR == "MEB"
                    )
                {
                    btnMebLotTrac.Enabled = true;
                }
                else
                {
                    btnMebLotTrac.Enabled = false;
                }
                
                //simpleButton4.Enabled = true;

            }
            else
            {
                btnEssInsp.Enabled = false;
                btnMebLotTrac.Enabled = false;
                //simpleButton4.Enabled = false;
            }


             

            //MEB 인 경우

        }

        private void DlvConfirm2Main_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _dlvResultList)
            {
                if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_Status != null && _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_Status.Equals("PICKING-CLOSE"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, edit: true);
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(true, edit: false);
                }
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(true, edit: false);
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Main_Bp_Cd = strapLookUpEdit1.EditValue?.ToString();
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_No = null;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_Status = null;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Cust_Doh_No = null;
            btnConfirm.Enabled = false;
            btnEssInsp.Enabled = false;
            base.Refresh_From_ExecuteByRibbonButton();
        }

        //출하확정 버튼
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Cust_Doh_No))
            {
                StrapMessageBox.Show("A002", 15); //고객사 납품번호가 등록되지 않았습니다.
                return;
            }
            //선택행 확정처리 합니다.
            if (StrapMessageBox.Show("A001", 20, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _dlvConfirm2Pocket.BpDlvConfirm(_dlvConfirm2Args.DlvConfirm2ModelArgs);
                    btnConfirm.Enabled = false;
                    _dlvResultList.DataRefresh(_dlvConfirm2Args);
                    _dlvResultDetailList.DataClear(_dlvConfirm2Args);
                    _dlvResultHuList.DataClear(_dlvConfirm2Args);

                    //출하 확정후 출하검사성적서  메세지 
                    simpleButton2_Click(null, null);

                    //출하 확정후 MEB LOT 엑셀 다운로드 메세지
                    simpleButton3_Click(null, null);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //2021.12.28 DRH_NO로 ESS 인지 아닌지 체크 
            // ESS 만 출력 가능.
            //검사성적서를 출력하시겠습니까?
            if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MIN_GR != "ESS"
                || _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MAX_GR != "ESS"
                )
                return;

            if (StrapMessageBox.Show("A001", 108, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EssInspectionReportFactory rf = EssInspectionReportFactory.GetInstance();

                IShowReport _report = rf.ShowReport_Drh(_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_No);
                if (_report != null)
                {
                    _report.ShowPreviewDialog();
                }
                else
                {
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //2022.03.02 DRH_NO로 MEB 인지 아닌지 체크 
            // MEB 만 출력 가능.
            //MEB LOT 정보를 다운로드 하시겠습니까?
            if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MIN_GR != "MEB"
                || _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MAX_GR != "MEB"
                )
                return;

            if (StrapMessageBox.Show("A001", 117, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string _fullPathLpack = "";
                string _fullPathMpack = "";
                FileInfo fileInfo;
                //EXCEL 파일 다이얼로그
                // 날짜_출하지시번호_출하실적번호_Lpack
                saveFileDialog1.FileName = "Default.xlsx";
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                _fullPathLpack = saveFileDialog1.FileName.ToString();
                fileInfo = new FileInfo(_fullPathLpack);


                _fullPathMpack = Path.Combine(fileInfo.DirectoryName
                    , Path.GetFileNameWithoutExtension(_fullPathLpack) + "_Mpack" + System.IO.Path.GetExtension(_fullPathLpack)
                    );


                bool _fileLpackIsAccess = IsFileAccess(_fullPathLpack);
                bool _fileMpackIsAccess = IsFileAccess(_fullPathMpack);

                if (_fileLpackIsAccess == false || _fileMpackIsAccess == false)
                {
                    //열려있는 문서를 닫고 시도해주세요
                    StrapMessageBox.Show("A001", 118);
                    return;
                }



                //데이터 조회.

                List<DlvResultLpackModel> lpackModels = _dlvResultList.GetLpack();
                //2022.05.04 중포장 상세 사용 안함.
                //List<DlvResultMpackModel> mpackModels = _dlvResultList.GetMpack();


                //저장
                ExportExcel(_fullPathLpack, lpackModels);

                //2022.05.04 중포장 상세 사용 안함.
                //ExportExcel(_fullPathMpack, mpackModels);


                // Create the FileStream object with the specified file path. 


                //오픈
                // Open the XLSX document using the default application.
                System.Diagnostics.Process.Start(_fullPathLpack);

                //2022.05.04 중포장 상세 사용 안함.
                //System.Diagnostics.Process.Start(_fullPathMpack);


            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //2022.03.03 DRH_NO로 MEB 인지 아닌지 체크 
            // MEB 만 출력 가능.
            //MEB LOT 정보를 다운로드 하시겠습니까?

            if (_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MIN_GR != "MEB"
                || _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_MAX_GR != "MEB"
                )
                return;

            //MEB LOT 상세 조회 팝업
            if (string.IsNullOrEmpty(_dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Drh_No))
                return;

            _dlvCMebDetailPopup = new DlvCMebDetailPopup(_dlvConfirm2Args, _dlvConfirm2Pocket);
            _dlvCMebDetailPopup.ShowDialog();

        }
        private bool IsFileAccess(string _path)
        {
            try
            {
                using (FileStream stream = new FileStream(_path, FileMode.Create, FileAccess.ReadWrite))
                {

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ExportExcel(string _FullPath, List<DlvResultLpackModel> models)
        {
            // Create an exporter instance. 
            IXlExporter exporter = XlExport.CreateExporter(XlDocumentFormat.Xlsx);
            using (FileStream stream = new FileStream(_FullPath, FileMode.Create, FileAccess.ReadWrite))
            {
                using (IXlDocument document = exporter.CreateDocument(stream))
                {

                    // Add a new worksheet to the document. 
                    using (IXlSheet sheet = document.CreateSheet())
                    {

                        // Specify the worksheet name.
                        sheet.Name = "Lpack List";

                        foreach (var prop in typeof(DlvResultLpackModel).GetProperties())
                        {
                            using (IXlColumn column = sheet.CreateColumn())
                            {
                                switch (prop.Name)
                                {
                                    case "PACK_NO":
                                    case "M_PACK_NO":
                                    case "PART_LOT":
                                        column.WidthInPixels = 200;
                                        break;
                                    case "CASE_NO":
                                    case "ORDER_NO":
                                    case "PART_NO":
                                    case "QTY":
                                    case "LOT":
                                    case "WORK_DATE":
                                    case "PACK_DATE":
                                    case "SHIP_DATE":

                                        column.WidthInPixels = 100;
                                        break;
                                    default:
                                        column.WidthInPixels = 100;
                                        break;
                                }

                                //column.WidthInPixels = 100;
                                //Type p =prop.PropertyType;
                                if (prop.PropertyType == typeof(int))
                                {
                                    column.Formatting = new XlCellFormatting();
                                    column.Formatting.NumberFormat = "#,#";
                                }

                            }

                            //헤더 만들때 사용
                            //b= ((DisplayAttribute)prop.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DisplayAttribute)).SingleOrDefault())?.Name;
                        }


                        // Specify cell font attributes.
                        XlCellFormatting cellFormatting = new XlCellFormatting();
                        cellFormatting.Font = new XlFont();
                        cellFormatting.Font.Name = "Calibri";
                        cellFormatting.Font.SchemeStyle = XlFontSchemeStyles.None;

                        // Specify formatting settings for the header row.
                        XlCellFormatting headerRowFormatting = new XlCellFormatting();
                        headerRowFormatting.CopyFrom(cellFormatting);
                        headerRowFormatting.Font.Bold = true;
                        headerRowFormatting.Font.Color = XlColor.FromTheme(XlThemeColor.Light1, 0.0);
                        headerRowFormatting.Fill = XlFill.SolidFill(XlColor.FromTheme(XlThemeColor.Dark2, 0.0));

                        // Create the header row.
                        using (IXlRow row = sheet.CreateRow())
                        {
                            foreach (var prop in typeof(DlvResultLpackModel).GetProperties())
                            {
                                using (IXlCell cell = row.CreateCell())
                                {
                                    string displayName = ((DisplayAttribute)prop.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DisplayAttribute)).SingleOrDefault())?.Name;
                                    cell.Value = string.IsNullOrEmpty(displayName) == true ? prop.Name : displayName;
                                    cell.ApplyFormatting(headerRowFormatting);
                                }
                            }

                        }

                        // Generate data for the sales report.
                        foreach (var model in models)
                        {
                            using (IXlRow row = sheet.CreateRow())
                            {
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.PACK_NO;
                                    cell.ApplyFormatting(cellFormatting);
                                }

                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.M_PACK_NO;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.PART_LOT;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.CASE_NO;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.ORDER_NO;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.PART_NO;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.QTY;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.LOT;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.WORK_DATE;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.PACK_DATE;
                                    cell.ApplyFormatting(cellFormatting);
                                }
                                using (IXlCell cell = row.CreateCell())
                                {
                                    cell.Value = model.SHIP_DATE;
                                    cell.ApplyFormatting(cellFormatting);
                                }

                            }
                        }


                        // Enable AutoFilter for the created cell range.
                        sheet.AutoFilterRange = sheet.DataRange;

                        //// Specify formatting settings for the total row.
                        //XlCellFormatting totalRowFormatting = new XlCellFormatting();
                        //totalRowFormatting.CopyFrom(cellFormatting);
                        //totalRowFormatting.Font.Bold = true;
                        //totalRowFormatting.Fill = XlFill.SolidFill(XlColor.FromTheme(XlThemeColor.Accent5, 0.6));

                        //// Create the total row.
                        //using (IXlRow row = sheet.CreateRow())
                        //{
                        //    using (IXlCell cell = row.CreateCell())
                        //    {
                        //        cell.ApplyFormatting(totalRowFormatting);
                        //    }
                        //    using (IXlCell cell = row.CreateCell())
                        //    {
                        //        cell.Value = "Total amount";
                        //        cell.ApplyFormatting(totalRowFormatting);
                        //        cell.ApplyFormatting(XlCellAlignment.FromHV(XlHorizontalAlignment.Right, XlVerticalAlignment.Bottom));
                        //    }
                        //    using (IXlCell cell = row.CreateCell())
                        //    {
                        //        // Add values in the cell range C2 through C9 using the SUBTOTAL function. 
                        //        cell.SetFormula(XlFunc.Subtotal(XlCellRange.FromLTRB(2, 1, 2, 8), XlSummary.Sum, true));
                        //        cell.ApplyFormatting(totalRowFormatting);
                        //    }
                        //}
                    }
                }
            }
        }

        #region 2022.05.04 중포장 상세 사용 안함
        //private void ExportExcel(string _FullPath, List<DlvResultMpackModel> models)
        //{
        //    IXlExporter exporter = XlExport.CreateExporter(XlDocumentFormat.Xlsx);
        //    using (FileStream stream = new FileStream(_FullPath, FileMode.Create, FileAccess.ReadWrite))
        //    {
        //        using (IXlDocument document = exporter.CreateDocument(stream))
        //        {

        //            // Add a new worksheet to the document. 
        //            using (IXlSheet sheet = document.CreateSheet())
        //            {

        //                // Specify the worksheet name.
        //                sheet.Name = "Mpack List";

        //                foreach (var prop in typeof(DlvResultMpackModel).GetProperties())
        //                {
        //                    using (IXlColumn column = sheet.CreateColumn())
        //                    {
        //                        switch (prop.Name)
        //                        {
        //                            case "PACK_NO":
        //                            case "PART_LOT":

        //                                column.WidthInPixels = 200;
        //                                break;
        //                            case "PACK_DATE":
        //                            case "SHIP_DATE":
        //                                column.WidthInPixels = 100;
        //                                break;
        //                            default:
        //                                column.WidthInPixels = 100;
        //                                break;
        //                        }

        //                        //column.WidthInPixels = 100;
        //                        //Type p =prop.PropertyType;
        //                        if (prop.PropertyType == typeof(int))
        //                        {
        //                            column.Formatting = new XlCellFormatting();
        //                            column.Formatting.NumberFormat = "#,#";
        //                        }

        //                    }

        //                    //헤더 만들때 사용
        //                    //b= ((DisplayAttribute)prop.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DisplayAttribute)).SingleOrDefault())?.Name;
        //                }


        //                // Specify cell font attributes.
        //                XlCellFormatting cellFormatting = new XlCellFormatting();
        //                cellFormatting.Font = new XlFont();
        //                cellFormatting.Font.Name = "Calibri";
        //                cellFormatting.Font.SchemeStyle = XlFontSchemeStyles.None;

        //                // Specify formatting settings for the header row.
        //                XlCellFormatting headerRowFormatting = new XlCellFormatting();
        //                headerRowFormatting.CopyFrom(cellFormatting);
        //                headerRowFormatting.Font.Bold = true;
        //                headerRowFormatting.Font.Color = XlColor.FromTheme(XlThemeColor.Light1, 0.0);
        //                headerRowFormatting.Fill = XlFill.SolidFill(XlColor.FromTheme(XlThemeColor.Dark2, 0.0));

        //                // Create the header row.
        //                using (IXlRow row = sheet.CreateRow())
        //                {
        //                    foreach (var prop in typeof(DlvResultMpackModel).GetProperties())
        //                    {
        //                        using (IXlCell cell = row.CreateCell())
        //                        {
        //                            string displayName = ((DisplayAttribute)prop.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DisplayAttribute)).SingleOrDefault())?.Name;
        //                            cell.Value = string.IsNullOrEmpty(displayName) == true ? prop.Name : displayName;
        //                            cell.ApplyFormatting(headerRowFormatting);
        //                        }
        //                    }

        //                }

        //                // Generate data for the sales report.
        //                foreach (var model in models)
        //                {
        //                    using (IXlRow row = sheet.CreateRow())
        //                    {
        //                        using (IXlCell cell = row.CreateCell())
        //                        {
        //                            cell.Value = model.PACK_NO;
        //                            cell.ApplyFormatting(cellFormatting);
        //                        }

        //                        using (IXlCell cell = row.CreateCell())
        //                        {
        //                            cell.Value = model.PART_LOT;
        //                            cell.ApplyFormatting(cellFormatting);
        //                        }
        //                        using (IXlCell cell = row.CreateCell())
        //                        {
        //                            cell.Value = model.PACK_DATE;
        //                            cell.ApplyFormatting(cellFormatting);
        //                        }
        //                        using (IXlCell cell = row.CreateCell())
        //                        {
        //                            cell.Value = model.SHIP_DATE;
        //                            cell.ApplyFormatting(cellFormatting);
        //                        }


        //                    }
        //                }


        //                // Enable AutoFilter for the created cell range.
        //                sheet.AutoFilterRange = sheet.DataRange;


        //            }
        //        }
        //    }
        //}
        #endregion
        
        //출하취소 버튼 20220506
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelPopup cancelPopup = new CancelPopup();
            var rst = cancelPopup.ShowDialog();
            if (rst == DialogResult.OK)
            {

            }
        }
    }
}
