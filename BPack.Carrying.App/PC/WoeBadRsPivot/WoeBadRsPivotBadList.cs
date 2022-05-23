using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WoeBadRsPivot;
using BPack.Pocket.App.PC.WoeBadRsPivot;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.WoeBadRsPivot
{
    public partial class WoeBadRsPivotBadList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeBadRsPivotArgs _woeBadRsPivotArgs;
        private WoeBadRsPivotPocket _woeBadRsPivotPocket;
        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;
        public WoeBadRsPivotBadList()
        {
            InitializeComponent();
        }

        public WoeBadRsPivotBadList(WoeBadRsPivotArgs woeBadRsPivotArgs, WoeBadRsPivotPocket woeBadRsPivotPocket) : this()
        {
            this._woeBadRsPivotArgs = woeBadRsPivotArgs;
            this._woeBadRsPivotPocket = woeBadRsPivotPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = badRsPivotBadModelBindingSource,
                FormArgs = _woeBadRsPivotArgs,
                ModelArgs = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs,
                InitModelType = typeof(BadRsPivotBadModel),
                StrapEditMode = StrapEditMode.Batch,
                GridView = gridView1
            });
            InitPocketDelegate<WoeBadRsPivotModelArgs, BadRsPivotBadModel>(
               _woeBadRsPivotPocket.SelectBadRsPivotBadModels
               , _woeBadRsPivotPocket.SaveBadRsPivotBadModel
               , _woeBadRsPivotPocket.SaveBadRsPivotBadModels
               );

            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += _itemMasterRepositoryButtonEdit_ItemMasterModelSelected;

            colWORK_DT.MinWidth = 120;
            colITEM_CD.MinWidth = 170;
            colITEM_NM.MinWidth = 220;
            
            DataRefreshLookUpEdit();
            
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            ((BadRsPivotBadModel)model).COMP_CD
                = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd;
            ((BadRsPivotBadModel)model).PLANT_CD
                = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd;
            ((BadRsPivotBadModel)model).WC_CD
                = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Wc_Cd;
            _itemMasterRepositoryButtonEdit.InitCompCode(_woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd);
        }

        private void _itemMasterRepositoryButtonEdit_ItemMasterModelSelected(object sender, ItemMasterSelectedEventArgs e)
        {
            gridView1.PostEditor();
            ((BadRsPivotBadModel)badRsPivotBadModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
            ((BadRsPivotBadModel)badRsPivotBadModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
            //((BadRsPivotBadModel)badRsPivotBadModelBindingSource.Current).ITEM_TYPE_CD = e.SeletedItemMasterModel.ITEM_TYPE_CD;
            ((BadRsPivotBadModel)badRsPivotBadModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;

            gridView1.UpdateCurrentRow();
            gridView1.BestFitColumns();
            
        }
        
        

        private void DataRefreshLookUpEdit()
        {
            //작업장
            CommonMes.Helpers.LookUpEditHelper.SetWorkCenter(colWC_CD,
                   _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd
                   , _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd
                   );

            //불량 코드
            LookUpEditHelper.SetGridColumnCommonCode(colDEFECT_CD
                , _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd
                , "DEFECT_CD");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup",
                new
                {
                   COMP_CD = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd,
                   PLANT_CD = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd,
                   ITEM_GR_CLS = "ITEM_GR_1"
                }, "제품군", "제품군");

        }

        public override void DataRefresh(ArgsBase args)
        {
            
            base.DataRefresh(args);
            DataRefreshLookUpEdit();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((BadRsPivotBadModel)badRsPivotBadModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    //gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                }
                else
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    //gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, itemModel.ITEM_TYPE_CD);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                }
            }
        }

        private void gridView1_CustomRowCellEditForEditing_1(object sender, CustomRowCellEditEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var sp = SimplePocket.GetInstance();
            switch (e.Column.FieldName)
            {
                case "WC_CD":
                    var source2 = sp.SelectData("CommonMes_WorkCenter", new
                    {
                        COMP_CD = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd,
                        PLANT_CD = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd,
                        WC_TYPE=""
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source2, valueCaption: "CODE", displayCaption: "NAME");
                    break;

            }
        }
    }
}
