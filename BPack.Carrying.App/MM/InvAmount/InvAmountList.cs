using BPack.Model.App.MM.InvAmount;
using BPack.Pocket.App.MM.InvAmount;
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

namespace BPack.Carrying.App.MM.InvAmount
{
    public partial class InvAmountList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvAmountArgs _invAmountArgs;
        private InvAmountPocket _invAmountPocket;

        public InvAmountList()
        {
            InitializeComponent();
        }

        public InvAmountList(InvAmountArgs invAmountArgs, InvAmountPocket invAmountPocket) : this()
        {
            this._invAmountArgs = invAmountArgs;
            this._invAmountPocket = invAmountPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _invAmountArgs,
                GridView = gridView1,
                InitModelType = typeof(InvAmountModel),
                ModelArgs = _invAmountArgs.InvAmountModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InvAmountModelArgs, InvAmountModel>(_invAmountPocket.SelectInvAmountModels, null);
        }
    }
}
