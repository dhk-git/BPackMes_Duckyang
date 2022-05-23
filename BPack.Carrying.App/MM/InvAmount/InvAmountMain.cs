using BPack.CommonMes.Helpers;
using BPack.Pocket.App.MM.InvAmount;
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

namespace BPack.Carrying.App.MM.InvAmount
{
    public partial class InvAmountMain : StrapMainForm
    {
        private InvAmountArgs _invAmountArgs;
        private InvAmountPocket _invAmountPocket;
        private InvAmountList _invAmountList;
        public InvAmountMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _invAmountArgs = new InvAmountArgs();
            _invAmountPocket = new InvAmountPocket();
            _invAmountList = new InvAmountList(_invAmountArgs, _invAmountPocket);
            AddSubForm(this, _invAmountList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _invAmountArgs,
                StrapLayout = strapLayout1,
                InitlistForm = _invAmountList,
                IsAutoDataRefreshOnShown = false
            });
            InitRibbonButtons(true);
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            LookUpEditHelper.SetSysCode(strapLookUpEdit1, "ITEM_PRICE_TYPE", total:false, isFirstSelect:true);
            
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (strapLookUpEdit1.EditValue?.ToString() == "ITEM_TYPE_PUR")
            {
                strapLookUpEdit2.Properties.DataSource = null;
                strapLookUpEdit2.Properties.Columns.Clear();
                LookUpEditHelper.SetSysCode(strapLookUpEdit2, "ITEM_TYPE_PUR", total: true, isFirstSelect: true);
            }
            else if (strapLookUpEdit1.EditValue?.ToString() == "ITEM_TYPE_SALES")
            {
                strapLookUpEdit2.Properties.DataSource = null;
                strapLookUpEdit2.Properties.Columns.Clear();
                LookUpEditHelper.SetSysCode(strapLookUpEdit2, "ITEM_TYPE_SALES", total: true, isFirstSelect: true);
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _invAmountArgs.InvAmountModelArgs.Select_Main_Item_Price_Type = strapLookUpEdit1.EditValue?.ToString();
            _invAmountArgs.InvAmountModelArgs.Select_Main_Item_Type_Cd = strapLookUpEdit2.EditValue?.ToString();
            _invAmountArgs.InvAmountModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _invAmountArgs.InvAmountModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}
