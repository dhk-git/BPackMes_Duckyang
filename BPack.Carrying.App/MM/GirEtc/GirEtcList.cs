using BPack.Common.Config;
using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirEtc;
using BPack.Pocket.App.MM.GirEtc;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.GirEtc
{
    public partial class GirEtcList : StrapSubForm_OnlyOneGrid_V2
    {
        GirEtcArgs _girEtcArgs;
        GirEtcPocket _girEtcPocket;
        private GirEtcEditForm _girEtcEditForm;

        public GirEtcList()
        {
            InitializeComponent();
        }
        public GirEtcList(GirEtcArgs girEtcArgs, GirEtcPocket girEtcPocket) : this()
        {
            _girEtcArgs = girEtcArgs;
            _girEtcPocket = girEtcPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = girEtcModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girEtcArgs,
                GridView = gridView1,
                InitModelType = typeof(GirEtcModel),
                ModelArgs = _girEtcArgs.GirEtcModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirEtcModelArgs, GirEtcModel>(_girEtcPocket.SelectHeaderModels, _girEtcPocket.SaveModel, _girEtcPocket.SaveModels);
            //  colIsCheck.Visible = false;

            // LookUpEditHelper.SetGridColumnCommonCode(colBASE_UNIT, _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd, "UNIT");
            _girEtcEditForm = new GirEtcEditForm(_girEtcArgs);
            gridView1.OptionsEditForm.CustomEditFormLayout = _girEtcEditForm;
            gridView1.EditFormPrepared += GridView1_EditFormPrepared;

            LookUpEditHelper.SetGridColumnByQuery(colGIR_TYPE_CD, "GirType_A002", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, INOUT_CLS = "" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnSysCode(colINOUT_CLS, "INOUT_CLS");
            LookUpEditHelper.SetGridColumnSysCode(colETC_GIR_TYPE, "ETC_GIR_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colETC_GIR_STATUS, "ETC_GIR_STATUS");
            LookUpEditHelper.SetWareHouse(colWH_CD, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode);


        }

        private void GridView1_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
            _girEtcEditForm.DataRefresh(girEtcModelBindingSource.Current);
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((GirEtcModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((GirEtcModel)model).PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            //((GirEtcModel)model).WH_CD = _girEtcArgs.GirEtcModelArgs.Select_Main_WH_CD;
            base.SetInsertDefaultValue(model);
        }

        public GirEtcModel GetSelectedModel()
        {
            return girEtcModelBindingSource.Current as GirEtcModel;
        }


        //internal void EtcInList()
        //{

        //    gridView1.PostEditor();
        //    gridView1.UpdateCurrentRow();
        //    //var checkedModels = ((List<GirEtcModel>)SelectedModels).Where(a => a.IsCheck == true).ToList();
        //    var checkedModel = girEtcModelBindingSource.Current as GirEtcModel;
        //    if (checkedModel == null )
        //    {
        //        StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
        //        return;
        //    }
        //    if (StrapMessageBox.Show("A001", 102, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택된 행 입/출고 처리합니다.
        //    {
        //        try
        //        {
        //            //checkedModel.ETC_GIR_STATUS = "CLOSE";
        //            _girEtcPocket.SaveInOutModel(checkedModel);
                    
        //            DataRefresh(_girEtcArgs);
        //        }
        //        catch (Exception ex)
        //        {
        //            StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
        //        }
         
        //    };

        //}
    }
}
