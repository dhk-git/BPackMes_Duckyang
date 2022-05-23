using BPack.Model.App.MD.WcWorkTime;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.WcWorkTime;

namespace BPack.Carrying.App.MD.WcWorkTime
{
    public partial class WcWorkTimeWorkCenterList : StrapSubForm_OnlyOneGrid_V2
    {
        private WcWorkTimeArgs _wcWorkTimeArgs;
        private WcWorkTimePocket _wcWorkTimePocket;

        public WcWorkTimeWorkCenterList()
        {
            InitializeComponent();
        }

        public WcWorkTimeWorkCenterList(WcWorkTimeArgs wcWorkTimeArgs, WcWorkTimePocket wcWorkTimePocket) : this()
        {
            _wcWorkTimeArgs = wcWorkTimeArgs;
            _wcWorkTimePocket = wcWorkTimePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            
            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = wcWorkTimeWorkCenterModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _wcWorkTimeArgs,
                GridView = gridView1,
                InitModelType = typeof(WcWorkTimeWorkCenterModel),
                ModelArgs = _wcWorkTimeArgs.WcWorkTimeModelArgs
            });
            InitPocketDelegate<WcWorkTimeModelArgs, WcWorkTimeWorkCenterModel>(_wcWorkTimePocket.SelectWcWorkTimeWorkCenterModels, null);
        }
    }
}
