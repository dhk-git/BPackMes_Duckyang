using BPack.Model.App.MD.DlvJisInfo;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvJisInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvJisInfo
{
    public partial class GateList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvJisInfoArgs _dlvJisInfoArgs;
        private DlvJisInfoPocket _dlvJisInfoPocket;

        public GateList(DlvJisInfoArgs dlvJisInfoArgs, DlvJisInfoPocket dlvJisInfoPocket)
        {
            InitializeComponent();

            _dlvJisInfoArgs = dlvJisInfoArgs;
            _dlvJisInfoPocket = dlvJisInfoPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = dlvJisInfoGateModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvJisInfoArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvJisInfoGateModel),
                ModelArgs = _dlvJisInfoArgs.DlvJisInfoModelArgs
            });
            InitPocketDelegate<DlvJisInfoModelArgs, DlvJisInfoGateModel>(_dlvJisInfoPocket.SelectJISGateModels, null);
        }

    }
}
