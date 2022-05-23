using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciInspStd;
using BPack.Strap.FormControls;
using BPack.Strap.FormControls.CommonLib;
using BPack.Pocket.App.MD.QciInspStd;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Model.App.MD.QciChkList;
using BPack.CommonMes.Controls.FileManager;
using BPack.CommonMes.Enums;
using BPack.Common.Config;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class CheckList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciInspStdArgs _qciInspStdArgs;
        private QciInspStdPocket _qciInspStdPocket;
        //private CheckListEditForm _checkListEditForm;
        FileManagerRepositoryButtonEdit fileManagerRepositoryButtonEdit;

        public CheckList(QciInspStdArgs qciInspStdArgs, QciInspStdPocket qciInspStdPocket) 
        {
            InitializeComponent();

            _qciInspStdArgs = qciInspStdArgs;
            _qciInspStdPocket = qciInspStdPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                GridView = gridView1,
                BindingSource = inspectionCheckListModelBindingSource,
                FormArgs = _qciInspStdArgs,
                InitModelType = typeof(InspectionCheckListModel),
                ModelArgs = _qciInspStdArgs.QciInspStdModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });

            InitPocketDelegate<QciInspStdModelArgs, InspectionCheckListModel>(_qciInspStdPocket.SelectInspectionCheckListModels, _qciInspStdPocket.SaveInspectionCheckListModel, _qciInspStdPocket.SaveInspectionCheckListModels);

            LookUpEditHelper.SetGridColumnSysCode(colINSP_VAL_TYPE, "INSP_VAL_TYPE");

            fileManagerRepositoryButtonEdit = new FileManagerRepositoryButtonEdit(colFILE_GROUP_ID, gridView1);
            fileManagerRepositoryButtonEdit.InitStrap("QciInspStd", "QciInspStdCheckList", filterString: SysCode.FileNameExtension.Image, fileCountLimit: 1);
            fileManagerRepositoryButtonEdit.SaveComplete += (object sender, FileManagerSaveEventArgs e) =>
            {
                SystemConfig.RefreshServerDateTime();

                var model = inspectionCheckListModelBindingSource.Current as InspectionCheckListModel;
                model.FILE_GROUP_ID = e.SelectedFileGroupId;
                model.MODIFY_DTTM = SystemConfig.ServerDateTime;
                model.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
                model.RowState = RowState.Modified;

                inspectionCheckListModelBindingSource.ResetBindings(false);

                _qciInspStdPocket.SaveInspectionCheckListFileModel(model);

                DataRefresh(_qciInspStdArgs);
            };

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnCommonCode(colINSP_DV, _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, "INSP_DV");
            LookUpEditHelper.SetGridColumnByQuery(colINSP_ID, "InspCheckList", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, PLANT_CD = "", INSP_DV = "" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnCommonCode(colINSP_METHOD, _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, "INSP_METHOD");
            LookUpEditHelper.SetGridColumnCommonCode(colUNIT, _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, "UNIT");
            LookUpEditHelper.SetGridColumnCommonCode(colQC_FG, _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, "FG_YN");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((InspectionCheckListModel)model).INSP_STD_ID = _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Insp_Std_ID;
            ((InspectionCheckListModel)model).REVISION = _qciInspStdArgs.QciInspStdModelArgs.Select_Revision_Revision;

        }

        private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            var grv = sender as GridView;

            switch (e.Column.FieldName)
            {
                case "INSP_ID":
                    var inspDV = grv.GetRowCellValue(e.RowHandle, "INSP_DV");

                    var sp = SimplePocket.GetInstance();
                    var source = sp.SelectData("InspCheckList", new
                    {
                        COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD,
                        PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD,
                        INSP_DV = inspDV
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "검사항목코드", displayCaption: "검사항목명");
                    break;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var curRow = gridView1.GetRow(gridView1.FocusedRowHandle) as InspectionCheckListModel;

            switch (e.Column.FieldName)
            {
                case "INSP_DV":
                    curRow.INSP_ID = "";
                    break;
                case "INSP_ID":
                    var sp = SimplePocket.GetInstance();
                    var row = sp.SelectData("CheckListInfo", new { INSP_ID = e.Value }).Select().FirstOrDefault();
                    if (row != null)
                    {
                        curRow.INSP_DV = row["INSP_DV"].ToString();
                        curRow.INSP_METHOD = row["INSP_METHOD"].ToString();
                        curRow.INSP_VAL_TYPE = row["INSP_VAL_TYPE"].ToString();
                        curRow.UNIT = row["UNIT"].ToString();
                        curRow.INSP_ID = e.Value?.ToString();

                        gridView1.PostEditor();
                        inspectionCheckListModelBindingSource.EndEdit();
                        inspectionCheckListModelBindingSource.ResetBindings(false);
                    }
                    break;

            }
        }
    }
}
