using BPack.Common.Model;
using BPack.Model.App.MD.PrdShiftOper;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdShiftOper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdShiftOper
{
    public partial class OperList : StrapSubForm_OnlyOneGrid_V2
    {
        PrdShiftOperArgs _prdShiftOperArgs;
        PrdShiftOperPocket _prdShiftOperPocket;

        public OperList(PrdShiftOperArgs prdShiftOperArgs, PrdShiftOperPocket prdShiftOperPocket)
        {
            InitializeComponent();

            _prdShiftOperArgs = prdShiftOperArgs;
            _prdShiftOperPocket = prdShiftOperPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = shiftOperModelBindingSource,
                FormArgs = _prdShiftOperArgs,
                GridView = gridView1,
                InitModelType = typeof(ShiftOperModel),
                ModelArgs = _prdShiftOperArgs.PrdShiftOperModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdShiftOperModelArgs, ShiftOperModel>(_prdShiftOperPocket.SelectShiftOperModels, _prdShiftOperPocket.SaveShiftOperModel, _prdShiftOperPocket.SaveShiftOperModels);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ShiftOperModel)model).COMP_CD = _prdShiftOperArgs.PrdShiftOperModelArgs.Select_Main_Comp_Code;
            ((ShiftOperModel)model).PLANT_CD = _prdShiftOperArgs.PrdShiftOperModelArgs.Select_Main_Plant_Code;
            ((ShiftOperModel)model).SHIFT_CD= _prdShiftOperArgs.PrdShiftOperModelArgs.Select_Shift_Code;

            base.SetInsertDefaultValue(model);
        }
    }
}
