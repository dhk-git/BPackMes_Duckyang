using BPack.Common.Model;
using BPack.Model.App.MD.ItmItemInfo;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmItemInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.ItmItemType;

namespace BPack.Carrying.App.MD.ItmItemInfo
{
    public partial class ItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmItemInfoArgs _itmItemInfoArgs;
        private ItmItemInfoPocket _itmItemInfoPocket;
        private Dictionary<string, int> _columnSortNo;
        private List<ItemTypeItemModel> _typeList = null;
        //private ItemListEditForm _ItmItemInfoEditForm;

        //int _ItmItemInfoEditFormWidth;

        public ItemList(ItmItemInfoArgs itmItemInfoArgs, ItmItemInfoPocket itmItemInfoPocket)
        {
            InitializeComponent();

            _itmItemInfoArgs = itmItemInfoArgs;
            _itmItemInfoPocket = itmItemInfoPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = itemInfoModelBindingSource,
                FormArgs = _itmItemInfoArgs,
                ModelArgs = _itmItemInfoArgs.itmItemInfoModelArgs,
                InitModelType = typeof(ItemInfoModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ItmItemInfoModelArgs, ItemInfoModel>(_itmItemInfoPocket.SelectItemInfoModels, _itmItemInfoPocket.SaveItemInfoModel, _itmItemInfoPocket.SaveItemInfoModels);


            //LookUpEditHelper.SetGridColumnSysCode(colFIFO_FG, "FIFO_FG");

            //_ItmItemInfoEditForm = new ItemListEditForm(_itmItemInfoArgs);
            //_ItmItemInfoEditFormWidth = _ItmItemInfoEditForm.Width;

            //gridView1.OptionsEditForm.CustomEditFormLayout = _ItmItemInfoEditForm;
            //gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            //{
            //    _ItmItemInfoEditForm.DataRefresh(itemInfoModelBindingSource.Current);
            //    e.Panel.Parent.Width = _ItmItemInfoEditFormWidth + 113;
            //};
            colIsCheck.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colITEM_CD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colITEM_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            
            _columnSortNo = new Dictionary<string, int>();
            int i = 1;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                _columnSortNo.Add(col.FieldName, i);
                i++;
            }
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((ItemInfoModel)model).COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code;
            ((ItemInfoModel)model).PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code;
            ((ItemInfoModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((ItemInfoModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);
            ((ItemInfoModel)model).BASE_UNIT = "EA";
            ((ItemInfoModel)model).LT_UNIT = "WEEK";
            ((ItemInfoModel)model).ITEM_TYPE_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Type_CD;
            //((ItemInfoModel)model).ITEM_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Code;
            //((ItemInfoModel)model).ITEM_NM = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Name;

        }
        
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code }, "CODE", "NAME");
            //LookUpEditHelper.SetGridColumnCommonCode(colHU_UNIT, _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, "UNIT");
            LookUpEditHelper.SetGridColumnCommonCode(colBASE_UNIT, _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, "UNIT");
            LookUpEditHelper.SetGridColumnCommonCode(colWEIGHT_UNIT, _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, "UNIT");
            //LookUpEditHelper.SetGridColumnCommonCode(colFIFO_FG, _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, "FG_YN");

            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_2" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_3, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_3" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_4, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_4" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_5, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_5" }, "CODE", "NAME");

            //LookUpEditHelper.SetGridColumnByQuery(colMAT_IN_WH, "WareHouses", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code }, "창고코드", "창고명");
            //LookUpEditHelper.SetGridColumnByQuery(colPROD_IN_WH, "WareHouses", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code }, "창고코드", "창고명");
            //LookUpEditHelper.SetGridColumnByQuery(colMAT_IN_LOC, "Locations", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, WH_CD = "" }, "위치코드", "위치명");
            //LookUpEditHelper.SetGridColumnByQuery(colPROD_IN_LOC, "Locations", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, WH_CD = "" }, "위치코드", "위치명");
            //가렸던 컬럼 보여주고,
            //if (_typeList != null)
            //{
            //    foreach (ItemTypeItemModel List in _typeList)
            //    {
            //        gridView1.Columns[List.COL_PHYSI_NM].Visible = true;

            //    }
            //}
            gridView1.BeginUpdate();
            //컬럼 활성화 데이터
            _typeList = _itmItemInfoPocket.SelectItemInfoColumnsModels(new ItemInfoModel
            {
                COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code,
                ITEM_TYPE_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Type_CD
            });
            //컬럼 활성화
            foreach (ItemTypeItemModel list in _typeList)
            {
                gridView1.Columns[list.COL_PHYSI_NM].Visible = list.VISIBLE;
            }
            //다시 순서지정
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                if (col.Visible == true)
                {
                    col.VisibleIndex = _columnSortNo[col.FieldName];
                }
            }
            colIsCheck.VisibleIndex = 0;
            gridView1.EndUpdate();
        }

    }
}
