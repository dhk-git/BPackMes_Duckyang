using BPack.Model.App.MD.DlvLineCarType;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvLineCarType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvLineCarType
{
    public partial class GateList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvLineCarTypeArgs _dlvLineCarTypeArgs;
        private DlvLineCarTypePocket _dlvLineCarTypePocket;

        public GateList(DlvLineCarTypeArgs dlvLineCarTypeArgs, DlvLineCarTypePocket dlvLineCarTypePocket)
        {
            InitializeComponent();

            _dlvLineCarTypeArgs = dlvLineCarTypeArgs;
            _dlvLineCarTypePocket = dlvLineCarTypePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = dlvLineCarTypeGateModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvLineCarTypeArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvLineCarTypeGateModel),
                ModelArgs = _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs
            });
            InitPocketDelegate<DlvLineCarTypeModelArgs, DlvLineCarTypeGateModel>(_dlvLineCarTypePocket.SelectCarTypeGateModels, null);
        }

    }
}
