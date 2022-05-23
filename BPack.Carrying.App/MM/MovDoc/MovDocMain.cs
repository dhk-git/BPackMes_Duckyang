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
using BPack.Model.App.MM.MovDoc;
using BPack.Pocket.App.MM.MovDoc;
using BPack.Strap.EditControls;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MM.MovDoc
{
    public partial class MovDocMain : StrapMainForm
    {
        private MovDocArgs _movDocArgs;
        private MovDocPocket _movDocPocket;
        private MovDocList _movDocList;
        private MovItemList _movItemList;
        private MovHuList _movHuList;

        public MovDocMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _movDocArgs = new MovDocArgs();
            _movDocPocket = new MovDocPocket();
            _movDocList = new MovDocList(_movDocArgs, _movDocPocket);
            _movItemList = new MovItemList(_movDocArgs, _movDocPocket);
            _movHuList = new MovHuList(_movDocArgs, _movDocPocket);

            AddSubForm(this, _movDocList, layoutControlGroup2);
            AddSubForm(this, _movItemList, layoutControlGroup3);
            AddSubForm(this, _movHuList, layoutControlGroup4);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _movDocArgs,
                InitlistForm = _movDocList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(refresh: true, add: true, edit: true, delete: true);
            strapDateEdit1.EditValue = DateTime.Now.Date.AddDays(-30);
            strapDateEdit2.EditValue = DateTime.Now.Date;
            CommonMes.Helpers.LookUpEditHelper.SetPlantCode(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, isFirstSelect: true, isTotalRow: false);
            _movDocList.ModelSelectedEvent += MovDocList_ModelSelectedEvent;
            _movItemList.ModelSelectedEvent += MovItemList_ModelSelectedEvent;
            this.SelectedSubFormChanged += MovDocMain_SelectedSubFormChanged;

        }

        private void MovDocMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _movDocList)
            {
                SetRibbonButtonsEnable_ByAuth(edit: true, save: false);
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(edit: false, save: true);
            }
        }

        private void MovItemList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _movDocArgs.MovDocModelArgs.Select_Mod_No = ((MovItemModel)e.SelectedModelArgsBase.SelectedModelBase).MOD_NO;
            _movHuList.DataRefresh(_movDocArgs);
        }

        private void MovDocList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _movDocArgs.MovDocModelArgs.Select_Mov_No = ((MovDocModel)e.SelectedModelArgsBase.SelectedModelBase).MOV_NO;
            _movDocArgs.MovDocModelArgs.Select_Plant_Cd = ((MovDocModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
            _movDocArgs.MovDocModelArgs.Select_Mod_No = null;
            _movItemList.DataRefresh(_movDocArgs);
            _movHuList.DataRefresh(_movDocArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _movDocArgs.MovDocModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _movDocArgs.MovDocModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _movDocArgs.MovDocModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _movDocArgs.MovDocModelArgs.Select_Mov_No = strapTextEdit1.EditValue?.ToString();
            _movDocArgs.Select_Extra_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }

  
        //전표발행버튼
        private void strapButton1_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("선택한 전표를 발행합니다.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _movDocList.Publish();
            };
        }
    }
}
