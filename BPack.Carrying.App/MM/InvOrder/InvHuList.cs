using BPack.Model.App.MM.InvOrder;
using BPack.Pocket.App.MM.InvOrder;
using BPack.Strap.EditControls;
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

namespace BPack.Carrying.App.MM.InvOrder
{
    public partial class InvHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvOrderArgs _invOrderArgs;
        private InvOrderPocket _invOrderPocket;
        private LookUpEditPocket _lep;
        public InvHuList()
        {
            InitializeComponent();
        }

        public InvHuList(InvOrderArgs invOrderArgs, InvOrderPocket invOrderPocket) : this()
        {
            this._invOrderArgs = invOrderArgs;
            this._invOrderPocket = invOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _lep = LookUpEditPocket.GetInstance();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = invHuModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _invOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(InvHuModel),
                ModelArgs = _invOrderArgs.InvOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InvOrderModelArgs, InvHuModel>(_invOrderPocket.SelectInvHuModels, _invOrderPocket.SaveInvHuModel, null);
        }
    }
}
