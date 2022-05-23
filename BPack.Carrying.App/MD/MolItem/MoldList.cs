using BPack.Model.App.MD.MolItem;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.MolItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.MolItem
{
    public partial class MoldList : StrapSubForm_OnlyOneGrid_V2
    {
        private MolItemArgs _molItemArgs;
        private MolItemPocket _molItemPocket;

        public MoldList(MolItemArgs molItemArgs, MolItemPocket molItemPocket)
        {
            InitializeComponent();

            _molItemArgs = molItemArgs;
            _molItemPocket = molItemPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = moldListModelBindingSource,
                FormArgs = _molItemArgs,
                GridView = gridView1,
                InitModelType = typeof(MoldListModel),
                ModelArgs = _molItemArgs.MolItemModelArgs
            });
            InitPocketDelegate<MolItemModelArgs, MoldListModel>(_molItemPocket.SelectMoldListModels, null);
        }
    }
}
