using BPack.Common.LoginInfo;
using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrReg;
using BPack.Pocket.App.QC.NcrReg;
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

namespace BPack.Carrying.App.QC.NcrReg
{
    public partial class NcrRegDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private NcrRegArgs _ncrRegArgs;
        private NcrRegPocket _regPocket;


        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;
        public NcrRegDetailList()
        {
            InitializeComponent();
        }
        public NcrRegDetailList(NcrRegArgs ncrRegArgs, NcrRegPocket regPocket):this()
        {
            this._ncrRegArgs = ncrRegArgs;
            this._regPocket = regPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = ncrRegDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _ncrRegArgs,
                GridView = gridView1,
                InitModelType = typeof(NcrRegDetailModel),
                ModelArgs = _ncrRegArgs.NcrRegModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            
            

            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += _itemMasterRepositoryButtonEdit_ItemMasterModelSelected;
            InitPocketDelegate<NcrRegModelArgs, NcrRegDetailModel>
                (_regPocket.SelectNcrRegDetailModels, _regPocket.SaveNcrRegDetailModel, _regPocket.SaveNcrRegDetailModels);
        }

        private void _itemMasterRepositoryButtonEdit_ItemMasterModelSelected(object sender, ItemMasterSelectedEventArgs e)
        {
            gridView1.PostEditor();
            ((NcrRegDetailModel)ncrRegDetailModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
            ((NcrRegDetailModel)ncrRegDetailModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
            ((NcrRegDetailModel)ncrRegDetailModelBindingSource.Current).ITEM_TYPE_CD = e.SeletedItemMasterModel.ITEM_TYPE_CD;
            ((NcrRegDetailModel)ncrRegDetailModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;

            gridView1.UpdateCurrentRow();
            gridView1.BestFitColumns();
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType"
                , new {
                    COMP_CD= ((NcrRegArgs)args).NcrRegModelArgs.Comp_cd
                }    , "Code", "Name");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup"
                , new {
                    COMP_CD = ((NcrRegArgs)args).NcrRegModelArgs.Comp_cd,
                    PLANT_CD = ((NcrRegArgs)args).NcrRegModelArgs.Plant_cd,
                    ITEM_GR_CLS= "ITEM_GR_1"
                }
                , "Code", "Name");

            LookUpEditHelper.SetGridColumnCommonCode(colDEFECT_CD, ((NcrRegArgs)args).NcrRegModelArgs.Comp_cd, "DEFECT_CD");
            _itemMasterRepositoryButtonEdit.InitCompCode(_ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_ncrRegArgs.NcrRegModelArgs.Select_Main_Plant_Cd);
        }

        public override void AddNew(ArgsBase args)
        {
            if (_ncrRegArgs.NcrRegModelArgs.NCH_STATUS == "CLOSE")
            {
                //2022.04.04 
                //이미 확정된 데이터가 있습니다
                StrapMessageBox.Show("A001", 119);
                return;
            }
            base.AddNew(args);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((NcrRegDetailModel)model).COMP_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd;
            ((NcrRegDetailModel)model).PLANT_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Plant_Cd;
            ((NcrRegDetailModel)model).NCH_NO = _ncrRegArgs.NcrRegModelArgs.NCH_NO_KEY;
            ((NcrRegDetailModel)model).DEFECT_QTY = 1;


            _itemMasterRepositoryButtonEdit.InitCompCode(_ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_ncrRegArgs.NcrRegModelArgs.Select_Main_Plant_Cd);

            base.SetInsertDefaultValue(model);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((NcrRegDetailModel)ncrRegDetailModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "");
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                }
                else
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, itemModel.ITEM_TYPE_CD);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                }

            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            SimplePocket simplePocket;
            DataTable source;
            switch (e.Column.FieldName)
            {
                case "DEFECT_CD":
                    simplePocket = SimplePocket.GetInstance();
                    source = simplePocket.SelectData("CommonCode_Basic", new
                    {
                        COMP_Code = _ncrRegArgs.NcrRegModelArgs.Comp_cd,
                        P_CODE= "DEFECT_CD",
                        LANG_CODE=UserInfo.Sys_Language
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit
                        (dataSource: source
                        , valueMember: "C_CODE", displayMember: "C_NAME");

                    break;
            }
        }
    }
}
