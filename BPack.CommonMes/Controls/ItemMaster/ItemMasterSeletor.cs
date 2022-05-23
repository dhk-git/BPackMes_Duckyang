using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Strap.MasterDataControls.MD;
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

namespace BPack.CommonMes.Controls.ItemMaster
{
    public partial class ItemMasterSeletor : DevExpress.XtraEditors.XtraForm
    {
        private ItemMasterModelArgs _itemMasterModelArgs;
        private ItemMasterPocket _itemMasterPocket;
        private string _selectedItemCode;
        private ItemMasterSelectedEventArgs _itemMasterSelectedEventArgs;

        string trLang;

        public event EventHandler<ItemMasterSelectedEventArgs> SelectedComplate;
        public ItemMasterSeletor()
        {
            InitializeComponent();

            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            _itemMasterModelArgs = new ItemMasterModelArgs();
            _itemMasterPocket = new ItemMasterPocket();
            _itemMasterSelectedEventArgs = new ItemMasterSelectedEventArgs();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.Editable = false;
            strapGridControl1.InitDefaultSet();
            StrapEdit_FromModelAnnotation sefma = new StrapEdit_FromModelAnnotation();
            sefma.SetGridColumn(typeof(ItemMasterModel), gridView1);
            strapButton1.Click += StrapButton1_Click;
            strapButton2.Click += StrapButton2_Click;
            strapButton3.Click += StrapButton3_Click;
            this.KeyPreview = true;
            this.KeyDown += ItemMasterSelector_KeyDown;
            gridView1.KeyDown += GridView1_KeyDown;
            gridView1.Click += GridView1_Click;
            gridView1.DoubleClick += GridView1_DoubleClick;


            //2022.03.18 언어변환
            LangConvert();
        }

