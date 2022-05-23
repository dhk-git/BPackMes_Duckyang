using BPack.CommonMes.Helpers;
using BPack.Pocket.App.SD.CiqDlvClose;
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

namespace BPack.Carrying.App.SD.CiqDlvClose
{
    public partial class CiqDlvCloseMain : StrapMainForm
    {
        private CiqDlvCloseArgs _ciqDlvCloseArgs;
        private CiqDlvClosePocket _ciqDlvClosePocket;
        private DlvResultDetailList _dlvResultDetailList;

        public CiqDlvCloseMain()
        {
            InitializeComponent();
            
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _ciqDlvCloseArgs = new CiqDlvCloseArgs();
            _ciqDlvClosePocket = new CiqDlvClosePocket();
            _dlvResultDetailList = new DlvResultDetailList(_ciqDlvCloseArgs, _ciqDlvClosePocket);
            AddSubForm(this, _dlvResultDetailList, layoutControlGroup2);
            
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _ciqDlvCloseArgs,
                InitlistForm = _dlvResultDetailList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            strapDateEdit1.DateTime = DateTime.Now.Date;
            strapDateEdit2.DateTime = DateTime.Now.Date;
            InitRibbonButtons(true, false, false, false, true, excelImport: true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
            LookUpEditHelper.SetBusinessPartner(strapLookUpEdit2, Common.LoginInfo.UserInfo.CompCode, false, true, true, false, false);
            
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _ciqDlvCloseArgs.CiqDlvCloseModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _ciqDlvCloseArgs.CiqDlvCloseModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _ciqDlvCloseArgs.CiqDlvCloseModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _ciqDlvCloseArgs.CiqDlvCloseModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _ciqDlvCloseArgs.CiqDlvCloseModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit1.EditValue?.ToString();
            _ciqDlvCloseArgs.CiqDlvCloseModelArgs.Select_Main_Bp_Cd = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}
