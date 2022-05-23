using BPack.CommonMes.Helpers;
using BPack.Model.App.CT.PjtAct;
using BPack.Pocket.App.CT.PjtAct;
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

namespace BPack.Carrying.App.CT.PjtAct
{
    public partial class PjtActList : StrapSubForm_OnlyOneGrid_V2
    {
        private PjtActArgs _pjtActArgs;
        private PjtActPocket _pjtActPocket;

        public PjtActList()
        {
            InitializeComponent();
        }

        public PjtActList(PjtActArgs pjtActArgs, PjtActPocket pjtActPocket) : this()
        {
            _pjtActArgs = pjtActArgs;
            _pjtActPocket = pjtActPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = pjtActModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _pjtActArgs,
                GridView = gridView1,
                InitModelType = typeof(PjtActModel),
                ModelArgs = _pjtActArgs.PjtActModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<PjtActModelArgs, PjtActModel>(_pjtActPocket.SelectPjtActModels, null);
            LookUpEditHelper.SetGridColumnSysCode(colPJT_ACT_CLS, "PJT_ACT_CLS");
            
        }
        
    }

}
