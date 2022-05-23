using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.PurInboundHist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.PurInboundHist
{
    public partial class PurInboundHistMain : StrapMainForm
    {
        private PurInboundHistPocket _purInboundHistPocket;
        private PurInboundHistArgs _purInboundHistArgs;
        private PurInboundHistList _purInboundHistList;
        //private PurInboundSumList _purInboundSumList;

        public PurInboundHistMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _purInboundHistArgs = new PurInboundHistArgs();
            _purInboundHistPocket = new PurInboundHistPocket();
            //_purInboundSumList = new PurInboundSumList(_purInboundHistArgs, _purInboundHistPocket);
            _purInboundHistList = new PurInboundHistList(_purInboundHistArgs, _purInboundHistPocket);

            AddSubForm(this, _purInboundHistList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _purInboundHistArgs,
                InitlistForm = _purInboundHistList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);
            strapDateEdit1.EditValue = DateTime.Now.Date;
            strapDateEdit2.EditValue = DateTime.Now.Date;

            //LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, false, true, true);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _purInboundHistArgs.PurInboundHistModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _purInboundHistArgs.PurInboundHistModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            //_purInboundHistArgs.PurInboundHistModelArgs.select_Main_Pih_no = strapTextEdit1.EditValue?.ToString();
            _purInboundHistArgs.PurInboundHistModelArgs.select_Main_Do_no = strapTextEdit1.EditValue?.ToString();
            _purInboundHistArgs.PurInboundHistModelArgs.select_Main_Item_cd = strapTextEdit2.EditValue?.ToString();
            _purInboundHistArgs.PurInboundHistModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}
