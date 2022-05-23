using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Pocket.App.MD.PrdHoliday;
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

namespace BPack.Carrying.App.MD.PrdHoliday
{
    public partial class PrdHolidayMain : StrapMainForm
    {
        private PrdHolidayArgs _prdHolidayArgs;
        private PrdHolidayPocket _prdHolidayPocket;

        private PrdHolidayList _PrdHolidayList;
        public PrdHolidayMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _prdHolidayArgs = new PrdHolidayArgs();
            _prdHolidayPocket = new PrdHolidayPocket();
            _PrdHolidayList = new PrdHolidayList(_prdHolidayArgs, _prdHolidayPocket);

            strapDateEdit1.DateTime = DateTime.Now;
            strapDateEdit3.DateTime = DateTime.Now.AddYears(1);
            
            AddSubForm(this, _PrdHolidayList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdHolidayArgs,
                InitlistForm = _PrdHolidayList,
                StrapLayout = strapLayout1,
                 IsAutoDataRefreshOnShown=true
            });
            
            InitRibbonButtons(refresh: true, add: true, delete: true, save: true,edit:true);
            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();

            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            };

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                _prdHolidayArgs.PrdHolidayModelArgs.Year_CD = strapDateEdit1.Text;
            };

            strapLookUpEdit1.EditValue = _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Comp_Code = UserInfo.CompCode;
            strapLookUpEdit2.EditValue= _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Plant_Code = UserInfo.PlantCode; 


        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _prdHolidayArgs.PrdHolidayModelArgs.Year_CD = strapDateEdit1.Text;

            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            //
            _PrdHolidayList.CopyYearHoliday(strapDateEdit3.Text);
        }
    }
}
