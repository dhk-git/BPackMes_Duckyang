using BPack.CommonMes.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.SD.DlvConfirm2
{
    public partial class CancelPopup : XtraForm
    {
        public CancelPopup()
        {
            InitializeComponent();
            lueWarehouse.EditValueChanged += LueWarehouse_EditValueChanged;
            lueWarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            LookUpEditHelper.SetWareHouse(lueWarehouse, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode, isFirstSelect:true);
        }

        private void LueWarehouse_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetLocation(lueLoc, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode, lueWarehouse.EditValue.ToString(), isFirstSelect: true);
        }

        //Ok 버튼
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.WH_CD = lueWarehouse.EditValue.ToString();
            this.LOC_CD = lueLoc.EditValue.ToString();
        }
        public string WH_CD { get; set; }
        public string LOC_CD { get; set; }
    }
}
