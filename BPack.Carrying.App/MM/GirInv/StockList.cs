using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirInv;
using BPack.Pocket.App.MM.GirInv;
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

namespace BPack.Carrying.App.MM.GirInv
{
    public partial class StockList : XtraForm
    {
        private GirInvArgs _girInvArgs;
        private GirInvPocket _girInvPocket;
        public event EventHandler<OkButtonClickEventArgs> OkButtonClick;

        public StockList()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
            lupWareHouse.Enabled = false;
            dteInvGirDt.Enabled = false;
            LookUpEditHelper.SetWareHouse(lupWareHouse, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode);
            string trLangWord;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                trLangWord = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, col.Caption);
                if (!string.IsNullOrEmpty(trLangWord))
                {
                    col.Caption = trLangWord;
                }
                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            trLangWord = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, layoutControlItem2.Text);
            if (!string.IsNullOrEmpty(trLangWord))
            {
                layoutControlItem2.Text = trLangWord;
            }

            //2022.03.18 정수교 언어 변환 추가
            trLangWord = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, layoutControlItem6.Text);
            if (!string.IsNullOrEmpty(trLangWord))
            {
                layoutControlItem6.Text = trLangWord;
            }
            

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit stockQtyEditor =  new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            stockQtyEditor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            stockQtyEditor.DisplayFormat.FormatString = "#,##0.######";
            colWH_STOCK_QTY.ColumnEdit = stockQtyEditor;
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit afGrQty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            afGrQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            afGrQty.DisplayFormat.FormatString = "#,##0.######";
            colAFTER_GR_QTY.ColumnEdit = afGrQty;
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit afGiQty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            afGiQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            afGiQty.DisplayFormat.FormatString = "#,##0.######";
            colAFTER_GI_QTY.ColumnEdit = afGiQty;
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit logiQty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            logiQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            logiQty.DisplayFormat.FormatString = "#,##0.######";
            colLOGI_QTY.ColumnEdit = logiQty;

            colCOMP_CD.Visible = false;
            colPLANT_CD.Visible = false;
            colWH_CD.Visible = false;
            colWH_STOCK_QTY.Visible = false;
            colAFTER_GI_QTY.Visible = false;
            colAFTER_GR_QTY.Visible = false;
        }

        public StockList(GirInvArgs girInvArgs, GirInvPocket girInvPocket) : this()
        {
            this._girInvArgs = girInvArgs;
            this._girInvPocket = girInvPocket;
        }

        public void DataRefresh()
        {
            lupWareHouse.EditValue = _girInvArgs.GirInvModelArgs.Select_Wh_Cd;
            var workDt = CommonMes.Config.GlobalSettings.GetWorkDt();
            if (_girInvArgs.GirInvModelArgs.Select_Inv_Gir_Dt != workDt)
            {
                dteInvGirDt.DateTime = _girInvArgs.GirInvModelArgs.Select_Inv_Gir_Dt;
            }
            else
            {
                dteInvGirDt.DateTime = workDt;
            }
            var data = _girInvPocket.SelectStockModels(_girInvArgs.GirInvModelArgs);
            bindingSource1.DataSource = data;
        }

        public class OkButtonClickEventArgs : EventArgs
        {
            public List<StockModel> SelectedStockModels { get; set; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OkButtonClickEventArgs okButtonClickEventArgs = new OkButtonClickEventArgs();
            okButtonClickEventArgs.SelectedStockModels = new List<StockModel>();
            var selectedRows = gridView1.GetSelectedRows();
            foreach (var rowHandle in selectedRows)
            {
                okButtonClickEventArgs.SelectedStockModels.Add(gridView1.GetRow(rowHandle) as StockModel);
            }
            OkButtonClick?.Invoke(this, okButtonClickEventArgs);
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }
    }
}
