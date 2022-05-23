using BPack.Common.Model;
using BPack.CommonMes.Helpers;
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
    public partial class SalesOrderHistList : StrapSubForm_OnlyOneGrid_V2
    {
        private SalesOrderHistArgs _dlvOrderArgs;
        private SalesOrderHistPocket _dlvOrderPocket;

        public SalesOrderHistList()
        {
            InitializeComponent();
        }

        public SalesOrderHistList(SalesOrderHistArgs dlvOrderArgs, SalesOrderHistPocket dlvOrderPocket) : this()
        {
            this._dlvOrderArgs = dlvOrderArgs;
            this._dlvOrderPocket = dlvOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvOrderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(SalesOrderHistModel),
                ModelArgs = _dlvOrderArgs.SalesOrderHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<SalesOrderHistModelArgs, SalesOrderHistModel>(_dlvOrderPocket.SelectSalesOrderHistModels,null);
            //  LookUpEditHelper.SetGridBusinessPartner(colBP_CD, Common.LoginInfo.UserInfo.CompCode, false, true);
            if (!this.AuthModel.DUMMY1_AUTH)
            {
                colCOST.Visible = false;
                colCOST.OptionsColumn.ShowInCustomizationForm = false;
                colCURRENCY_TYPE.Visible = false;
                colCURRENCY_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }

        internal SalesOrderHistModel GetSelectedModel()
        {
            return dlvOrderModelBindingSource.Current as SalesOrderHistModel;
        }

    

    }
}
