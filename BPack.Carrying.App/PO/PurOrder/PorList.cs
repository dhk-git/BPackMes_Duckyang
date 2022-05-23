using BPack.CommonMes.Helpers;
using BPack.Model.App.PO.PurOrder;
using BPack.Pocket.App.PO.PurOrder;
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

namespace BPack.Carrying.App.PO.PurOrder
{
    public partial class PorList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurOrderArgs _purOrderArgs;
        private PurOrderPocket _purOrderPocket;

        public PorList()
        {
            InitializeComponent();
        }

        public PorList(PurOrderArgs purOrderArgs, PurOrderPocket purOrderPocket) : this()
        {
            this._purOrderArgs = purOrderArgs;
            this._purOrderPocket = purOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = porModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _purOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(PorModel),
                ModelArgs = _purOrderArgs.PurOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<PurOrderModelArgs, PorModel>(_purOrderPocket.SelectPorModels, null);
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            LookUpEditHelper.SetGridBusinessPartner(colBP_CD, Common.LoginInfo.UserInfo.CompCode, true, false);
        }
        public List<PorModel> GetCheckedModels()
        {
            var checkedRows = gridView1.GetSelectedRows();
            List<PorModel> porModels = new List<PorModel>();
            foreach (var rowHandle in checkedRows)
            {
                porModels.Add(gridView1.GetRow(rowHandle) as PorModel);
            }
            return porModels;
        }
    }
}
