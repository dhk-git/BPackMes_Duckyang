using BPack.Pocket.App.PO.Mrp;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.PO.Mrp
{
    public partial class PopupList : XtraForm
    {
        private MrpArgs _mrpArgs;
        private MrpPocket _mrpPocket;

        public PopupList()
        {
            InitializeComponent();
        }

        public PopupList(MrpArgs mrpArgs, MrpPocket mrpPocket) : this()
        {
            this._mrpArgs = mrpArgs;
            this._mrpPocket = mrpPocket;
            this.IconOptions.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ColumnAutoWidth = false;
            
        }

        public void SetGridColumn()
        {
            string trLang = string.Empty;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                trLang = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, col.CustomizationSearchCaption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    col.Caption = trLang;
                }
                if (col.ColumnType == typeof(decimal))
                {
                    col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    col.DisplayFormat.FormatString = "#,##0";
                }
                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
        }

        public void DataRefresh_PacPopup()
        {
            this.Text = "Invoice/PackingList";
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.DataSource = _mrpPocket.SelectPacPopupModels(_mrpArgs.MrpModelArgs);
            SetGridColumn();
            gridView1.BestFitColumns();
        }

        public void DataRefresh_PoPopup()
        {
            this.Text = "PurchaseOrderList";
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            var data = _mrpPocket.SelectPoPopupModels(_mrpArgs.MrpModelArgs);
            gridControl1.DataSource = data;
            SetGridColumn();
            gridView1.BestFitColumns();
        }

        public void DataRefresh_PoePopup()
        {
            this.Text = "PurchaseOrderRequestList";
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            var data = _mrpPocket.SelectPoePopupModels(_mrpArgs.MrpModelArgs);
            gridControl1.DataSource = data;
            SetGridColumn(); 
            gridView1.BestFitColumns();
        }
    }
}
