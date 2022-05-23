using BPack.Model.App.PC.WoeEssLot;
using BPack.Pocket.App.PC.WoeEssLot;
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

namespace BPack.Carrying.App.PC.WoeEssLot
{
    public partial class EssLotList : StrapSubForm_TreeList
    {
        private WoeEssLotArgs _LotArgs;
        private WoeEssLotPocket _LotPocket;

        public EssLotList()
        {
            InitializeComponent();
        }

        public EssLotList(WoeEssLotArgs woeEssLotArgs, WoeEssLotPocket woeEssLotPocket):this()
        {
            this._LotArgs = woeEssLotArgs;
            this._LotPocket = woeEssLotPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_TreeList
            {
                BindingSource = woeEssTreeModelBindingSource,
                FormArgs = _LotArgs,
                ModelArgs = _LotArgs.WoeEssLotModelArgs,
                TreeList = strapTreeList1,
                InitModelType = typeof(WoeEssTreeModel)

            });
            InitPocketDelegate<WoeEssLotModelArgs, WoeEssTreeModel>(_LotPocket.SelectWoeEssTreeModels, null);
            strapTreeList1.OptionsView.AutoWidth = false;
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            strapTreeList1.CollapseAll();
            //strapTreeList1.BestFitColumns();
        }
        public override void DataClear(ArgsBase args)
        {
            base.DataClear(args);
        }
    }
}
