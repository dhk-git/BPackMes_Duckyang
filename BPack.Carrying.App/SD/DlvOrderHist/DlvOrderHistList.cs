using BPack.Common.Model;
using BPack.CommonMes.Helpers;
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
    public partial class DlvOrderHistList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvOrderHistArgs _dlvOrderArgs;
        private DlvOrderHistPocket _dlvOrderPocket;

        public DlvOrderHistList()
        {
            InitializeComponent();
        }

        public DlvOrderHistList(DlvOrderHistArgs dlvOrderArgs, DlvOrderHistPocket dlvOrderPocket) : this()
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
                InitModelType = typeof(DlvOrderHistModel),
                ModelArgs = _dlvOrderArgs.DlvOrderHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvOrderHistModelArgs, DlvOrderHistModel>(_dlvOrderPocket.SelectDlvOrderHistModels,null);
          //  LookUpEditHelper.SetGridBusinessPartner(colBP_CD, Common.LoginInfo.UserInfo.CompCode, false, true);
            
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }

        internal DlvOrderHistModel GetSelectedModel()
        {
            return dlvOrderModelBindingSource.Current as DlvOrderHistModel;
        }

    

    }
}
