using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciInspStd;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.QciInspStd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class RevisionList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciInspStdArgs _qciInspStdArgs;
        private QciInspStdPocket _qciInspStdPocket;
        private RevisionListEditForm _revisionListEditForm;

        public RevisionList(QciInspStdArgs qciInspStdArgs, QciInspStdPocket qciInspStdPocket)
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
                BindingSource = inspectionRevisionModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qciInspStdArgs,
                GridView = gridView1,
                InitModelType = typeof(InspectionRevisionModel),
                ModelArgs = _qciInspStdArgs.QciInspStdModelArgs
            });
            InitPocketDelegate<QciInspStdModelArgs, InspectionRevisionModel>(_qciInspStdPocket.SelectInspectionRevisionModels, _qciInspStdPocket.SaveInspectionRevisionModel);

            LookUpEditHelper.SetGridColumnSysCode(colALL_FG, "ALL_FG");

            _revisionListEditForm = new RevisionListEditForm(_qciInspStdArgs, _qciInspStdPocket);
            gridView1.OptionsEditForm.CustomEditFormLayout = _revisionListEditForm;
            gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            {
                _revisionListEditForm.DataRefresh(inspectionRevisionModelBindingSource.Current);
            };
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((InspectionRevisionModel)model).COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD;
            ((InspectionRevisionModel)model).PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD;
            ((InspectionRevisionModel)model).INSP_TYPE = _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Insp_type;
            ((InspectionRevisionModel)model).ITEM_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Item_CD;
            ((InspectionRevisionModel)model).INSP_STD_ID = _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Insp_Std_ID;
            var source = inspectionRevisionModelBindingSource.DataSource as List<BPack.Model.App.MD.QciInspStd.InspectionRevisionModel>;
            var max_rev = source.Select(a => a.REVISION).Max();
            ((InspectionRevisionModel)model).REVISION = max_rev + 1;
            ((InspectionRevisionModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((InspectionRevisionModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);
        }

        public InspectionRevisionModel GetSelectedUserModel()
        {
            return (InspectionRevisionModel)strapGridControl1.SelectedModel;
        }
    }
}
