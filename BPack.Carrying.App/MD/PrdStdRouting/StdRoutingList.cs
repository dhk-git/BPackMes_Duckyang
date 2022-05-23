using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdStdRouting;
using BPack.Pocket.App.MD.PrdStdRouting;
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

namespace BPack.Carrying.App.MD.PrdStdRouting
{
    public partial class StdRoutingList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdStdRoutingArgs _prdStdRoutingArgs;
        private PrdStdRoutingPocket _prdStdRoutingPocket;

        public StdRoutingList()
        {
            InitializeComponent();
        }

        public StdRoutingList(PrdStdRoutingArgs prdStdRoutingArgs, PrdStdRoutingPocket prdStdRoutingPocket) : this()
        {
            this._prdStdRoutingArgs = prdStdRoutingArgs;
            this._prdStdRoutingPocket = prdStdRoutingPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = stdRoutingModelBindingSource,
                FormArgs = _prdStdRoutingArgs,
                GridView = gridView1,
                InitModelType = typeof(StdRoutingModel),
                ModelArgs = _prdStdRoutingArgs.PrdStdRoutingModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdStdRoutingModelArgs, StdRoutingModel>(_prdStdRoutingPocket.SelectStdRoutingModels, null, _prdStdRoutingPocket.SaveStdRoutingModels);
            LookUpEditHelper.SetGridColumnSysCode(colPROC_GR_CD, "PROC_GR_CD");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((StdRoutingModel)model).COMP_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd;
            ((StdRoutingModel)model).PLANT_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd;
            ((StdRoutingModel)model).APPLY_DT = DateTime.Now.Date;
            base.SetInsertDefaultValue(model);
        }

    }
}
