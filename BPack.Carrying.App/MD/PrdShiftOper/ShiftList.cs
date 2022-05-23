using BPack.CommonMes.Helpers;
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
    public partial class ShiftList : StrapSubForm_OnlyOneGrid_V2
    {
        PrdShiftOperArgs _prdShiftOperArgs;
        PrdShiftOperPocket _prdShiftOperPocket;

        public ShiftList(PrdShiftOperArgs prdShiftOperArgs, PrdShiftOperPocket prdShiftOperPocket)
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
                BindingSource = shiftModelBindingSource,
                FormArgs = _prdShiftOperArgs,
                GridView = gridView1,
                InitModelType = typeof(ShiftModel),
                ModelArgs = _prdShiftOperArgs.PrdShiftOperModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdShiftOperModelArgs, ShiftModel>(_prdShiftOperPocket.SelectShiftModels, null, null);

            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colSTART_TM);
            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colEND_TM);
        }


    }
}
