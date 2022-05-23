using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvConfirm2;
using BPack.Pocket.App.SD.DlvConfirm2;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors.Controls;
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
    public partial class DlvResultEditForm : StrapEditForm
    {
        private DlvConfirm2Args _dlvConfirm2Args;
        private DlvConfirm2Pocket _dlvConfirm2Pocket;
        private SimplePocket _sp = SimplePocket.GetInstance();
        private DlvResultModel _selectedDlvResultModel;
        public DlvResultEditForm()
        {
            InitializeComponent();
            InitBoundFieldName<DlvResultModel>(strapDataLayout1);
        }

        public DlvResultEditForm(DlvConfirm2Args dlvConfirm2Args, DlvConfirm2Pocket dlvConfirm2Pocket) : this()
        {
            this._dlvConfirm2Args = dlvConfirm2Args;
            this._dlvConfirm2Pocket = dlvConfirm2Pocket;
            VEHICLE_NOLookUpEdit.Properties.EditValueChanged += DlvResultList_EditValueChanged;
            VEHICLE_NOLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            VEHICLE_NOLookUpEdit.Properties.ProcessNewValue += DlvResultList_ProcessNewValue;
            //DRH_NOTextEdit.ReadOnly = true;
        }

        private void DlvResultList_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            ((List<LookUpEditDefaultModel>)VEHICLE_NOLookUpEdit.Properties.DataSource).Add(new LookUpEditDefaultModel() { CODE = e.DisplayValue.ToString(), NAME = e.DisplayValue.ToString() });
            e.Handled = true;
            //VEHICLE_NOLookUpEdit.Properties.DataSource.Add(new LookUpEditDefaultModel() { CODE = e.DisplayValue.ToString(), NAME = e.DisplayValue.ToString() });
        }

        private void DlvResultList_EditValueChanged(object sender, EventArgs e)
        {
            VEHICLE_NOLookUpEdit.DataBindings[0].WriteValue();
            var driver = _sp.SelectData<Driver>("GetDriver", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, C_CODE = VEHICLE_NOLookUpEdit.EditValue?.ToString() }).SingleOrDefault()?.Value_2;
            DRIVER_NMTextEdit.EditValue = driver;
            DRIVER_NMTextEdit.DataBindings[0].WriteValue();
        }
        public class Driver
        {
            public string Value_2 { get; set; }
        }

        internal void DataRefresh(object dataSource)
        {
            _selectedDlvResultModel = dataSource as DlvResultModel;
            dlvResultModelBindingSource.DataSource = _selectedDlvResultModel;
            LookUpEditHelper.SetByQuery(VEHICLE_NOLookUpEdit, "CarAndDriverList", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "CODE", "NAME", false);
        }
    }
}
