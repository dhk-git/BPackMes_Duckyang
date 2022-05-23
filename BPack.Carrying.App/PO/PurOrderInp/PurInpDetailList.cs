using BPack.Model.App.PO.PurOrderInp;
using BPack.Pocket.App.PO.PurOrderInp;
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

namespace BPack.Carrying.App.PO.PurOrderInp
{
    public partial class PurInpDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurOrderInpArgs _purOrderInpArgs;
        private PurOrderInpPocket _purOrderInpPocket;

        public PurInpDetailList()
        {
            InitializeComponent();
        }

        public PurInpDetailList(PurOrderInpArgs purOrderInpArgs, PurOrderInpPocket purOrderInpPocket) : this()
        {
            this._purOrderInpArgs = purOrderInpArgs;
            this._purOrderInpPocket = purOrderInpPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _purOrderInpArgs,
                GridView = gridView1,
                InitModelType = typeof(PurInpDetailModel),
                ModelArgs = _purOrderInpArgs.PurOrderInpModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<PurOrderInpModelArgs, PurInpDetailModel>(_purOrderInpPocket.SelectPurInpDetailModels, null);
        }
    }
}
