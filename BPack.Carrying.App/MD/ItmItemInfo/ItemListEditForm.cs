using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Strap.FormControls;
using BPack.Model.App.MD.ItmItemInfo;
using BPack.Strap.EditControls;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.ItmItemInfo
{
    public partial class ItemListEditForm : StrapEditForm
    {
        private ItemInfoModel _itemInfoModel;
        private ItmItemInfoArgs _itmItemInfoArgs;

        public ItemListEditForm(ItmItemInfoArgs itmItemInfoArgs)
        {
            InitializeComponent();

            _itmItemInfoArgs = itmItemInfoArgs;

            InitBoundFieldName<ItemInfoModel>(strapDataLayout1);

            LookUpEditHelper.SetSysCode(INDI_HU_FGLookUpEdit, "INDI_HU_FG", false);
            LookUpEditHelper.SetSysCode(MAT_IN_FGLookUpEdit, "MAT_IN_FG", false);
            //LookUpEditHelper.SetSysCode(MAT_COMM_FGLookUpEdit, "MAT_COMM_FG", false);
            LookUpEditHelper.SetSysCode(MAT_INPUT_TYPELookUpEdit, "MAT_INPUT_TYPE", false);
            MAT_IN_WHLookUpEdit.EditValueChanged += MAT_IN_WHLookUpEdit_EditValueChanged;
            PROD_IN_WHLookUpEdit.EditValueChanged += PROD_IN_WHLookUpEdit_EditValueChanged;
        }

        private void PROD_IN_WHLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (PROD_IN_WHLookUpEdit.DataBindings.Count > 1)
            {
                PROD_IN_WHLookUpEdit.DataBindings[0]?.WriteValue();
            }
            LookUpEditHelper.SetByQuery(PROD_IN_LOCLookUpEdit, "Locations", new
            {
                COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code,
                PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code,
                WH_CD = PROD_IN_WHLookUpEdit.EditValue?.ToString()
            }, "위치코드", "위치명");
            //PROD_IN_LOCLookUpEdit.DataBindings?[0]?.WriteValue();
        }

        private void MAT_IN_WHLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (MAT_IN_WHLookUpEdit.DataBindings.Count > 1)
            {
                MAT_IN_WHLookUpEdit.DataBindings[0]?.WriteValue();
            }
            LookUpEditHelper.SetByQuery(MAT_IN_LOCLookUpEdit, "Locations", new
            {
                COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code,
                PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code,
                WH_CD = MAT_IN_WHLookUpEdit.EditValue?.ToString()
            }, "위치코드", "위치명");
            //MAT_IN_LOCLookUpEdit.DataBindings?[0]?.WriteValue();
        }

        public void DataRefresh(object datasource)
        {
            _itemInfoModel = (ItemInfoModel)datasource;
            itemInfoModelBindingSource.DataSource = _itemInfoModel;

            LookUpEditHelper.SetByQuery(ITEM_TYPELookUpEdit, "ItemType", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code }, "품목유형코드", "품목유형명");
            LookUpEditHelper.SetByQuery(ITEM_GR_1LookUpEdit, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
            LookUpEditHelper.SetByQuery(ITEM_GR_2LookUpEdit, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_2" }, "CODE", "NAME");
            LookUpEditHelper.SetByQuery(ITEM_GR_3LookUpEdit, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_3" }, "CODE", "NAME");
            
            LookUpEditHelper.SetCommonCode(HU_UNITLookUpEdit, _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, "UNIT", false);
            LookUpEditHelper.SetCommonCode(BASE_UNITLookUpEdit, _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, "UNIT", false);
            LookUpEditHelper.SetCommonCode(WEIGHT_UNITLookUpEdit, _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, "UNIT", false);
            LookUpEditHelper.SetCommonCode(FIFO_FGLookUpEdit, _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, "FG_YN", false);

            LookUpEditHelper.SetByQuery(MAT_IN_WHLookUpEdit, "ItmItem.WareHouse", new
            {
                COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code,
                PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code,
                WH_GR = "RAW"
            }, "창고코드", "창고명");

            //MAT_IN_WHLookUpEdit.DataBindings[0]?.WriteValue();
            LookUpEditHelper.SetByQuery(PROD_IN_WHLookUpEdit, "ItmItem.WareHouse", new
            {
                COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code,
                PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code,
                WH_GR = "PROD"
            }, "창고코드", "창고명");
            //PROD_IN_WHLookUpEdit.DataBindings[0]?.WriteValue();

        }

    }
}
