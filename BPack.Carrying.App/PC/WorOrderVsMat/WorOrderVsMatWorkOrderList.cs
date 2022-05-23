using BPack.Common.Model;
using BPack.Model.App.PC.WorOrderVsMat;
using BPack.Pocket.App.PC.WorOrderVsMat;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BPack.Carrying.App.PC.WorOrderVsMat
{
    public partial class WorOrderVsMatWorkOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorOrderVsMatArgs _worOrderVsMatArgs;
        private WorOrderVsMatPocket _worOrderVsMatPocket;

        public event EventHandler<object> ModelSelectionChangedEvent;

        public WorOrderVsMatWorkOrderList()
        {
            InitializeComponent();
        }

        public WorOrderVsMatWorkOrderList(WorOrderVsMatArgs worOrderVsMatArgs, WorOrderVsMatPocket worOrderVsMatPocket) : this()
        {
            _worOrderVsMatArgs = worOrderVsMatArgs;
            _worOrderVsMatPocket = worOrderVsMatPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = worOrderVsMatWorkOrderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worOrderVsMatArgs,
                GridView = gridView1,
                InitModelType = typeof(WorOrderVsMatWorkOrderModel),
                ModelArgs = _worOrderVsMatArgs.WorOrderVsMatModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WorOrderVsMatModelArgs, WorOrderVsMatWorkOrderModel>(_worOrderVsMatPocket.SelectWorkOrderModels, null);

            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            colIsCheck.Visible = false;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            var models = (strapGridControl1.DataSource as System.Windows.Forms.BindingSource).DataSource as List<WorOrderVsMatWorkOrderModel>;

            if (models == null) return;

            gridView1.BestFitColumns();
        }

        public List<WorOrderVsMatWorkOrderModel> GetSelectedModels()
        {
            List<WorOrderVsMatWorkOrderModel> models = new List<WorOrderVsMatWorkOrderModel>();
            var rowIndexArr = gridView1.GetSelectedRows();
            foreach(var rowIdx in rowIndexArr)
            {
                var model = gridView1.GetRow(rowIdx) as WorOrderVsMatWorkOrderModel;
                models.Add(model);
            }
            return models;
        }

        private void ModelSelectionChangedRaiseEvent()
        {
            if (worOrderVsMatWorkOrderModelBindingSource.Current != null)
            {
                try
                {
                    ModelSelectionChangedEvent?.Invoke(this, worOrderVsMatWorkOrderModelBindingSource.DataSource as List<WorOrderVsMatWorkOrderModel>);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            ModelSelectionChangedRaiseEvent();
        }
    }
}
