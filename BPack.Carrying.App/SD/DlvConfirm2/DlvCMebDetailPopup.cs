using BPack.Common.LoginInfo;
using BPack.Model.App.SD.DlvConfirm2;
using BPack.Pocket.App.SD.DlvConfirm2;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.SD.DlvConfirm2
{
    public partial class DlvCMebDetailPopup : StrapForm
    {
        private DlvConfirm2Args _dlvConfirm2Args;
        private DlvConfirm2Pocket _dlvConfirm2Pocket;

        string trLang;

        public DlvCMebDetailPopup()
        {
            InitializeComponent();
        }

        public DlvCMebDetailPopup(DlvConfirm2Args dlvConfirm2Args, DlvConfirm2Pocket dlvConfirm2Pocket) :this()
        {
            this._dlvConfirm2Args = dlvConfirm2Args;
            this._dlvConfirm2Pocket = dlvConfirm2Pocket;
        }

        private void DlvCMebDetailPopup_Load(object sender, EventArgs e)
        {
            List<DlvPopOrdModel> HeaderModels = new List<DlvPopOrdModel>();
            List<DlvPopOrdDetailModel> DetailModel = new List<DlvPopOrdDetailModel>();
            //1)출하지시 조회

            HeaderModels = _dlvConfirm2Pocket.SelectDlvPopOrdModel(_dlvConfirm2Args.DlvConfirm2ModelArgs);
            dlvPopOrdModelBindingSource.DataSource = HeaderModels;

            //2) 출하지시 품번 조회
            DetailModel = _dlvConfirm2Pocket.SelectDlvPopOrdDetailModel(_dlvConfirm2Args.DlvConfirm2ModelArgs);
            dlvPopOrdDetailModelBindingSource.DataSource = DetailModel;
            
            gridView2.BestFitColumns();

            //2022.03.18 언어변환
            LangConvert();

            //2022.04.25 그리드뷰 인디케이터 추가
            strapGridControl1.InitDefaultSet();
            strapGridControl2.InitDefaultSet();
            strapGridControl3.InitDefaultSet();
            gridView1.IndicatorWidth = 40;
            gridView2.IndicatorWidth = 40;
            gridView3.IndicatorWidth = 40;



        }

        private void LangConvert()
        {
            List<LayoutControlGroup> groups = new List<LayoutControlGroup>();
            groups.Add(layoutControlGroup2);
            groups.Add(layoutControlGroup3);
            groups.Add(layoutControlGroup1);
            groups.Add(layoutControlGroup6);

            foreach (LayoutControlGroup group in groups)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, group.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    group.Text = trLang;
                }
            }
            List<LayoutControlItem> items = new List<LayoutControlItem>();
            items.Add(ItemForBP_CD);
            items.Add(ItemForDOH_NO);
            items.Add(ItemForDOH_STATUS);
            items.Add(ItemForORDER_SEQ);
            items.Add(ItemForREMARK);
            foreach (LayoutControlItem item in items)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, item.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Text = trLang;
                }
            }
            List<GridColumn> columns = new List<GridColumn>();
            columns= gridView1.Columns.ToList();
            foreach (GridColumn column in columns)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, column.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    column.Caption = trLang;
                }
            }
            columns = gridView2.Columns.ToList();
            foreach (GridColumn column in columns)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, column.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    column.Caption = trLang;
                }
            }
            columns = gridView3.Columns.ToList();
            foreach (GridColumn column in columns)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, column.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    column.Caption = trLang;
                }
            }


        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView view = sender as GridView;
            var model = (DlvPopOrdDetailModel)view.GetRow(e.RowHandle);

            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Doh_No = model.DOH_NO;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Item_cd = model.ITEM_CD;

            List<DlvPopOrdDetailLpackModel> models
                = _dlvConfirm2Pocket.SelectDlvPopOrdDetailLpackModel(_dlvConfirm2Args.DlvConfirm2ModelArgs);

            dlvPopOrdDetailLpackModelBindingSource.DataSource = models;
            gridView1.BestFitColumns();

            dlvPopOrdDetailMpackModelBindingSource.DataSource = null;
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            GridView view = sender as GridView;
            var model = (DlvPopOrdDetailLpackModel)view.GetRow(e.RowHandle);

            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Pack_Date = model.PACK_DATE;
            _dlvConfirm2Args.DlvConfirm2ModelArgs.Select_Ship_Date = model.SHIP_DATE;

            List<DlvPopOrdDetailMpackModel> models
                = _dlvConfirm2Pocket.SelectDlvPopOrdDetailMpackModel(_dlvConfirm2Args.DlvConfirm2ModelArgs);

            dlvPopOrdDetailMpackModelBindingSource.DataSource = models;
            gridView3.BestFitColumns();
        }
    }
}
