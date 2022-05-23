using BPack.Model.App.MD.ItmBomTree;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmBomTree;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.ItmBomTree
{
    public partial class BomTreeReverseList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmBomTreeArgs _itmBomTreeArgs;
        private ItmBomTreePocket _itmBomTreePocket;

        public BomTreeReverseList(ItmBomTreeArgs itmBomTreeArgs, ItmBomTreePocket itmBomTreePocket)
        {
            InitializeComponent();

            _itmBomTreeArgs = itmBomTreeArgs;
            _itmBomTreePocket = itmBomTreePocket;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bomTreeReverseModelBindingSource,
                FormArgs = _itmBomTreeArgs,
                ModelArgs = _itmBomTreeArgs.itmBomTreeModelArgs,
                InitModelType = typeof(BomTreeReverseModel),
                GridView = gridView1
            });
            InitPocketDelegate<ItmBomTreeModelArgs, BomTreeReverseModel>(_itmBomTreePocket.SelectBomTreeReverseModels, null);

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType", new { COMP_CD = _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Comp_Code }, "품목유형", "품목유형명");

            //colDEL_FG.Visible = false;
            colIsCheck.Visible = false;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            if (args == null)
            {
                base.DataClear(args);
                strapTextEdit1.EditValue = "";
                strapTextEdit2.EditValue = "";
                strapTextEdit3.EditValue = "";
            }
            else
            {
                var bomTreeModel = _itmBomTreeArgs.SelectedModelArgsBase.SelectedModelBase as BomTreeModel;
                if (bomTreeModel != null)
                {
                    strapTextEdit1.EditValue = bomTreeModel.CHILD_ITEM_CD;
                    strapTextEdit2.EditValue = bomTreeModel.ITEM_NM;
                }
            }

            gridView1.BestFitColumns();
        }
    }
}
