using BPack.Common.Pocket;
using BPack.Pocket.App.CT.PjtAct;
using BPack.Strap.FormControls;
//using BPack.Pocket.App.CT.PjtAct;
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
    public partial class PjtActMain : StrapMainForm
    {
        private PjtActArgs _pjtActArgs;
        private PjtActPocket _pjtActPocket;
        private PjtActList _pjtActList;

        public PjtActMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _pjtActArgs = new PjtActArgs();
            _pjtActPocket = new PjtActPocket();
            _pjtActList = new PjtActList(_pjtActArgs, _pjtActPocket);
            AddSubForm(this, _pjtActList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm() {
                FormArgs = _pjtActArgs,
                InitlistForm = _pjtActList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _pjtActArgs.PjtActModelArgs.Select_Start_Dt = strapDateEdit1.DateTime;
            _pjtActArgs.PjtActModelArgs.Select_End_Dt = strapDateEdit2.DateTime;
            base.Refresh_From_ExecuteByRibbonButton();
        }

        //public override void InitPocket(PocketBase Pocket)
        //{
        //    _pjtActPocket = Pocket as PjtActPocket;
        //}

    }
}
