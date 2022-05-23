using BPack.Model.App.PC.WoeResult;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WoeResult;
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

namespace BPack.Carrying.App.PC.WoeResult
{
    public partial class WoeWorkOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultArgs _woeResultArgs;
        private WoeResultPocket _woeResultPocket;

        public WoeWorkOrderList()
        {
            InitializeComponent();
        }

        public WoeWorkOrderList(WoeResultArgs woeResultArgs, WoeResultPocket woeResultPocket) : this()
        {
            _woeResultArgs = woeResultArgs;
            _woeResultPocket = woeResultPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = woeWorkOrderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeWorkOrderModel),
                ModelArgs = _woeResultArgs.WoeResultModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeResultModelArgs, WoeWorkOrderModel>(_woeResultPocket.SelectWoeWorkOrderModels, null);
            LookUpEditHelper.SetGridColumnSysCode(colRST_HU_TYPE, "RST_HU_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colWOD_STATUS, "WOD_STATUS");
        }

    }
}
