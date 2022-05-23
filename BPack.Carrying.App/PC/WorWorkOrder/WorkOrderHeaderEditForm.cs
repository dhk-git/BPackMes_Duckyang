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
using BPack.Model.App.PC.WorWorkOrder;
using BPack.Pocket.App.PC.WorWorkOrder;
using BPack.Strap.EditControls;
using BPack.CommonMes.Helpers;
using BPack.CommonMes.Controls.ItemMaster;

namespace BPack.Carrying.App.PC.WorWorkOrder
{
    public partial class WorkOrderHeaderEditForm : StrapEditForm
    {
        private WorWorkOrderArgs _worWorkOrderArgs;
        private WorWorkOrderPocket _worWorkOrderPocket;
        private WorkOrderHeaderModel _workOrderHeaderModel;
        //private LookUpEditPocket _lep;
        public WorkOrderHeaderEditForm()
        {
            InitializeComponent();
        }
        public WorkOrderHeaderEditForm(WorWorkOrderArgs worWorkOrderArgs, WorWorkOrderPocket worWorkOrderPocket) : this()
        {
            _worWorkOrderArgs = worWorkOrderArgs;
            _worWorkOrderPocket = worWorkOrderPocket;
            InitBoundFieldName<WorkOrderHeaderModel>(strapDataLayout1);
            LookUpEditHelper.SetSysCode(WO_STATUSLookUpEdit, "WO_STATUS");
            strapButtonEdit_ItemMaster1.InitStrap();
            strapButtonEdit_ItemMaster1.SelectedComplate += StrapButtonEdit_ItemMaster1_SelectedComplate;
        }



        private void StrapButtonEdit_ItemMaster1_SelectedComplate(object sender, CommonMes.Controls.ItemMaster.ItemMasterSelectedEventArgs e)
        {

            //_workOrderHeaderModel.ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
            //_workOrderHeaderModel.ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
            //_workOrderHeaderModel.ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;
            //CommonMes.Helpers.LookUpEditHelper.SetRouteNo(ROUTE_NOLookUpEdit, _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
            //    _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd, _workOrderHeaderModel.ITEM_CD);
            //strapButtonEdit_ItemMaster1.DoValidate();
        }

        internal void DataRefresh(object current)
        {
            _workOrderHeaderModel = current as WorkOrderHeaderModel;
            workOrderHeaderModelBindingSource.DataSource = _workOrderHeaderModel;
            workOrderHeaderModelBindingSource.ResetBindings(false);
            strapButtonEdit_ItemMaster1.InitCompCode(_worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd);
            strapButtonEdit_ItemMaster1.InitPlantCode(_worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd);
            //CommonMes.Helpers.LookUpEditHelper.SetRouteNo(ROUTE_NOLookUpEdit, _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
            //    _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd, _workOrderHeaderModel.ITEM_CD);

            LookUpEditHelper.SetByQuery(SHIFT_CDLookUpEdit, "ShiftList", new
            {
                COMP_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
                PLANT_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd
            }, "조코드", "조명");
            LookUpEditHelper.SetWorkCenter(strapLookUpEdit1_Wc_Cd, _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
                _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd);
        }

        private void strapButtonEdit_ItemMaster1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void strapLookUpEdit1_Wc_Cd_EditValueChanged(object sender, EventArgs e)
        {
            CommonMes.Helpers.LookUpEditHelper.SetRouteNo(ROUTE_NOLookUpEdit, _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
                _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd, strapLookUpEdit1_Wc_Cd.EditValue?.ToString(), _workOrderHeaderModel.ITEM_CD);
            ROUTE_NOLookUpEdit.Properties.BestFit();
        }

        private void strapButtonEdit_ItemMaster1_Validated(object sender, EventArgs e)
        {
            ItemMasterPocket itemMasterPocket = new ItemMasterPocket();
            var itemInfo = itemMasterPocket.SelectItemMasterModel(new ItemMasterModelArgs()
            {
                Select_Comp_Cd = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
                Select_Plant_Cd = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd,
                Select_Item_Cd = strapButtonEdit_ItemMaster1.EditValue?.ToString()
            });
            ITEM_NMTextEdit.EditValue = itemInfo?.ITEM_NM.ToString();
            //라우팅 갱신
            CommonMes.Helpers.LookUpEditHelper.SetRouteNo(ROUTE_NOLookUpEdit, _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
                _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd, strapLookUpEdit1_Wc_Cd.EditValue?.ToString(), _workOrderHeaderModel.ITEM_CD);
            ROUTE_NOLookUpEdit.Properties.BestFit();
            //strapButtonEdit_ItemMaster1.DoValidate();
        }
    }
}
