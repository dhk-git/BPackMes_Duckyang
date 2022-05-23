using BPack.Model.App.MM.GirClose;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirClose;
using BPack.CommonMes.Helpers;
using System;

namespace BPack.Carrying.App.MM.GirClose
{
    public partial class CloseDateList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirCloseArgs _girCloseArgs;
        private GirClosePocket _girClosePocket;

        public CloseDateList()
        {
            InitializeComponent();
        }

        public CloseDateList(GirCloseArgs girCloseArgs, GirClosePocket girClosePocket) : this()
        {
            _girCloseArgs = girCloseArgs;
            _girClosePocket = girClosePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = closeDateModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girCloseArgs,
                GridView = gridView1,
                InitModelType = typeof(CloseDateModel),
                ModelArgs = _girCloseArgs.GirCloseModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirCloseModelArgs, CloseDateModel>(_girClosePocket.SelectCloseDateModels, null);
            LookUpEditHelper.SetGridColumnSysCode(colGIR_CLOSE_STATUS, "GIR_CLOSE_STATUS");
      

        }

        public CloseDateModel GetSelectedModel()
        {
            return strapGridControl1.SelectedModel as CloseDateModel;
        }

        
        internal void RowRefresh()
        {
            gridView1.UpdateCurrentRow();
        }

        //internal void CloseCancelGir()
        //{
        //    var selectedModel = strapGridControl1.SelectedModel as CloseDateModel;
        //    _girClosePocket.BpCloseGirCancel(selectedModel);
        //}
    }
}
