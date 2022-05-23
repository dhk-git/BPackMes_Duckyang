using BPack.Model.App.MD.ItmPurchase;
using BPack.Model.App.MD.PrdWorkCenter;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmPurchase;
using BPack.Pocket.App.MD.PrdWorkCenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.ItmPurchase
{
    public partial class ItmPurchaseList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmPurchaseArgs _prdWorkCenterArgs;
        private ItmPurchasePocket _prdWorkCenterPocket;

        public ItmPurchaseList()
        {
            InitializeComponent();
        }

        public ItmPurchaseList(ItmPurchaseArgs prdWorkCenterArgs, ItmPurchasePocket prdWorkCenterPocket) : this()
        {
            _prdWorkCenterArgs = prdWorkCenterArgs;
            _prdWorkCenterPocket = prdWorkCenterPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = itmPurchaseModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _prdWorkCenterArgs,
                GridView = gridView1,
                InitModelType = typeof(ItmPurchaseModel),
                ModelArgs = _prdWorkCenterArgs.ItmPurchaseModelArgs
            });
            InitPocketDelegate<ItmPurchaseModelArgs, ItmPurchaseModel>(_prdWorkCenterPocket.SelectItmPurchaseModels, null);
            //colMODIFY_DTTM.Visible = false;
            //colMODIFY_USER_ID.Visible = false;
            //gridView1.OptionsView.ColumnAutoWidth = true;
        }
    }
}
