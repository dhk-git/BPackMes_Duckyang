using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.MD.PrdRouting;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
//using BPack.Strap.MasterDataControls.MD;
using BPack.Pocket.App.MD.PrdRouting;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MD.PrdRouting
{
    public partial class RoutingList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdRoutingArgs _prdRoutingArgs;
        private PrdRoutingPocket _prdRoutingPocket;
        private ItemMasterRepositoryButtonEdit _buttonItem;

        public RoutingList(PrdRoutingArgs prdRoutingArgs, PrdRoutingPocket prdRoutingPocket)
        {
            InitializeComponent();

            _prdRoutingArgs = prdRoutingArgs;
            _prdRoutingPocket = prdRoutingPocket;
        }

        public override void InitStrap()
        {
            IsBestFitStrapGrid = true;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = routingModelBindingSource,
                FormArgs = _prdRoutingArgs,
                GridView = gridView1,
                InitModelType = typeof(RoutingModel),
                ModelArgs = _prdRoutingArgs.PrdRoutingModelArgs,
                StrapEditMode = StrapEditMode.Batch,
                ExcelUploadModelType = null
                
            });
            InitPocketDelegate<PrdRoutingModelArgs, RoutingModel>(_prdRoutingPocket.SelectRoutingModels, _prdRoutingPocket.SaveRoutingModel, _prdRoutingPocket.SaveRoutingModels);

        }

        internal void CopyRouting()
        {
            if (strapGridControl1.SelectedModel == null)
            {
                StrapMessageBox.Show("A001", 9);
                return;
            }
            if (StrapMessageBox.Show("A001", 20, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var msgResult = StrapMessageBox.Show("A001", 34, messageBoxButtons: System.Windows.Forms.MessageBoxButtons.YesNo);
                if (msgResult != System.Windows.Forms.DialogResult.Yes) return;

                if (!String.IsNullOrEmpty(_prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Route_No?.ToString()))
                {
                    _prdRoutingPocket.BpCopyRouting((RoutingModel)_prdRoutingArgs.SelectedModelArgsBase.SelectedModelBase);
                    StrapMessageBox.Show("A001", 36);
                }
            };
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((RoutingModel)model).COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code;
            ((RoutingModel)model).PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code;
        }

        public override void DataRefresh(ArgsBase args)
        {
            _buttonItem = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1, _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code, _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code);
            _buttonItem.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((RoutingModel)routingModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((RoutingModel)routingModelBindingSource.Current).ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;
                ((RoutingModel)routingModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;
                //((RoutingModel)routingModelBindingSource.Current).ALC_CD = e.SeletedItemMasterModel.ALC_CD;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };

            base.DataRefresh(args);
        }
    }
}
