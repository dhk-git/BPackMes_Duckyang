using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdCalendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdCalendar
{
    public partial class PrdCalendarMain : StrapMainForm
    {
        PrdCalendarArgs _prdCalendarArgs;
        PrdCalendarPocket _prdCalendarPocket;
        CalendarList _calendarList;

        public PrdCalendarMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _prdCalendarArgs = new PrdCalendarArgs();
            _prdCalendarPocket = new PrdCalendarPocket();
            _calendarList = new CalendarList(_prdCalendarArgs, _prdCalendarPocket);

            AddSubForm(this, _calendarList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdCalendarArgs,
                InitlistForm = _calendarList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(refresh: true, add: true, delete: true, save: true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _calendarList) { SetRibbonButtonsEnable_ByAuth(refresh:true, add: true, delete: true, save: true); }
            };

            strapDateEdit1.DateTime = DateTime.Now;
            strapDateEdit2.DateTime = DateTime.Now.AddDays(30);

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Date_From = strapDateEdit1.DateTime.ToShortDateString();
            _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Date_To = strapDateEdit2.DateTime.ToShortDateString();

            base.Refresh_From_ExecuteByRibbonButton();

            strapButton1.Enabled = true;
        }

   

        private void strapButton1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(strapLookUpEdit2.EditValue?.ToString()))
            {
                StrapMessageBox.Show("A001", 51);
                return;
            }

            _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Date_From = strapDateEdit1.DateTime.ToShortDateString();
            _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Date_To = strapDateEdit2.DateTime.ToShortDateString();

            _calendarList.DataCreate();
        }
    }
}
