using BPack.Model.App.MM.HumLotTracking;
using BPack.Pocket.App.MM.HumLotTracking;
using BPack.Strap.FormControls;
using System;

namespace BPack.Carrying.App.MM.HumLotTracking
{
    public partial class HumDetailReverseList : StrapSubForm_TreeList
    {
        private HumLotTrackingArgs _humLotTrackingArgs;
        private HumLotTrackingPocket _humLotTrackingPocket;

        public HumDetailReverseList()
        {
            InitializeComponent();
        }

        public HumDetailReverseList(HumLotTrackingArgs humLotTrackingArgs, HumLotTrackingPocket humLotTrackingPocket) : this()
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
                InitModelType = typeof(HumDetailReverseModel),
                ModelArgs = _humLotTrackingArgs.HumLotTrackingModelArgs
            });
            strapTreeList1.OptionsBehavior.Editable = false;
            //컬럼 가운데 정렬
            foreach (DevExpress.XtraTreeList.Columns.TreeListColumn col in _treeList.Columns)
            {
                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG; //엑셀네보내기 셋팅 추가 20181022
            _treeList.OptionsSelection.MultiSelect = true;
            _treeList.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect;
            _treeList.OptionsBehavior.AllowExpandOnDblClick = false;
            //InitPocketDelegate<HumLotTrackingModelArgs, HumDetailReverseModel>(_humLotTrackingPocket.SelectHumDetailReverseModels, null, null);
            
        }
        public override void DataRefresh(ArgsBase args)
        {
            
            //base.DataRefresh(args);
            strapTreeList1.DataSource = _humLotTrackingPocket.SelectHumDetailReverseModels(_humLotTrackingArgs.HumLotTrackingModelArgs);
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
