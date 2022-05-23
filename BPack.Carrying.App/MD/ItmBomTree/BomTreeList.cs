using BPack.Model.App.MD.ItmBomTree;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmBomTree;
using System;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.ItmBomTree
{
    public partial class BomTreeList : StrapSubForm_TreeList
    {
        private ItmBomTreeArgs _itmBomTreeArgs;
        private ItmBomTreePocket _itmBomTreePocket;
        private BomTreeReverseList _bomTreeReverseList;

        public BomTreeList(ItmBomTreeArgs itmBomTreeArgs, ItmBomTreePocket itmBomTreePocket)
        {
            InitializeComponent();

            _itmBomTreeArgs = itmBomTreeArgs;
            _itmBomTreePocket = itmBomTreePocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_TreeList
            {
                BindingSource = bomTreeModelBindingSource,
                FormArgs = _itmBomTreeArgs,
                ModelArgs = _itmBomTreeArgs.itmBomTreeModelArgs,
                TreeList = strapTreeList1,
                InitModelType = typeof(BomTreeModel)
            });
            InitZipperDelegate<ItmBomTreeModelArgs, BomTreeModel>(_itmBomTreePocket.SelectBomTreeModels, null);

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Comp_Code }, "품목유형", "품목유형명");

            strapTreeList1.OptionsView.AutoWidth = false;

            _bomTreeReverseList = new BomTreeReverseList(_itmBomTreeArgs, _itmBomTreePocket);
            colBOM_QTY.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            colBOM_QTY.Format.FormatString = "{0:#,##0.######}";
            toolStripMenuItem1.Text = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, toolStripMenuItem1.Text);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            strapTreeList1.ExpandAll();
            strapTreeList1.BestFitColumns();
        }

        public override void DataClear(ArgsBase args)
        {
            base.DataClear(args);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _bomTreeReverseList.DataRefresh(_itmBomTreeArgs);
            _bomTreeReverseList.ShowDialog();
        }

        public BomTreeReverseList GetReverseForm() {
            if (_bomTreeReverseList != null) {
                return _bomTreeReverseList;
            }
            return null;
        }

    }
}
