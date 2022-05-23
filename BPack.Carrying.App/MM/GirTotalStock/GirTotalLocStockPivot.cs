using BPack.Model.App.MM.GirTotalStock;
using BPack.Pocket.App.MM.GirTotalStock;
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

namespace BPack.Carrying.App.MM.GirTotalStock
{
    public partial class GirTotalLocStockPivot : StrapSubForm_Pivot
    {
        private GirTotalStockArgs _totalGirStockArgs;
        private GirTotalStockPocket _totalGirStockPocket;

        public GirTotalLocStockPivot()
        {
            InitializeComponent();
        }

        public GirTotalLocStockPivot(GirTotalStockArgs totalGirStockArgs, GirTotalStockPocket totalGirStockPocket): this()
        {
            this._totalGirStockArgs = totalGirStockArgs;
            this._totalGirStockPocket = totalGirStockPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitField(new FieldArgs_StrapSubForm_Pivot() 
            {
                BindingSource = locStockModelBindingSource,
                FormArgs = _totalGirStockArgs,
                InitModelType = typeof(LocStockModel),
                ModelArgs = _totalGirStockArgs.GirTotalStockModelArgs,
                PivotGridControl = strapPivotControl1
            });
            InitZipperDelegate<GirTotalStockModelArgs, LocStockModel>(_totalGirStockPocket.SelectTotalLocStockModels, null);
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            strapPivotControl1.BestFit();
        }
    }
}
