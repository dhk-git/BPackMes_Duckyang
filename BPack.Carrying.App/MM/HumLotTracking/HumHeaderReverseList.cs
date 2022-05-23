using BPack.Model.App.MM.HumLotTracking;
using BPack.Pocket.App.MM.HumLotTracking;
using BPack.Strap.FormControls;
using System;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.HumLotTracking
{
    public partial class HumHeaderReverseList : StrapSubForm_OnlyOneGrid_V2
    {
        private HumLotTrackingArgs _humLotTrackingArgs;
        private HumLotTrackingPocket _humLotTrackingPocket;

        public HumHeaderReverseList()
        {
            InitializeComponent();

            //gridView1.BeginDataUpdate();
            //try
            //{
            //    gridView1.ClearSorting();
            //    //gridView1.Columns["CREATE_DTTM"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            //}
            //finally
            //{
            //    gridView1.EndDataUpdate();
            //}
        }

        public HumHeaderReverseList(HumLotTrackingArgs humLotTrackingArgs, HumLotTrackingPocket humLotTrackingPocket) : this()
        {
            this._humLotTrackingArgs = humLotTrackingArgs;
            this._humLotTrackingPocket = humLotTrackingPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid { 
                BindingSource = humHeaderReverseModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _humLotTrackingArgs,
                GridView = gridView1,
                InitModelType = typeof(HumHeaderReverseModel),
                ModelArgs = _humLotTrackingArgs.HumLotTrackingModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<HumLotTrackingModelArgs, HumHeaderReverseModel>(_humLotTrackingPocket.SelectHumHeaderBackwardModels, null, null);
            //colIsCheck.VisibleIndex = 0;
            //colIsCheck.Visible = false;
            //gridView1.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }

        internal void SetCheckedSemi(CheckState checkState)
        {
            if (checkState == CheckState.Checked)
            {
                colBODY_NO.Visible = false;
                colPBS_SEQ.Visible = false;
                colDLV_DT.Visible = false;
            }
            else
            {
                colBODY_NO.Visible = true;
                colPBS_SEQ.Visible = true;
                colDLV_DT.Visible = true;
            }
        }
    }
}
