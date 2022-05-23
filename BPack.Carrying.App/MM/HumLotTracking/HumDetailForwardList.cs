using BPack.Model.App.MM.HumLotTracking;
using BPack.Pocket.App.MM.HumLotTracking;
using BPack.Strap.FormControls;
using System;

namespace BPack.Carrying.App.MM.HumLotTracking
{
    public partial class HumDetailForwardList : StrapSubForm_TreeList
    {
        private HumLotTrackingArgs _humLotTrackingArgs;
        private HumLotTrackingPocket _humLotTrackingPocket;

        public HumDetailForwardList()
        {
            InitializeComponent();
        }

        public HumDetailForwardList(HumLotTrackingArgs humLotTrackingArgs, HumLotTrackingPocket humLotTrackingPocket) : this()
        {
            this._humLotTrackingArgs = humLotTrackingArgs;
            this._humLotTrackingPocket = humLotTrackingPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            strapTreeList1.IsStrapGridViewDefaultSetting = false;
            InitFields(new FieldArgs_StrapSubForm_TreeList
            {
                BindingSource = null,
                FormArgs = _humLotTrackingArgs,
                TreeList = strapTreeList1,
                InitModelType = typeof(HumDetailForwardModel),
                ModelArgs = _humLotTrackingArgs.HumLotTrackingModelArgs
            });
            strapTreeList1.OptionsBehavior.Editable = false;
            strapTreeList1.OptionsView.AutoWidth = false;
            //컬럼 가운데 정렬
            foreach (DevExpress.XtraTreeList.Columns.TreeListColumn col in _treeList.Columns)
            {
                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG; //엑셀네보내기 셋팅 추가 20181022
            _treeList.OptionsSelection.MultiSelect = true;
            _treeList.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect;
            _treeList.OptionsBehavior.AllowExpandOnDblClick = false;

            strapTreeList1.OptionsView.ShowSummaryFooter = true;
            colUSED_QTY.AllNodesSummary = true;
            colUSED_QTY.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            colUSED_QTY.SummaryFooterStrFormat = "Sum = {0}";
            //colALC_CD.AllNodesSummary = true;
            //colALC_CD.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count;
            //colALC_CD.SummaryFooterStrFormat = "Count = {0}";

        }

        public override void DataRefresh(ArgsBase args)
        {
            //base.DataRefresh(args);
            strapTreeList1.DataSource = _humLotTrackingPocket.SelectHumDetailForwardModels(_humLotTrackingArgs.HumLotTrackingModelArgs);
            strapTreeList1.ExpandAll();
            strapTreeList1.BestFitColumns();
            colHU_BARCODE.Width = 300;
        }
        public override void DataClear(ArgsBase args)
        {
            //base.DataClear(args);
            strapTreeList1.DataSource = null;
        }
        //더블클릭 작동안시킴
        protected override void ModelSelected(object sender, EventArgs e)
        {
            //base.ModelSelected(sender, e);
        }
    }
}
