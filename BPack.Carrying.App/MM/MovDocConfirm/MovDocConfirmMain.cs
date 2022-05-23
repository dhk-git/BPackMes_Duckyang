using BPack.Common.Pocket;
using BPack.Model.App.MM.MovDocConfirm;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.MovDocConfirm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.MovDocConfirm
{
    public partial class MovDocConfirmMain : StrapMainForm
    {
        private MovDocConfirmArgs _movDocConfirmArgs;
        private MovDocConfirmPocket _movDocConfirmPocket;
        private MovDocList _movDocList;
        private MovDocReport _movDocReport;
        public MovDocConfirmMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _movDocConfirmArgs = new MovDocConfirmArgs();
            _movDocConfirmPocket = new MovDocConfirmPocket();
            _movDocList = new MovDocList(_movDocConfirmArgs, _movDocConfirmPocket);
            _movDocReport = new MovDocReport(_movDocConfirmArgs, _movDocConfirmPocket);
            AddSubForm(this, _movDocList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _movDocConfirmArgs,
                InitlistForm = _movDocList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            strapDateEdit1.EditValue = DateTime.Now.Date.AddDays(-30);
            _movDocList.ModelSelectedEvent += MovDocList_ModelSelectedEvent;
        }

        private void MovDocList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _movDocConfirmArgs.MovDocConfirmModelArgs.Select_Mov_No = ((MovDocModel)e.SelectedModelArgsBase.SelectedModelBase).MOV_NO;
            documentViewer1.DocumentSource = _movDocReport;
            _movDocReport.DataRefresh(_movDocConfirmArgs);
            _movDocReport.CreateDocument();
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _movDocConfirmArgs.MovDocConfirmModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _movDocConfirmArgs.MovDocConfirmModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _movDocConfirmArgs.MovDocConfirmModelArgs.Select_Main_Mov_No = strapTextEdit1.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }
  

        //이동전표확인처리 버튼
        private void strapButton1_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 17, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _movDocList.MovDocConfirm();
            };
        }
    }
}
