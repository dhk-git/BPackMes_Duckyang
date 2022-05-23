using BPack.Model.App.MD.ItmSales;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmSales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.ItmSales
{
    public partial class ItmSalesGateList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmSalesArgs _itmSalesArgs;
        private ItmSalesPocket _itmSalesPocket;

        public ItmSalesGateList()
        {
            InitializeComponent();
        }

        public ItmSalesGateList(ItmSalesArgs itmSalesArgs, ItmSalesPocket itmSalesPocket) : this()
        {
            _itmSalesArgs = itmSalesArgs;
            _itmSalesPocket = itmSalesPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            
            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = itmSalesGateModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _itmSalesArgs,
                GridView = gridView1,
                InitModelType = typeof(ItmSalesGateModel),
                ModelArgs = _itmSalesArgs.ItmSalesModelArgs
            });
            InitPocketDelegate<ItmSalesModelArgs, ItmSalesGateModel>(_itmSalesPocket.SelectItmSalesGateModels, null);
        }
    }
}
