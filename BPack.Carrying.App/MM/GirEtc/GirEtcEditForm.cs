using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirEtc;
using BPack.Pocket.App.MM.GirEtc;
using BPack.Strap.FormControls;
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

namespace BPack.Carrying.App.MM.GirEtc
{
    public partial class GirEtcEditForm : StrapEditForm
    {
        private GirEtcModel _currentGirEtcModel;
        private GirEtcArgs _girEtcArgs;

        public GirEtcEditForm()
        {
            InitializeComponent();
            InitBoundFieldName<GirEtcModel>(strapDataLayout1);

            LookUpEditHelper.SetSysCode(INOUT_CLSLookUpEdit, "INOUT_CLS");
            LookUpEditHelper.SetSysCode(ETC_GIR_STATUSLookUpEdit, "ETC_GIR_STATUS");
            LookUpEditHelper.SetWareHouse(WH_CDLookUpEdit, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode, isFirstSelect: true);
            INOUT_CLSLookUpEdit.EditValueChanged += INOUT_CLSLookUpEdit_EditValueChanged;
        }

        private void INOUT_CLSLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            SetEditorValue(INOUT_CLSLookUpEdit, INOUT_CLSLookUpEdit.EditValue);
            LookUpEditHelper.SetByQuery(GIR_TYPE_CDLookUpEdit, "GirType_A002", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode,  INOUT_CLS = _currentGirEtcModel.INOUT_CLS
            }, "CODE", "NAME");
            //LookUpEditHelper.SetSysCode(ETC_GIR_TYPELookUpEdit, "ETC_GIR_TYPE");
            LookUpEditHelper.SetByQuery(ETC_GIR_TYPELookUpEdit, "ETC_GIR_TYPE_VALUE", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, VALUE_1 = _currentGirEtcModel.INOUT_CLS }, "CODE", "NAME", false, false);

        }

        public GirEtcEditForm(GirEtcArgs girEtcArgs) : this()
        {
            this._girEtcArgs = girEtcArgs;
        }

        internal void DataRefresh(object dataSource)
        {
            _currentGirEtcModel = dataSource as GirEtcModel;
            girEtcModelBindingSource.DataSource = _currentGirEtcModel;
        }

        private void SetEditorValue(BaseEdit editor, object value)
        {
            if (Visible)
            {
                editor.EditValue = value;
                foreach (Binding i in editor.DataBindings)
                {
                    i.WriteValue();
                }
            }
        }
    }
}
