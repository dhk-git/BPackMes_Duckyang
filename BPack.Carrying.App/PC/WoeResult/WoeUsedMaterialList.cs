using BPack.Model.App.PC.WoeResult;
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

namespace BPack.Carrying.App.PC.WoeResult
{
    public partial class WoeUsedMaterialList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultArgs _woeResultArgs;
        private WoeResultPocket _woeResultPocket;

        public WoeUsedMaterialList()
        {
            InitializeComponent();
        }

        public WoeUsedMaterialList(WoeResultArgs woeResultArgs, WoeResultPocket woeResultPocket) : this()
        {
            _woeResultArgs = woeResultArgs;
            _woeResultPocket = woeResultPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = woeUsedMaterialModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeUsedMaterialModel),
                ModelArgs = _woeResultArgs.WoeResultModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeResultModelArgs, WoeUsedMaterialModel>(_woeResultPocket.SelectWoeUsedMaterialModels, _woeResultPocket.SaveWoeUsedMaterialModel);
        }


    }
}
