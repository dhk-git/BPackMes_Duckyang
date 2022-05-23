using BPack.Model.App.PC.WoeResultPivot;
using BPack.Pocket.App.PC.WoeResultPivot;
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

namespace BPack.Carrying.App.PC.WoeResultPivot
{
    public partial class ResultPivotList : StrapSubForm_Pivot
    {
        private WoeResultPivotArgs _woeResultPivotArgs;
        private WoeResultPivotPocket _woeResultPivotPocket;

        public ResultPivotList()
        {
            InitializeComponent();
        }

        public ResultPivotList(WoeResultPivotArgs woeResultPivotArgs, WoeResultPivotPocket woeResultPivotPocket) : this()
        {
            _woeResultPivotArgs = woeResultPivotArgs;
            _woeResultPivotPocket = woeResultPivotPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitField(new FieldArgs_StrapSubForm_Pivot()
            {
                BindingSource = resultPivotModelBindingSource,
                FormArgs = _woeResultPivotArgs,
                InitModelType = typeof(ResultPivotModel),
                ModelArgs = _woeResultPivotArgs.WoeResultPivotModelArgs,
                PivotGridControl = strapPivotControl1
            });
            InitZipperDelegate<WoeResultPivotModelArgs, ResultPivotModel>(_woeResultPivotPocket.SelectResultPivotModels, null);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            strapPivotControl1.BestFit();
        }
    }
}
