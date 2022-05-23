using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.IqcInsp;
using BPack.Pocket.App.QC.IqcInsp;
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

namespace BPack.Carrying.App.QC.IqcInsp
{
    public partial class IqcInspFailList : StrapSubForm_OnlyOneGrid_V2
    {
        IqcInspArgs _iqcInspArgs;
        IqcInspPocket _iqcInspPocket;
        //ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;
        private IqcInspItemList _IqcInspItemList;
        public event EventHandler Event_DetailModeldUpdated;


        public IqcInspFailList()
        {
            InitializeComponent();
        }
        public IqcInspFailList(IqcInspArgs iqcInspArgs, IqcInspPocket iqcInspPocket) : this()
        {
            _iqcInspArgs = iqcInspArgs;
            _iqcInspPocket = iqcInspPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _IqcInspItemList = new IqcInspItemList(_iqcInspArgs, _iqcInspPocket);
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = IqcInspFailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _iqcInspArgs,
                GridView = gridView1,
                InitModelType = typeof(IqcInspFailModel),
                ModelArgs = _iqcInspArgs.IqcInspModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<IqcInspModelArgs, IqcInspFailModel>(_iqcInspPocket.SelectFailModels, _iqcInspPocket.SaveFailModel, _iqcInspPocket.SaveFailModels);
            //_itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            //_itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            //{
            //    gridView1.PostEditor();
            //    ((IqcInspFailModel)iqcInspItemModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
            //    ((IqcInspFailModel)iqcInspItemModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;

            //    gridView1.UpdateCurrentRow();
            //    gridView1.BestFitColumns();
            //};

            LookUpEditHelper.SetGridColumnCommonCode(colDEFECT_CD, Common.LoginInfo.UserInfo.CompCode, "DEFECT_CD");
            LookUpEditHelper.SetGridColumnCommonCode(colIQC_RESPON_CD, Common.LoginInfo.UserInfo.CompCode, "IQC_RESPON_CD");

            //  colIsCheck.Visible = false;

            // LookUpEditHelper.SetGridColumnCommonCode(colBASE_UNIT, _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd, "UNIT");
        }
        public override void DataRefresh(ArgsBase args)
        {
            //LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd, PLANT_CD = _girHistArgs.GirHistModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");
            //LookUpEditHelper.SetGridColumnByQuery(colGIR_TYPE_CD, "GirType", new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd }, "수불유형코드", "수불유형명");
            //LookUpEditHelper.SetItemType(colITEM_TYPE, _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd);
            //            _IqcInspItemList.DataRefresh(_iqcInspArgs);
            base.DataRefresh(args);

        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            //((IqcInspFailModel)model).COMP_CD = _iqcInspArgs.IqcInspModelArgs.Select_Main_Comp_cd;
            //((IqcInspFailModel)model).PLANT_CD = _iqcInspArgs.IqcInspModelArgs.Select_Main_Plant_cd;

            ((IqcInspFailModel)model).IQD_NO = _iqcInspArgs.IqcInspModelArgs.Select_SUB_IQD_NO;
            ((IqcInspFailModel)model).IQD_NO_KEY = _iqcInspArgs.IqcInspModelArgs.Select_SUB_IQD_NO;
            ((IqcInspFailModel)model).DEFECT_QTY = 1;

        }

        public override void Save(ArgsBase args)
        {
            base.Save(args);
            Event_DetailModeldUpdated?.Invoke(this, null);
        }

        public override void Delete(ArgsBase args)
        {
            base.Delete(args);
            Event_DetailModeldUpdated?.Invoke(this, null);
        }

    }
}
