using BPack.Pocket.App.MM.GirLocStock;
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

namespace BPack.Carrying.App.MM.GirLocStock
{
    public partial class GirLocStockAdjust : Form
    {
        private GirLocStockArgs _girLocStockArgs;
        private GirLocStockPocket _girLocStockPocket;
        public event EventHandler CompletedAdjust;

        public GirLocStockAdjust()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public GirLocStockAdjust(GirLocStockArgs girLocStockArgs, GirLocStockPocket girLocStockPocket) : this()
        {
            this._girLocStockArgs = girLocStockArgs;
            this._girLocStockPocket = girLocStockPocket;
            comboBoxEdit1.Properties.Items.Add("재고조정입고(GR10)");
            comboBoxEdit1.Properties.Items.Add("재고조정출고(GI13)");
            comboBoxEdit1.EditValue = "재고조정입고(GR10)";

            textEdit1.EditValue = _girLocStockArgs.GirLocStockModelArgs.Select_Stock_Item_Cd;
            //현재고
            spinEdit2.Properties.Mask.EditMask = "#,##0.###";
            spinEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            spinEdit2.Properties.Mask.UseMaskAsDisplayFormat = true;
            spinEdit2.EditValue = _girLocStockArgs.GirLocStockModelArgs.Select_Item_Stock_Qty;
            //조정후재고
            spinEdit3.Properties.Mask.EditMask = "#,##0.###";
            spinEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            spinEdit3.Properties.Mask.UseMaskAsDisplayFormat = true;
            spinEdit3.EditValue = _girLocStockArgs.GirLocStockModelArgs.Select_Item_Stock_Qty;

        }

        //재고조정등록버튼
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_girLocStockArgs.GirLocStockModelArgs.Select_Stock_Item_Cd))
            {
                MessageBox.Show("품번이 선택되지 않았습니다.");
                return;
            }
            if (StrapMessageBox.Show(comboBoxEdit1.EditValue?.ToString() + " 처리 됩니다.", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            _girLocStockArgs.GirLocStockModelArgs.Select_Adjust_Wh_Cd = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Wh_Cd;
            _girLocStockArgs.GirLocStockModelArgs.Select_Adjust_Loc_Cd = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Loc_Cd;
            _girLocStockArgs.GirLocStockModelArgs.Select_Adjust_Qty = (decimal)spinEdit1.EditValue;
            if (comboBoxEdit1.EditValue.Equals("재고조정입고(GR10)"))
            {
                _girLocStockArgs.GirLocStockModelArgs.Select_Adjust_GirType = "GR10";
            }
            if (comboBoxEdit1.EditValue.Equals("재고조정출고(GI13)"))
            {
                _girLocStockArgs.GirLocStockModelArgs.Select_Adjust_GirType = "GI13";
            }
            try
            {
                _girLocStockPocket.BpGirLocAdjust(_girLocStockArgs.GirLocStockModelArgs);
                CompletedAdjust?.Invoke(this, null);
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

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.EditValue.Equals("재고조정입고(GR10)"))
            {
                spinEdit3.EditValue = _girLocStockArgs.GirLocStockModelArgs.Select_Item_Stock_Qty + (decimal)spinEdit1.EditValue;
            }
            if (comboBoxEdit1.EditValue.Equals("재고조정출고(GI13)"))
            {
                spinEdit3.EditValue = _girLocStockArgs.GirLocStockModelArgs.Select_Item_Stock_Qty - (decimal)spinEdit1.EditValue;
            }
        }

        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.EditValue.Equals("재고조정입고(GR10)"))
            {
                spinEdit3.EditValue = _girLocStockArgs.GirLocStockModelArgs.Select_Item_Stock_Qty + (decimal)spinEdit1.EditValue;
            }
            if (comboBoxEdit1.EditValue.Equals("재고조정출고(GI13)"))
            {
                spinEdit3.EditValue = _girLocStockArgs.GirLocStockModelArgs.Select_Item_Stock_Qty - (decimal)spinEdit1.EditValue;
            }
        }
    }
}
