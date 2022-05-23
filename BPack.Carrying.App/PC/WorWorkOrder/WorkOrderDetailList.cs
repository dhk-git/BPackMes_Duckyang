using BPack.Model.App.PC.WorWorkOrder;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WorWorkOrder;
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

namespace BPack.Carrying.App.PC.WorWorkOrder
{
    public partial class WorkOrderDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorWorkOrderArgs _worWorkOrderArgs;
        private WorWorkOrderPocket _worWorkOrderPocket;

        public WorkOrderDetailList()
        {
            InitializeComponent();
        }

        public WorkOrderDetailList(WorWorkOrderArgs worWorkOrderArgs, WorWorkOrderPocket worWorkOrderPocket) : this()
        {
            _worWorkOrderArgs = worWorkOrderArgs;
            _worWorkOrderPocket = worWorkOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = workOrderDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worWorkOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(WorkOrderDetailModel),
                ModelArgs = _worWorkOrderArgs.WorWorkOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WorWorkOrderModelArgs, WorkOrderDetailModel>(_worWorkOrderPocket.SelectWorkOrderDetailModels, _worWorkOrderPocket.SaveWorkOrderDetailModel, _worWorkOrderPocket.SaveWorkOrderDetailModels);
            LookUpEditHelper.SetGridColumnSysCode(colWOD_STATUS, "WOD_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colRST_HU_TYPE, "RST_HU_TYPE");
        }
        public void DataRefresh_LookupEdit()
        {
            CommonMes.Helpers.LookUpEditHelper.SetWorkCenter(colWC_CD, _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd
                , _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd);

            //LookUpEditHelper.SetGridColumnByQuery(colMAT_WH_CD, "ItmItem.WareHouse", new
            //{
            //    COMP_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
            //    PLANT_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd,
            //    WH_GR = "PROD"
            //}, "창고코드", "창고명");
            //LookUpEditHelper.SetGridColumnByQuery(colGD_WH_CD, "ItmItem.WareHouse", new
            //{
            //    COMP_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
            //    PLANT_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd,
            //    WH_GR = "PROD"
            //}, "창고코드", "창고명");
        }

    }
}
