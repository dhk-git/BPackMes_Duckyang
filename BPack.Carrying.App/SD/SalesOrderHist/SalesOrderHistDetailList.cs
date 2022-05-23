using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.SD.SalesOrderHist;
using BPack.Pocket.App.SD.SalesOrderHist;
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

namespace BPack.Carrying.App.SD.SalesOrderHist
{
    public partial class SalesOrderHistDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private SalesOrderHistArgs _dlvOrderArgs;
        private SalesOrderHistPocket _dlvOrderPocket;
        //private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public SalesOrderHistDetailList()
        {
            InitializeComponent();
        }

        public SalesOrderHistDetailList(SalesOrderHistArgs dlvOrderArgs, SalesOrderHistPocket dlvOrderPocket) : this()
        {
            this._dlvOrderArgs = dlvOrderArgs;
            this._dlvOrderPocket = dlvOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvOrderDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(SalesOrderHistDetailModel),
                ModelArgs = _dlvOrderArgs.SalesOrderHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<SalesOrderHistModelArgs, SalesOrderHistDetailModel>(_dlvOrderPocket.SelectSalesOrderHistDetailModels, null);

            if (!this.AuthModel.DUMMY1_AUTH)
            {
                colSOD_PRICE.Visible = false;
                colSOD_PRICE.OptionsColumn.ShowInCustomizationForm = false;
                colCOST.Visible = false;
                colCOST.OptionsColumn.ShowInCustomizationForm = false;
                colCURRENCY_TYPE.Visible = false;
                colCURRENCY_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            }
    
        }
      

   

    }
}
