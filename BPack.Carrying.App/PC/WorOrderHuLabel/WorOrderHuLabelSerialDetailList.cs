using BPack.Model.App.PC.WorOrderHuLabel;
using BPack.Pocket.App.PC.WorOrderHuLabel;
using BPack.Strap.FormControls;
using System.Collections.Generic;

namespace BPack.Carrying.App.PC.WorOrderHuLabel
{
    public partial class WorOrderHuLabelSerialDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorOrderHuLabelArgs _worOrderHuLabelArgs;
        private WorOrderHuLabelPocket _worOrderHuLabelPocket;

        public WorOrderHuLabelSerialDetailList()
        {
            InitializeComponent();
        }

        public WorOrderHuLabelSerialDetailList(WorOrderHuLabelArgs worOrderHuLabelArgs, WorOrderHuLabelPocket worOrderHuLabelPocket) : this()
        {
            _worOrderHuLabelArgs = worOrderHuLabelArgs;
            _worOrderHuLabelPocket = worOrderHuLabelPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = worOrderHuLabelSerialDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worOrderHuLabelArgs,
                GridView = gridView1,
                InitModelType = typeof(WorOrderHuLabelSerialDetailModel),
                ModelArgs = _worOrderHuLabelArgs.WorOrderHuLabelModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<WorOrderHuLabelModelArgs, WorOrderHuLabelSerialDetailModel>(_worOrderHuLabelPocket.SelectWorOrderHuLabelSerialDetailModels, null, _worOrderHuLabelPocket.SaveWorOrderHuLabelSerialDetailModels);

            colIsCheck.VisibleIndex = 0;
            colIsCheck.Width = 45;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }

        public List<WorOrderHuLabelSerialDetailModel> GetSelectedModels()
        {
            return (List<WorOrderHuLabelSerialDetailModel>)worOrderHuLabelSerialDetailModelBindingSource.DataSource;
        }

    }
}
