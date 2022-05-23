using BPack.Model.App.PC.WoeRsPivot;
using BPack.Pocket.App.PC.WoeRsPivot;
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

namespace BPack.Carrying.App.PC.WoeRsPivot
{
    public partial class RsBatchList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeRsPivotArgs _woeRsPivotArgs;
        private WoeRsPivotPocket _woeRsPivotPocket;
        public RsBatchList()
        {
            InitializeComponent();
        }
        public RsBatchList(WoeRsPivotArgs woeRsPivotArgs, WoeRsPivotPocket woeRsPivotPocket):this()
        {
            _woeRsPivotArgs = woeRsPivotArgs;
            _woeRsPivotPocket = woeRsPivotPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = rsBatchModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeRsPivotArgs,
                GridView = gridView1,
                InitModelType = typeof(RsBatchModel),
                ModelArgs = _woeRsPivotArgs.WoeRsPivotModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeRsPivotModelArgs, RsBatchModel>(_woeRsPivotPocket.SelectRsBatchModels,null);
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            
        }
    }
}
