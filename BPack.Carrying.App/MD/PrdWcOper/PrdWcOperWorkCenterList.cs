using BPack.Common.Model;
using BPack.Model.App.MD.PrdWcOper;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdWcOper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MD.PrdWcOper
{
    public partial class PrdWcOperWorkCenterList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdWcOperPocket _PrdWcOperPocket;
        private PrdWcOperArgs _PrdWcOperArgs;

        public PrdWcOperWorkCenterList()
        {
            InitializeComponent();
        }

        public PrdWcOperWorkCenterList(PrdWcOperArgs PrdWcOperArgs, PrdWcOperPocket PrdWcOperPocket) : this()
        {
            _PrdWcOperArgs = PrdWcOperArgs;
            _PrdWcOperPocket = PrdWcOperPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = prdWcOperWorkCenterModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _PrdWcOperArgs,
                GridView = gridView1,
                InitModelType = typeof(PrdWcOperWorkCenterModel),
                ModelArgs = _PrdWcOperArgs.PrdWcOperModelArgs,
            });
            InitPocketDelegate<PrdWcOperModelArgs, PrdWcOperWorkCenterModel>(_PrdWcOperPocket.SelectPrdWcOperWorkCenterModels, null);

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }

    }
}
