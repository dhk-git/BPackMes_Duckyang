using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Strap.FormControls;
using BPack.Model.App.MD.QciInspStd;
using BPack.CommonMes.Helpers;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class StandardListEditForm : StrapEditForm
    {
        private InspectionStandardModel _inspectionStandardModel;
        private QciInspStdArgs _qciInspStdArgs;

        public StandardListEditForm(QciInspStdArgs qciInspStdArgs)
        {
            InitializeComponent();

            _qciInspStdArgs = qciInspStdArgs;

            InitBoundFieldName<InspectionStandardModel>(dataLayoutControl1);

            LookUpEditHelper.SetSysCode(INSP_TYPELookUpEdit, "INSP_TYPE");

            ITEM_CDButtonEdit.InitStrap();
            ITEM_CDButtonEdit.SelectedComplate += StrapButtonEdit_ItemMaster1_SelectedComplate;
        }

        public void DataRefresh(object datasource)
        {
            _inspectionStandardModel = (InspectionStandardModel)datasource;
            inspectionStandardModelBindingSource.DataSource = _inspectionStandardModel;

            ITEM_CDButtonEdit.InitCompCode(_qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD);
            ITEM_CDButtonEdit.InitPlantCode(_qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD);
        }

        private void StrapButtonEdit_ItemMaster1_SelectedComplate(object sender, CommonMes.Controls.ItemMaster.ItemMasterSelectedEventArgs e)
        {
            _inspectionStandardModel.ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
        }

        private void ITEM_CDButtonEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ITEM_CDButtonEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //var sp = SimplePocket.GetInstance();
            //var row = sp.SelectData("CheckListInfo", new { INSP_ID = e.NewValue }).Select().FirstOrDefault();
            //if (row != null)
            //{
            //    _inspectionStandardModel.ALC_CD = row["ALC_CD"].ToString();
            //}
        }
    }
}
