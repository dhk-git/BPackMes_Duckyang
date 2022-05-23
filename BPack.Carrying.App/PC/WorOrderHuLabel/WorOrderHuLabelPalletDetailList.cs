using BPack.CommonMes.Config;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WorOrderHuLabel;
using BPack.Pocket.App.PC.WorOrderHuLabel;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraRichEdit.Unicode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BPack.Carrying.App.PC.WorOrderHuLabel
{
    public partial class WorOrderHuLabelPalletDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorOrderHuLabelArgs _worOrderHuLabelArgs;
        private WorOrderHuLabelPocket _worOrderHuLabelPocket;

        public WorOrderHuLabelPalletDetailList()
        {
            InitializeComponent();
        }

        public WorOrderHuLabelPalletDetailList(WorOrderHuLabelArgs worOrderHuLabelArgs, WorOrderHuLabelPocket worOrderHuLabelPocket) : this()
        {
            _worOrderHuLabelArgs = worOrderHuLabelArgs;
            _worOrderHuLabelPocket = worOrderHuLabelPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = worOrderHuLabelPalletDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worOrderHuLabelArgs,
                GridView = gridView1,
                InitModelType = typeof(WorOrderHuLabelPalletDetailModel),
                ModelArgs = _worOrderHuLabelArgs.WorOrderHuLabelModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<WorOrderHuLabelModelArgs, WorOrderHuLabelPalletDetailModel>(_worOrderHuLabelPocket.SelectWorOrderHuLabelPalletDetailModels, null, _worOrderHuLabelPocket.SaveWorOrderHuLabelPalletDetailModels);

            colIsCheck.VisibleIndex = 0;
            colIsCheck.Width = 45;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }

        public List<WorOrderHuLabelPalletDetailModel> GetSelectedModels()
        {
            return (List<WorOrderHuLabelPalletDetailModel>)worOrderHuLabelPalletDetailModelBindingSource.DataSource;
        }

    }
}
