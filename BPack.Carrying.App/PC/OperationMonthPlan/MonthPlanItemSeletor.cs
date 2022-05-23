using BPack.Common.LoginInfo;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.OperationMonthPlan;
using BPack.Pocket.App.PC.OperationMonthPlan;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.OperationMonthPlan
{
    public partial class MonthPlanItemSeletor : DevExpress.XtraEditors.XtraForm
    {
        private BPack.CommonMes.Controls.ItemMaster.ItemMasterModelArgs _itemMasterModelArgs;

        private BPack.CommonMes.Controls.ItemMaster.ItemMasterPocket _itemMasterPocket;
        //private string _selectedItemCode;
        private ItemSelectedEventArgs itemSelectedEventArgs;
        OperationMonthPlanPocket _monthPlanPocket;

        string trLang;

        public MonthPlanItemSeletor(string Compcd, string PlantCd, OperationMonthPlanPocket monthPlanPocket
            ,DateTime dateTime
            )
        {
            InitializeComponent();
            _monthPlanPocket = monthPlanPocket;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            _itemMasterModelArgs = new CommonMes.Controls.ItemMaster.ItemMasterModelArgs();
            _itemMasterPocket = new CommonMes.Controls.ItemMaster.ItemMasterPocket();
            itemSelectedEventArgs = new ItemSelectedEventArgs();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.Editable = false;
            strapGridControl1.InitDefaultSet();
            StrapEdit_FromModelAnnotation sefma = new StrapEdit_FromModelAnnotation();
            sefma.SetGridColumn(typeof(ItemMasterModel), gridView1);
            //strapButton1.Click += StrapButton1_Click;
            //strapButton2.Click += StrapButton2_Click;
            //strapButton3.Click += StrapButton3_Click;
            this.KeyPreview = true;
            this.KeyDown += ItemMasterSelector_KeyDown;
            gridView1.KeyDown += GridView1_KeyDown;
            gridView1.Click += GridView1_Click;
            gridView1.DoubleClick += GridView1_DoubleClick;

            SetCompCode(Compcd);
            SetPlantCode(PlantCd);
            strapDateEdit1.DateTime = dateTime;

            //2022.03.22 언어변환
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
            items.Add(layoutControlItem3);
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
            buttons.Add(strapButton4);
            buttons.Add(strapButton5);
            foreach (StrapButton item in buttons)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, item.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Text = trLang;
                }
            }
            //List<GridColumn> columns = new List<GridColumn>();

            GridColumnCollection columns = gridView2.Columns;
            foreach (GridColumn column in columns)
            {
                var customAttributes =
               typeof(MonthItemModel).GetProperty(column.FieldName).CustomAttributes.ToList();

                if (customAttributes.Count > 0)
                {
                    var displayNameAttribute
                        = customAttributes.FirstOrDefault(
                        aa => aa.AttributeType.Name.Equals("DisplayAttribute"));
                    if (displayNameAttribute != null)
                    {
                        trLang
                            = LanguagePack.GetTransWord(UserInfo.Sys_Language
                            , displayNameAttribute.NamedArguments[0].TypedValue.ToString().Replace("\"", ""));
                        if (!string.IsNullOrEmpty(trLang))
                        {
                            column.Caption = trLang;
                        }
                    }

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

        /// <summary>
        /// 취소버튼 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrapButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// 품목선택 버튼 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrapButton2_Click(object sender, EventArgs e)
        {
            SelectComplate();
        }

        /// <summary>
        /// 조회버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrapButton1_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }

        public void DataRefresh()
        {
            _itemMasterModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _itemMasterModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _itemMasterModelArgs.Select_Main_Item_Type = strapLookUpEdit1.EditValue?.ToString();
            _itemMasterModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit4.EditValue?.ToString();
            //_itemMasterModelArgs.Select_Main_Item_Gr_2 = strapLookUpEdit4.EditValue?.ToString();
            itemMasterModelBindingSource.DataSource = _itemMasterPocket.SelectItemMasterModels(_itemMasterModelArgs);
            gridView1.BestFitColumns();
            gridView1.Focus();
        }

        public void DataClear()
        {
            itemMasterModelBindingSource.Clear();
        }

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    //base.OnClosing(e);
        //    e.Cancel = true;
        //    this.DialogResult = DialogResult.Cancel;
        //    this.Hide();
        //}

        //ESC로 닫히도록
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public void SetCompCode(string compCode)
        {
            _itemMasterModelArgs.Select_Comp_Cd = compCode;
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "MasterDataControls.Item.ItemProduct", new
            { COMP_CD = _itemMasterModelArgs.Select_Comp_Cd }, "품목유형코드", "품목유형명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "MasterDataControls.Item.ItemType", new { COMP_CD = _itemMasterModelArgs.Select_Comp_Cd }, "품목형태코드", "품목형태명");
            LookUpEditHelper.SetGridColumnCommonCode(colBASE_UNIT, _itemMasterModelArgs.Select_Comp_Cd, "UNIT");
            LookUpEditHelper.SetGridColumnCommonCode(colWEIGHT_UNIT, _itemMasterModelArgs.Select_Comp_Cd, "UNIT");

            strapLookUpEdit1.EditValue = "003";
            //strapLookUpEdit1.Enabled = false;
            //strapLookUpEdit1.ReadOnly = true;
        }

        public void SetPlantCode(string plantCode)
        {
            _itemMasterModelArgs.Select_Plant_Cd = plantCode;

            //LookUpEditHelper.SetByQuery(strapLookUpEdit3, "MasterDataControls.Item.ItemGr1", new
            //{
            //    COMP_CD = _itemMasterModelArgs.Select_Comp_Cd,
            //    PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
            //}, "품목그룹코드", "품목그룹명");
            LookUpEditHelper.SetByQuery(strapLookUpEdit4, "MasterDataControls.Item.ItemGr1", new
            {
                COMP_CD = _itemMasterModelArgs.Select_Comp_Cd,
                PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
            }, "Code", "Name");


            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "MasterDataControls.Item.ItemGr1", new
            {
                COMP_CD = _itemMasterModelArgs.Select_Comp_Cd,
                PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
            }, "Code", "Name");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "MasterDataControls.Item.ItemGr2", new
            {
                COMP_CD = _itemMasterModelArgs.Select_Comp_Cd,
                PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
            }, "Code", "Name");


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
            ItemMasterModel model = (ItemMasterModel)strapGridControl1.SelectedModel;

            BPack.Model.App.PC.OperationMonthPlan.MonthItemModel monthItem
                = new Model.App.PC.OperationMonthPlan.MonthItemModel()
                {
                    CREATE_DTTM = DateTime.Now
                 ,
                    MODIFY_DTTM = DateTime.Now
                 ,
                    CREATE_USER_ID = UserInfo.UserID
                 ,
                    MODIFY_USER_ID = UserInfo.UserID
                 ,
                    LANG_CODE = UserInfo.Sys_Language
                 ,
                    COMP_CD = _itemMasterModelArgs.Select_Comp_Cd
                 ,
                    PLANT_CD = _itemMasterModelArgs.Select_Plant_Cd
                 ,
                    ITEM_CD = model.ITEM_CD
                 ,
                    ITEM_GR_1 = model.ITEM_GR_1
                 ,
                    ITEM_NM = model.ITEM_NM
                 ,
                    YEAR_CD = strapDateEdit1.DateTime.ToString("yyyy")
                };
            List<MonthItemModel> monthItemModels = GetGridMonthModel();
            if (monthItemModels
                    .Exists(v => v.COMP_CD == monthItem.COMP_CD
                             && v.PLANT_CD == monthItem.PLANT_CD
                                && v.ITEM_CD == monthItem.ITEM_CD
                ) == false
                )
            {
                bindingSource1.Add(monthItem);
            }
        }

        private List<MonthItemModel> GetGridMonthModel()
        {
            List<MonthItemModel> models = new List<MonthItemModel>();
            int rowHandle = 0;
            while (gridView2.IsValidRowHandle(rowHandle))
            {
                models.Add((MonthItemModel)gridView2.GetRow(rowHandle));
                rowHandle++;
            }
            return models;
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

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (bindingSource1.Count > 0)
            {
                strapDateEdit1.Enabled = false;
            }
            else
            {
                strapDateEdit1.Enabled = true;
            }
        }

        private void strapButton5_Click(object sender, EventArgs e)
        {
            bindingSource1.Remove(bindingSource1.Current);
        }

        /// <summary>
        /// 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strapButton4_Click(object sender, EventArgs e)
        {

            List<MonthItemModel> models = new List<MonthItemModel>();

            foreach (var model in bindingSource1.List)
            {
                models.Add((MonthItemModel)model);
            }

            _monthPlanPocket.SaveMonthItemModel(models);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
