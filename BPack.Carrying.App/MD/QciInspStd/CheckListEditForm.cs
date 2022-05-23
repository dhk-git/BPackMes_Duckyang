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
using BPack.Model.App.MD.QciChkList;
using BPack.Model.App.MD.QciInspStd;
using DevExpress.XtraDataLayout;
using BPack.CommonMes.Helpers;
using BPack.Common.Pocket;
using DevExpress.XtraGrid.Views.Grid;
using BPack.Strap.FormControls.CommonLib;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class CheckListEditForm : StrapEditForm
    {
        private InspectionCheckListModel _checkListModel;
        private QciInspStdArgs _qciInspStdArgs;

        public CheckListEditForm(QciInspStdArgs qciInspStdArgs)
        {
            InitializeComponent();

            _qciInspStdArgs = qciInspStdArgs;

            InitBoundFieldName<InspectionCheckListModel>(strapDataLayout1);
        }

        public void DataRefresh(object datasource)
        {
            _checkListModel = (InspectionCheckListModel)datasource;
            inspectionCheckListModelBindingSource.DataSource = _checkListModel;

            LookUpEditHelper.SetCommonCode(INSP_DVLookUpEdit, _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, "INSP_DV", total: false);

            LookUpEditHelper.SetCommonCode(INSP_METHODLookUpEdit, _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, "INSP_METHOD", total: false);
            LookUpEditHelper.SetSysCode(INSP_VAL_TYPELookUpEdit, "INSP_VAL_TYPE", total: false);
            LookUpEditHelper.SetCommonCode(UNITLookUpEdit, _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, "UNIT", total: false);
            INSP_IDLookUpEdit.EditValueChanging += INSP_IDLookUpEdit_EditValueChanging;

        }

        private void INSP_IDLookUpEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var sp = SimplePocket.GetInstance();
            var row = sp.SelectData("CheckListInfo", new { INSP_ID = e.NewValue }).Select().FirstOrDefault();
            if (row != null)
            {
                _checkListModel.INSP_METHOD = row["INSP_METHOD"].ToString();
                _checkListModel.INSP_VAL_TYPE = row["INSP_VAL_TYPE"].ToString();
                _checkListModel.UNIT = row["UNIT"].ToString();
            }

        }

        private void INSP_DVLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetByQuery(INSP_IDLookUpEdit, "InspCheckList", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD
                , INSP_DV = INSP_DVLookUpEdit.EditValue.ToString() }, "CODE", "NAME");
        }
    }
}
