using BPack.Model.App.SD.DlvOrder;
using BPack.Pocket.App.SD.DlvOrder;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.SD.DlvOrder
{
    public partial class DlvPlanList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvOrderArgs _dlvOrderArgs;
        private DlvOrderPocket _dlvOrderPocket;

        public DlvPlanList()
        {
            InitializeComponent();
        }

        public DlvPlanList(DlvOrderArgs dlvOrderArgs, DlvOrderPocket dlvOrderPocket) : this()
        {
            this._dlvOrderArgs = dlvOrderArgs;
            this._dlvOrderPocket = dlvOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvPlanModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvPlanModel),
                ModelArgs = _dlvOrderArgs.DlvOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvOrderModelArgs, DlvPlanModel>(_dlvOrderPocket.SelectDlvPlanModels, null, null);
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.OptionsSelection.MultiSelect = true;
        }



        internal List<DlvPlanModel> GetSelectedDlvPlanModels()
        {
            List<DlvPlanModel> checkedDlvPlanModels = new List<DlvPlanModel>();
            var selectedRows = gridView1.GetSelectedRows();
            foreach (var row in selectedRows)
            {
                checkedDlvPlanModels.Add(gridView1.GetRow(row) as DlvPlanModel);
            }
            return checkedDlvPlanModels;
        }

        internal void DeleteCheckedDlvPlanModels(List<DlvPlanModel> checkedDlvPlanModels)
        {
            foreach (var model in checkedDlvPlanModels)
            {
                dlvPlanModelBindingSource.Remove(model);
            }
            dlvPlanModelBindingSource.ResetBindings(false);
        }
    }
}
