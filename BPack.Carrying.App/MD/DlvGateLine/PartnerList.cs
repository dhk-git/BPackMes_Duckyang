using BPack.Common.Model;
using BPack.Model.App.MD.DlvGateLine;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvGateLine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvGateLine
{
    public partial class PartnerList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvGateLineArgs _dlvGateLineArgs;
        private DlvGateLinePocket _dlvGateLinePocket;

        public PartnerList(DlvGateLineArgs dlvGateLineArgs, DlvGateLinePocket dlvGateLinePocket)
        {
            InitializeComponent();

            _dlvGateLineArgs = dlvGateLineArgs;
            _dlvGateLinePocket = dlvGateLinePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = partnerModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvGateLineArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvGateLinePartnerModel),
                ModelArgs = _dlvGateLineArgs.DlvGateLineModelArgs
            });
            InitPocketDelegate<DlvGateLineModelArgs, DlvGateLinePartnerModel>(_dlvGateLinePocket.SelectPartnerModels, null);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
    }
}
