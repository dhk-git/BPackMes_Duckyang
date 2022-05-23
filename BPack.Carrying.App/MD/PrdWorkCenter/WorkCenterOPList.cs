using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.MD.PrdWorkCenter;
using BPack.Pocket.App.MD.PrdWorkCenter;
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

namespace BPack.Carrying.App.MD.PrdWorkCenter
{
    public partial class WorkCenterOPList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdWorkCenterPocket _prdWorkCenterPocket;
        private PrdWorkCenterArgs _prdWorkCenterArgs;


        public WorkCenterOPList(PrdWorkCenterArgs prdWorkCenterArgs, PrdWorkCenterPocket prdWorkCenterPocket)
        {
            InitializeComponent();
            _prdWorkCenterArgs = prdWorkCenterArgs;
            _prdWorkCenterPocket = prdWorkCenterPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();

            this.IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = workCenterOPModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _prdWorkCenterArgs,
                GridView = gridView1,
                InitModelType = typeof(WorkCenterOPModel),
                ModelArgs = _prdWorkCenterArgs.PrdWorkCenterModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdWorkCenterModelArgs, WorkCenterOPModel>(_prdWorkCenterPocket.SelectOPModels, _prdWorkCenterPocket.SaveOPModel, _prdWorkCenterPocket.SaveOPModels);
         
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((WorkCenterOPModel)model).COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD;
            ((WorkCenterOPModel)model).PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD;
            ((WorkCenterOPModel)model).WC_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_WorkCenter_WC_CD;

            ((WorkCenterOPModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((WorkCenterOPModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);

            base.SetInsertDefaultValue(model);
        }
    }
}