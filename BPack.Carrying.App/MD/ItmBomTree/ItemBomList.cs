using BPack.Model.App.MD.ItmBomTree;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmBomTree;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.ItmBomTree
{
    public partial class ItemBomList : StrapSubForm_OnlyOneGrid_V2
    {
        ItmBomTreeArgs _itmBomTreeArgs;
        ItmBomTreePocket _itmBomTreePocket;

        public ItemBomList(ItmBomTreeArgs itmBomTreeArgs, ItmBomTreePocket itmBomTreePocket)
        {
            InitializeComponent();

            _itmBomTreeArgs = itmBomTreeArgs;
            _itmBomTreePocket = itmBomTreePocket;

        }

        public override void InitStrap() 
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = itemBomModelBindingSource,
                FormArgs = _itmBomTreeArgs,
                GridView = gridView1,
                InitModelType = typeof(ItemBomModel),
                ModelArgs = _itmBomTreeArgs.itmBomTreeModelArgs
            });
            InitPocketDelegate<ItmBomTreeModelArgs, ItemBomModel>(_itmBomTreePocket.SelectItemBomModels, null);

           // LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Comp_Code }, "품목유형", "품목유형명");
        }
    }
}
