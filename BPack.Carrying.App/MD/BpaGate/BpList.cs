 using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.BpaGate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.BpaGate
{
    public partial class BpList : StrapSubForm_OnlyOneGrid_V2
    {
        private BpaGateArgs _bpaGateArgs;
        private BpaGatePocket _bpaGatePocket;

        public BpList()
        {
            InitializeComponent();
        }

        public BpList(BpaGateArgs bpaGateArgs, BpaGatePocket bpaGatePocket) : this()
        {
            this._bpaGateArgs = bpaGateArgs;
            this._bpaGatePocket = bpaGatePocket;

            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = bparGrv,
                BindingSource = bparModelBindingSource,
                FormArgs = _bpaGateArgs,
                ModelArgs = _bpaGateArgs.bpaGateModelArgs,
                InitModelType = typeof(Model.App.MD.BpaGate.BparModel)
            });
            InitPocketDelegate<Model.App.MD.BpaGate.BpaGateModelArgs, Model.App.MD.BpaGate.BparModel>(_bpaGatePocket.SelectBparModels, null);
        }
    }
}
