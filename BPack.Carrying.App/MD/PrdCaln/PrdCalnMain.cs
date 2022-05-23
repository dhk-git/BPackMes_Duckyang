using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Pocket.App.MD.PrdCaln;
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

namespace BPack.Carrying.App.MD.PrdCaln
{
    public partial class PrdCalnMain : StrapMainForm
    {
        private PrdCalnArgs _prdCalnArgs;
        private PrdCalnPocket _prdCalnPocket;
        private PrdCalnList _prdCalnList;

        public PrdCalnMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _prdCalnArgs = new PrdCalnArgs();
            _prdCalnPocket = new PrdCalnPocket();
            _prdCalnList = new PrdCalnList(_prdCalnArgs, _prdCalnPocket);
            strapDateEdit1.DateTime = DateTime.Now;
            //strapDateEdit2.DateTime = DateTime.Now;
            AddSubForm(this, _prdCalnList, layoutControlGroup2);


            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdCalnArgs,
                InitlistForm = _prdCalnList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(refresh: true, add: false, delete: false, save: true, edit: true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                _prdCalnArgs.PrdCalnModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _prdCalnArgs.PrdCalnModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            };

            //작업장
            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetByQuery(strapLookUpEdit3, "CoreSettingsWorkCenterList", new { COMP_CD = strapLookUpEdit1.EditValue?.ToString(), PLANT_CD = strapLookUpEdit2.EditValue?.ToString() }, "작업장코드", "작업장명", isTotalRow: true, isFirstSelect: true);
            };

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                _prdCalnArgs.PrdCalnModelArgs.Year_CD = strapDateEdit1.Text;
            };
            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _prdCalnArgs.PrdCalnModelArgs.Month_CD = strapDateEdit1.Text;
            };

            strapLookUpEdit1.EditValue = UserInfo.CompCode;
            strapLookUpEdit2.EditValue = UserInfo.PlantCode;

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdCalnArgs.PrdCalnModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdCalnArgs.PrdCalnModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _prdCalnArgs.PrdCalnModelArgs.Year_CD = strapDateEdit1.DateTime.Year.ToString();
            _prdCalnArgs.PrdCalnModelArgs.Month_CD = strapDateEdit1.DateTime.Month.ToString().PadLeft(2,'0');
            _prdCalnArgs.PrdCalnModelArgs.Select_Main_Wc_Code= strapLookUpEdit3.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            _prdCalnList.CreateCalendaer(strapDateEdit1.DateTime.Year.ToString(), strapDateEdit1.DateTime.Month.ToString().PadLeft(2, '0'));
            _prdCalnList.DataRefresh(args: _prdCalnArgs);

        }
    }
}
