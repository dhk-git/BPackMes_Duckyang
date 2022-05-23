using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvOrder;
using BPack.Pocket.App.SD.DlvOrder;
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

namespace BPack.Carrying.App.SD.DlvOrder
{
    public partial class DlvOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvOrderArgs _dlvOrderArgs;
        private DlvOrderPocket _dlvOrderPocket;

        public DlvOrderList()
        {
            InitializeComponent();
        }

        public DlvOrderList(DlvOrderArgs dlvOrderArgs, DlvOrderPocket dlvOrderPocket) : this()
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
                InitModelType = typeof(DlvOrderModel),
                ModelArgs = _dlvOrderArgs.DlvOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvOrderModelArgs, DlvOrderModel>(_dlvOrderPocket.SelectDlvOrderModels, _dlvOrderPocket.SaveDlvOrderModel, null);
            LookUpEditHelper.SetGridBusinessPartner(colBP_CD, Common.LoginInfo.UserInfo.CompCode, false, true);
            
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((DlvOrderModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((DlvOrderModel)model).DOH_STATUS = "WAIT";
            ((DlvOrderModel)model).DOH_DT = DateTime.Now.Date;
            base.SetInsertDefaultValue(model);
        }

        internal DlvOrderModel GetSelectedModel()
        {
            return dlvOrderModelBindingSource.Current as DlvOrderModel;
        }
        protected override void SelectModels(ArgsBase args)
        {
            base.SelectModels(args);
            DateTime today = DateTime.Now.Date;
            foreach (DlvOrderModel model in this.SelectedModels)
            {
                if (model.DOH_DT < today && model.DOH_STATUS != "CLOSE")
                {
                    StrapMessageBox.Show("A001", 56); //날짜가 지났지만 완료되지 않은 출하지시가 존재합니다.해당 지시에 예약된 식별표정보를 다른 지시에서 사용할 수가 없습니다.출하확정처리가 안되었다면 확정처리를 하거나 취소 후 삭제하거나 출하일자를 바꾸어 재사용바랍니다.
                    return;
                }
            }
        }
        //public void SetConfirmDlvOrder()
        //{
        //    ((DlvOrderModel)dlvOrderModelBindingSource.Current).DOH_STATUS = "OPEN";
        //    dlvOrderModelBindingSource.ResetBindings(false);
        //}
        //public void SetCancelConfirmDlvOrder()
        //{
        //    ((DlvOrderModel)dlvOrderModelBindingSource.Current).DOH_STATUS = "WAIT";
        //    dlvOrderModelBindingSource.ResetBindings(false);
        //}

    }
}