        private void LangConvert()
        {
            List<LayoutControlGroup> groups = new List<LayoutControlGroup>();
            groups.Add(layoutControlGroup1);
            groups.Add(layoutControlGroup2);
            foreach (LayoutControlGroup group in groups)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, group.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    group.Text = trLang;
                }
            }
            List<LayoutControlItem> items = new List<LayoutControlItem>();
            items.Add(layoutControlItem1);
            items.Add(layoutControlItem4);
            items.Add(layoutControlItem5);
            items.Add(layoutControlItem6);
            foreach (LayoutControlItem item in items)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, item.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Text = trLang;
                }
            }
            List<StrapButton> buttons = new List<StrapButton>();
            buttons.Add(strapButton1);
            buttons.Add(strapButton2);
            buttons.Add(strapButton3);
            foreach (StrapButton btn in buttons)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, btn.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    btn.Text = trLang;
                }
            }

        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectComplate();
        }

        private void GridView1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = e as MouseEventArgs;
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo gridHitInfo = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).CalcHitInfo(mouseEventArgs.Location);
            if (gridHitInfo.InRow)
            {
                strapGridControl1.OnGridSelectedRowFormatChange(sender, e); //하위폼 데이터 변경 체크후 롤백으로 인해 이쪽으로 옮김 20191031
            }
        }

        private void GridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strapGridControl1.OnGridSelectedRowFormatChange(sender, e); //하위폼 데이터 변경 체크후 롤백으로 인해 이쪽으로 옮김 20191031
            }
        }
        
        //취소버튼
        private void StrapButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //품목선택 버튼
        private void StrapButton2_Click(object sender, EventArgs e)
        {
            SelectComplate();
        }

        //조회버튼
        private void StrapButton1_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }

        public void DataRefresh()
        {
            _itemMasterModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _itemMasterModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _itemMasterModelArgs.Select_Main_Item_Type = strapLookUpEdit1.EditValue?.ToString();
          //  _itemMasterModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit3.EditValue?.ToString();
            _itemMasterModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit4.EditValue?.ToString();
            itemMasterModelBindingSource.DataSource = _itemMasterPocket.SelectItemMasterModels(_itemMasterModelArgs);
            gridView1.BestFitColumns();
            gridView1.Focus();
        }

        public void DataClear()
        {
            itemMasterModelBindingSource.Clear();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //base.OnClosing(e);
            e.Cancel = true;
            this.Hide();
        }
        //ESC로 닫히도록
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public void SetCompCode(string compCode)
        {
            //2022.03.18 정수교 언어변환
            string codeName01 = "품목유형코드";
            
            trLang= LanguagePack.GetTransWord(UserInfo.Sys_Language, codeName01);
            if (!string.IsNullOrEmpty(trLang))
            {
                codeName01 = trLang;
            }
            string CodeValueName01 = "품목유형명";
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, CodeValueName01);
            if (!string.IsNullOrEmpty(trLang))
            {
                CodeValueName01 = trLang;
            }

            string codeName02 = "품목형태코드";
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, codeName02);
            if (!string.IsNullOrEmpty(trLang))
            {
                codeName02 = trLang;
            }
            string CodeValueName02 = "품목유형명";
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, CodeValueName02);
            if (!string.IsNullOrEmpty(trLang))
            {
                CodeValueName02 = trLang;
            }

            _itemMasterModelArgs.Select_Comp_Cd = compCode;
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "MasterDataControls.Item.ItemType", new
            { COMP_CD = _itemMasterModelArgs.Select_Comp_Cd }, codeName01, CodeValueName01); //품목유형코드/품목유형명
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD
                , "MasterDataControls.Item.ItemType", new { COMP_CD = _itemMasterModelArgs.Select_Comp_Cd }
                , codeName02, CodeValueName02);//품목형태코드/품목유형명
            LookUpEditHelper.SetGridColumnCommonCode(colBASE_UNIT, _itemMasterModelArgs.Select_Comp_Cd, "UNIT");
            LookUpEditHelper.SetGridColumnCommonCode(colWEIGHT_UNIT, _itemMasterModelArgs.Select_Comp_Cd, "UNIT");
        }

        public void SetPlantCode(string plantCode)
        {
            _itemMasterModelArgs.Select_Plant_Cd = plantCode;

            //LookUpEditHelper.SetByQuery(strapLookUpEdit3, "MasterDataControls.Item.ItemGr1", new
            //{
            //    COMP_CD = _itemMasterModelArgs.Select_Comp_Cd,
            //    PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
            //}, "품목그룹코드", "품목그룹명");

            //2022.03.18 정수교 언어변환
            string codeName01 = "품목그룹코드";

            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, codeName01);
            if (!string.IsNullOrEmpty(trLang))
            {
                codeName01 = trLang;
            }
            string CodeValueName01 = "품목그룹명";
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, CodeValueName01);
            if (!string.IsNullOrEmpty(trLang))
            {
                CodeValueName01 = trLang;
            }


            LookUpEditHelper.SetByQuery(strapLookUpEdit4, "MasterDataControls.Item.ItemGr1", new
            {
                COMP_CD = _itemMasterModelArgs.Select_Comp_Cd,
                PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
            }, codeName01, CodeValueName01); // 품목그룹코드/품목그룹명
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "MasterDataControls.Item.ItemGr1", new
            {
                COMP_CD = _itemMasterModelArgs.Select_Comp_Cd,
                PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
            }, codeName01, CodeValueName01); // 품목그룹코드/품목그룹명
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "MasterDataControls.Item.ItemGr2", new
            {
                COMP_CD = _itemMasterModelArgs.Select_Comp_Cd,
                PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
            }, codeName01, CodeValueName01); // 품목그룹코드/품목그룹명


        }
        //ItemInfo 를 반환
        public ItemMasterModel GetItemMasterModel(string itemCode)
        {
            _itemMasterModelArgs.Select_Main_Item_Cd = itemCode;
            _itemMasterModelArgs.Select_Item_Cd = itemCode;
            return _itemMasterPocket.SelectItemMasterModel(_itemMasterModelArgs);
        }

        private void SelectComplate()
        {
            if (((ItemMasterModel)strapGridControl1.SelectedModel)?.ITEM_CD == null)
            {
                StrapMessageBox.Show("A001", 50, MessageBoxButtons.OK);
                return;
            }
            _selectedItemCode = ((ItemMasterModel)strapGridControl1.SelectedModel).ITEM_CD;
            _itemMasterSelectedEventArgs.SeletedItemMasterModel = (ItemMasterModel)strapGridControl1.SelectedModel;
            _itemMasterSelectedEventArgs.SelectedItemCode = _selectedItemCode;
            SelectedComplate?.Invoke(this, _itemMasterSelectedEventArgs);
            this.Hide();
        }


        private void ItemMasterSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DataRefresh();
            }
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                SelectComplate();
            }
        }

    }
}
