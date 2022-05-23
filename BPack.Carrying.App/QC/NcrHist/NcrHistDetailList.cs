using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrHist;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.NcrHist;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BPack.Carrying.App.QC.NcrHist
{
    public partial class NcrHistDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private NcrHistArgs _ncrHistArgs;
        private NcrHistPocket _ncrHistPocket;
        public event EventHandler<ArgsBase> ModelSavedEvent;

        public NcrHistDetailList(NcrHistArgs ncrHistArgs, NcrHistPocket ncrHistPocket)
        {
            InitializeComponent();

            _ncrHistArgs = ncrHistArgs;
            _ncrHistPocket = ncrHistPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = ncrHistDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _ncrHistArgs,
                GridView = gridView1,
                InitModelType = typeof(NcrHistDetailModel),
                ModelArgs = _ncrHistArgs.NcrHistModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<NcrHistModelArgs, NcrHistDetailModel>(_ncrHistPocket.SelectNcrHistDetailModels, null, _ncrHistPocket.SaveNcrHistDetailModels);

            LookUpEditHelper.SetGridColumnSysCode(colNCR_JUDGE, "NCR_JUDGE", true);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }

        private void gridView1_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var grv = sender as GridView;
            var model = grv.GetRow(grv.FocusedRowHandle) as NcrHistDetailModel;
           
            if (_ncrHistArgs.NcrHistModelArgs.Select_Header_NcrStatus != "END" || model.TRT_FG != "N")
            {
                e.Cancel = true;
            }
        }

        public override void Save(ArgsBase args)
        {
            base.Save(args);

            ModelSavedEvent.Invoke(this, args);
        }
    }
}
