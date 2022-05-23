using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdShift;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdShift;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MD.PrdShift
{
    public partial class ShiftDetailGrouptList : StrapSubForm_OnlyOneGrid_V2
    {
        PrdShiftArgs _prdShiftArgs;
        PrdShiftPocket _prdShiftPocket;

        public ShiftDetailGrouptList(PrdShiftArgs prdShiftArgs, PrdShiftPocket prdShiftPocket)
        {
            InitializeComponent();

            _prdShiftArgs = prdShiftArgs;
            _prdShiftPocket = prdShiftPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = shiftDetailGroupModelBindingSource,
                FormArgs = _prdShiftArgs,
                GridView = gridView1,
                InitModelType = typeof(ShiftDetailGroupModel),
                ModelArgs = _prdShiftArgs.PrdShiftModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdShiftModelArgs, ShiftDetailGroupModel>
                (_prdShiftPocket.SelectShiftDetailGroupModel, _prdShiftPocket.SaveShiftDetailGroupModel, _prdShiftPocket.SaveShiftDetailGroupModels);
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ShiftDetailGroupModel)model).COMP_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code;
            ((ShiftDetailGroupModel)model).PLANT_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code;
            ((ShiftDetailGroupModel)model).SHIFT_GROUP_CD = _prdShiftArgs.PrdShiftModelArgs.SHIFT_GROUP_CD;
            base.SetInsertDefaultValue(model);
        }
    }
}
