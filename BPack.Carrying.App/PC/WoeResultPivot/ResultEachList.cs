using BPack.Model.App.PC.WoeResultPivot;
using BPack.Pocket.App.PC.WoeResultPivot;
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

namespace BPack.Carrying.App.PC.WoeResultPivot
{
    public partial class ResultEachList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultPivotArgs _woeResultPivotArgs;
        private WoeResultPivotPocket _woeResultPivotPocket;

        public ResultEachList()
        {
            InitializeComponent();
        }

        public ResultEachList(WoeResultPivotArgs woeResultPivotArgs, WoeResultPivotPocket woeResultPivotPocket) : this()
        {
            this._woeResultPivotArgs = woeResultPivotArgs;
            this._woeResultPivotPocket = woeResultPivotPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = resultEachModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultPivotArgs,
                GridView = gridView1,
                InitModelType = typeof(ResultEachModel),
                ModelArgs = _woeResultPivotArgs.WoeResultPivotModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeResultPivotModelArgs, ResultEachModel>(_woeResultPivotPocket.SelectResultEachModels, null, null);
        }
    }
}
