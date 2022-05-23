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
    public partial class WorOrderHuLabelPalletHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorOrderHuLabelArgs _worOrderHuLabelArgs;
        private WorOrderHuLabelPocket _worOrderHuLabelPocket;

        public WorOrderHuLabelPalletHeaderList()
        {
            InitializeComponent();
        }

        public WorOrderHuLabelPalletHeaderList(WorOrderHuLabelArgs worOrderHuLabelArgs, WorOrderHuLabelPocket worOrderHuLabelPocket) : this()
        {
            _worOrderHuLabelArgs = worOrderHuLabelArgs;
            _worOrderHuLabelPocket = worOrderHuLabelPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = worOrderHuLabelPalletHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worOrderHuLabelArgs,
                GridView = gridView1,
                InitModelType = typeof(WorOrderHuLabelPalletHeaderModel),
                ModelArgs = _worOrderHuLabelArgs.WorOrderHuLabelModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WorOrderHuLabelModelArgs, WorOrderHuLabelPalletHeaderModel>(_worOrderHuLabelPocket.SelectWorOrderHuLabelPalletHeaderModels, null);

        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetShiftCode(colSHIFT_CD, _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_Comp_Cd, _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_Plant_Cd);

            base.DataRefresh(args);
        }

        public WorOrderHuLabelPalletHeaderModel GetSelectedModel()
        {
            return (WorOrderHuLabelPalletHeaderModel)worOrderHuLabelPalletHeaderModelBindingSource.Current;
        }

    }
}
