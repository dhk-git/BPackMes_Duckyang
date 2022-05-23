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
using BPack.Strap.EditControls;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.QciChkList
{
    public partial class QciChkListEditForm : StrapEditForm
    {
        private QciChkListArgs _qciChkListArgs;
        private CheckListModel _qciChkListModel;

        public QciChkListEditForm(QciChkListArgs qciChkListArgs)
        {
            InitializeComponent();

            _qciChkListArgs = qciChkListArgs;

            InitBoundFieldName<CheckListModel>(dataLayoutControl1);

        }

        public void DataRefresh(object datasource)
        {
            _qciChkListModel = (CheckListModel)datasource;
            qciChkListModelBindingSource.DataSource = _qciChkListModel;

            LookUpEditHelper.SetCommonCode(INSP_DVLookUpEdit, _qciChkListModel.COMP_CD, "INSP_DV", total: false);
            LookUpEditHelper.SetCommonCode(INSP_METHODLookUpEdit, _qciChkListModel.COMP_CD, "INSP_METHOD", total: false);

            INSP_VAL_TYPELookUpEdit.Properties.Columns.Clear();
            LookUpEditHelper.SetSysCode(INSP_VAL_TYPELookUpEdit, "INSP_VAL_TYPE", total: false);
            LookUpEditHelper.SetCommonCode(UNITLookUpEdit, _qciChkListModel.COMP_CD, "UNIT", total: false);
        }

        private void INSP_VAL_TYPELookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (INSP_VAL_TYPELookUpEdit.EditValue?.ToString() == "OX" || INSP_VAL_TYPELookUpEdit.EditValue?.ToString() == "C")
            {
                UNITLookUpEdit.EditValue = null;
                UNITLookUpEdit.ReadOnly = true;
            }
            else
            {
                UNITLookUpEdit.ReadOnly = false;
            }
        }
    }
}
