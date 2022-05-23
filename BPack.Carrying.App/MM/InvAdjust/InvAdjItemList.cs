using BPack.Common.Model;
using BPack.Model.App.MM.InvAdjust;
using BPack.Pocket.App.MM.InvAdjust;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Strap.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.InvAdjust
{
    public partial class InvAdjItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvAdjustArgs _invAdjustArgs;
        private InvAdjustPocket _invAdjustPocket;
        private LookUpEditPocket _lep;
        private int _currentRowHandler;
        public InvAdjItemList()
        {
            InitializeComponent();
        }

        public InvAdjItemList(InvAdjustArgs invAdjustArgs, InvAdjustPocket invAdjustPocket) : this()
        {
            this._invAdjustArgs = invAdjustArgs;
            this._invAdjustPocket = invAdjustPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _lep = LookUpEditPocket.GetInstance();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = invAdjItemModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _invAdjustArgs,
                GridView = gridView1,
                InitModelType = typeof(InvAdjItemModel),
                ModelArgs = _invAdjustArgs.InvAdjustModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InvAdjustModelArgs, InvAdjItemModel>(_invAdjustPocket.SelectInvAdjItemModels, null, null);
            _lep.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "품목유형코드", "품목유형명");
            this.ModelSelectedEvent += InvAdjItemList_ModelSelectedEvent;
        }

        private void InvAdjItemList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _currentRowHandler = gridView1.FocusedRowHandle;
        }

        public void SetPreRowSelect()
        {
            if (_invAdjustArgs.InvAdjustModelArgs.Select_Item_Cd != null)
            {
                //Core 소스 가져옴
                invAdjItemModelBindingSource.Position = _bindingSource.IndexOf(_gridView.GetRow(_currentRowHandler)); 
                ((ModelBase)_bindingSource.Current).SelectedCheck = 1;
                ((StrapGridControl)_gridView.GridControl).SelectedModelIndex = _currentRowHandler;
                ((StrapGridControl)_gridView.GridControl).SelectedModel = _bindingSource.Current as ModelBase;
                gridView1.FocusedRowHandle = _currentRowHandler;
                _gridView.TopRowIndex = _currentRowHandler;
            }
        }
    }
}
