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
using BPack.Pocket.App.MD.QciInspStd;
using BPack.CommonMes.Enums;
using BPack.Common.Config;
using BPack.Common.LoginInfo;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class RevisionListEditForm : StrapEditForm
    {
        private InspectionRevisionModel _RevisionListModel;
        private QciInspStdPocket _qciInspStdPocket;
        private QciInspStdArgs _qciInspStdArgs;

        public RevisionListEditForm(QciInspStdArgs qciInspStdArgs, QciInspStdPocket qciInspStdPocket)
        {
            InitializeComponent();

            _qciInspStdArgs = qciInspStdArgs;
            _qciInspStdPocket = qciInspStdPocket;

            InitBoundFieldName<InspectionRevisionModel>(strapDataLayout1);

            fileManagerButtonEdit1.InitStrap("QciInspStd", "QciInspStdRevision", filterString: SysCode.FileNameExtension.Image, fileCountLimit: 1);
            fileManagerButtonEdit1.SaveComplate += (object sender, CommonMes.Controls.FileManager.FileManagerSaveEventArgs e) =>
            {
                SystemConfig.RefreshServerDateTime();
                _RevisionListModel.FILE_GROUP_ID = e.SelectedFileGroupId;
                _RevisionListModel.MODIFY_DTTM = SystemConfig.ServerDateTime;
                _RevisionListModel.MODIFY_USER_ID = UserInfo.UserID;

                inspectionRevisionModelBindingSource.ResetBindings(false);

                _RevisionListModel.RowState = Common.Model.RowState.Modified;
                _qciInspStdPocket.SaveInspectionRevisionModel(_RevisionListModel);

                DataRefresh(inspectionRevisionModelBindingSource.Current);
            };

            LookUpEditHelper.SetSysCode(ALL_FGLookUpEdit, "ALL_FG", total: false);

            ALL_FGLookUpEdit.EditValueChanging += ALL_FGLookUpEdit_EditValueChanged;
        }

        public void DataRefresh(object datasource)
        {
            _RevisionListModel = (InspectionRevisionModel)datasource;
            inspectionRevisionModelBindingSource.DataSource = _RevisionListModel;
            inspectionRevisionModelBindingSource.ResetBindings(false);

            fileManagerButtonEdit1.SetFileGroupID(_RevisionListModel.FILE_GROUP_ID);
        }

        private void ALL_FGLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ALL_FGLookUpEdit.EditValue?.ToString() == "Y")
            {
                _RevisionListModel.SAMPLE_CNT = 0;
                SAMPLE_CNTTextEdit.ReadOnly = true;
            }
            else
            {
                SAMPLE_CNTTextEdit.ReadOnly = false;
            }
            var bindingSource = ALL_FGLookUpEdit.DataBindings;
            if (bindingSource != null && bindingSource.Count > 0) bindingSource[0].WriteValue();
        }
    }
}
