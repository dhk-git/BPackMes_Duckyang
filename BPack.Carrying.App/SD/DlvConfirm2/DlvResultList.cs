using BPack.Common.Command;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvConfirm2;
using BPack.Pocket.App.SD.DlvConfirm2;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.SD.DlvConfirm2
{
    public partial class DlvResultList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvConfirm2Args _dlvConfirm2Args;
        private DlvConfirm2Pocket _dlvConfirm2Pocket;
        private DlvResultEditForm _dlvResultEditForm;

        public DlvResultList()
        {
            InitializeComponent();
        }

        public DlvResultList(DlvConfirm2Args dlvConfirm2Args, DlvConfirm2Pocket dlvConfirm2Pocket) : this()
        {
            this._dlvConfirm2Args = dlvConfirm2Args;
            this._dlvConfirm2Pocket = dlvConfirm2Pocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = dlvResultModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvConfirm2Args,
                GridView = gridView1,
                InitModelType = typeof(DlvResultModel),
                ModelArgs = _dlvConfirm2Args.DlvConfirm2ModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            _dlvResultEditForm = new DlvResultEditForm(_dlvConfirm2Args, _dlvConfirm2Pocket);
            InitPocketDelegate<DlvConfirm2ModelArgs, DlvResultModel>(_dlvConfirm2Pocket.SelectDlvResultModels, _dlvConfirm2Pocket.SaveDlvResultModel);
            gridView1.OptionsEditForm.CustomEditFormLayout = _dlvResultEditForm;
            gridView1.EditFormPrepared += GridView1_EditFormPrepared;
            //LookUpEditHelper.SetGridColumnByQuery(colVEHICLE_NO, "CarAndDriverList", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "CODE", "NAME", false);
            //((RepositoryItemLookUpEdit)colVEHICLE_NO.ColumnEdit).EditValueChanged += DlvResultList_EditValueChanged;
            //((RepositoryItemLookUpEdit)colVEHICLE_NO.ColumnEdit).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //((RepositoryItemLookUpEdit)colVEHICLE_NO.ColumnEdit).ProcessNewValue += DlvResultList_ProcessNewValue;

        }

        private void GridView1_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
            _dlvResultEditForm.DataRefresh(dlvResultModelBindingSource.Current);
        }

        public List<DlvResultLpackModel> GetLpack()
        {
            return _dlvConfirm2Pocket.SelectDlvResultLpackModel(_dlvConfirm2Args.DlvConfirm2ModelArgs);
        }
        public List<DlvResultMpackModel> GetMpack()
        {
            return _dlvConfirm2Pocket.SelectDlvResultMpackModel(_dlvConfirm2Args.DlvConfirm2ModelArgs);
        }




        //private void DlvResultList_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        //{
        //   ((List<LookUpEditDefaultModel>)((RepositoryItemLookUpEdit)colVEHICLE_NO.ColumnEdit).DataSource).Add(new LookUpEditDefaultModel() { CODE = e.DisplayValue.ToString(), NAME = e.DisplayValue.ToString() });
        //    e.Handled = true;
        //}

        //private SimplePocket _sp = SimplePocket.GetInstance();


        //private void DlvResultList_EditValueChanged(object sender, EventArgs e)
        //{
        //    gridView1.PostEditor();
        //    var driver = _sp.SelectData<Driver>("GetDriver", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, C_CODE = gridView1.GetFocusedRowCellDisplayText(colVEHICLE_NO)}).SingleOrDefault()?.Value_2;
        //    gridView1.SetFocusedRowCellValue(colDRIVER_NM, driver);
        //}
        //public class Driver
        //{
        //    public string Value_2 { get; set; }
        //}


    }
}
