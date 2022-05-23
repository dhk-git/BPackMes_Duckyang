using BPack.Model.App.PC.WoeResultBatch;
using BPack.Pocket.App.PC.WoeResultBatch;
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

namespace BPack.Carrying.App.PC.WoeResultBatch
{
    public partial class WoeResultBatchAddResult : StrapForm
    {
        private WoeResultBatchArgs _woeResultBatchArgs;
        private WoeResultBatchPocket _woeResultBatchPocket;
        public event EventHandler<EventArgs> AddedResult;
        public WoeResultBatchAddResult()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public WoeResultBatchAddResult(WoeResultBatchArgs woeResultBatchArgs, WoeResultBatchPocket woeResultBatchPocket) : this()
        {
            this._woeResultBatchArgs = woeResultBatchArgs;
            this._woeResultBatchPocket = woeResultBatchPocket;

            strapTextEdit1.EditValue = "0";
            strapTextEdit2.EditValue = _woeResultBatchArgs.SelectedHuQty;

            WoeResultBatchBpModel woeResultBatchBpModel = new WoeResultBatchBpModel()
            {
                COMP_CD = _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Comp_Cd,
                PLANT_CD = _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Main_Plant_Cd,
                CrudCls = "Added",
                LANG_CODE = "KOR",
                OPER = 10,
                PROD_QTY = 0,
                ROUTE_NO = _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Route_No,
                REMARK = "",
                SEMI_HU_NO = _woeResultBatchArgs.SelectedHuList,
                SEMI_SEPERATOR = "^#^",
                USER_ID = Common.LoginInfo.UserInfo.UserID,
                WC_CD = _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Main_Wc_Cd,
                WO_NO = _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Wo_No
            };
            _woeResultBatchArgs.WoeResultBatchBpModel = woeResultBatchBpModel;

        }

        //실적등록 버튼
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (_woeResultBatchArgs.WoeResultBatchBpModel.PROD_QTY <= 0)
            {
                MessageBox.Show("실적 수량을 확인바랍니다.");
                return;
            }
            if ((decimal)strapTextEdit3.EditValue < 0)
            {
                MessageBox.Show("선택한 자재 식별표가 부족합니다.");
                return;
            }
            if (StrapMessageBox.Show("생산실적을 등록합니다.", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                _woeResultBatchPocket.BpWoeResultBatch(_woeResultBatchArgs.WoeResultBatchBpModel);
                AddedResult?.Invoke(this, null);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //취소버튼
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //생산수량 수정
        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            _woeResultBatchArgs.WoeResultBatchBpModel.PROD_QTY = (int)spinEdit1.Value;
            strapTextEdit1.EditValue = _woeResultBatchArgs.WoeResultBatchBpModel.PROD_QTY * _woeResultBatchArgs.OperQty;
            strapTextEdit3.EditValue = _woeResultBatchArgs.SelectedHuQty - (decimal)strapTextEdit1.EditValue;
        }
    }
}
