using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.SD.DlvOrderHist;
using BPack.Pocket.App.SD.DlvOrderHist;
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

namespace BPack.Carrying.App.SD.DlvOrderHist
{
    public partial class DlvOrderHistDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvOrderHistArgs _dlvOrderArgs;
        private DlvOrderHistPocket _dlvOrderPocket;
        //private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public DlvOrderHistDetailList()
        {
            InitializeComponent();
        }

        public DlvOrderHistDetailList(DlvOrderHistArgs dlvOrderArgs, DlvOrderHistPocket dlvOrderPocket) : this()
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
                InitModelType = typeof(DlvOrderHistDetailModel),
                ModelArgs = _dlvOrderArgs.DlvOrderHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvOrderHistModelArgs, DlvOrderHistDetailModel>(_dlvOrderPocket.SelectDlvOrderHistDetailModels, null);


          
        }
      

   

    }
}
