using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.OperationWeekPlan;
using BPack.Pocket.App.PC.OperationWeekPlan;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Columns;
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

namespace BPack.Carrying.App.PC.OperationWeekPlan
{
    public partial class WeekPlanItemSelector : DevExpress.XtraEditors.XtraForm
    {
        private OperationWeekPlanModelArgs _operationWeekPlanModelArgs;
        private readonly OperationWeekPlanPocket _weekPlanPocket;

        string trLang;

        public WeekPlanItemSelector(OperationWeekPlanModelArgs operationWeekPlanModelArgs, OperationWeekPlanPocket weekPlanPocket)
        {
            InitializeComponent();
            this._operationWeekPlanModelArgs = operationWeekPlanModelArgs;
            this._weekPlanPocket = weekPlanPocket;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.Editable = false;
            strapGridControl1.InitDefaultSet();
            StrapEdit_FromModelAnnotation sefma = new StrapEdit_FromModelAnnotation();
            sefma.SetGridColumn(typeof(WeekItemMasterModel), gridView1);
            this.KeyPreview = true;
            this.KeyDown += ItemMasterSelector_KeyDown;
            gridView1.KeyDown += GridView1_KeyDown;
            gridView1.Click += GridView1_Click;
            gridView1.DoubleClick += GridView1_DoubleClick;

            SetCompCode(operationWeekPlanModelArgs.Select_Main_Comp_Cd);

            strapDateEdit1.EditValue = operationWeekPlanModelArgs.Select_Main_Plan_Start_dt;
            _operationWeekPlanModelArgs.Year_cd = strapDateEdit1.DateTime.ToString("yyyy");

            DataRefresh();

            //2022.03.22 언어변환
            LangConvert();
        }

        private void LangConvert()
        {
            List<LayoutControlGroup> groups = new List<LayoutControlGroup>();
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
            GridColumnCollection columns = gridView2.Columns;
            foreach (GridColumn column in columns)
            {
                var customAttributes =
               typeof(WeekItemModel).GetProperty(column.FieldName).CustomAttributes.ToList();

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
            _operationWeekPlanModelArgs.Year_cd = strapDateEdit1.DateTime.ToString("yyyy");
            itemMasterModelBindingSource.DataSource = _weekPlanPocket.SelectItemMasterModels(_operationWeekPlanModelArgs);
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
            LookUpEditHelper
                .SetGridColumnByQuery(
                    colITEM_TYPE_CD
                    , "MasterDataControls.Item.ItemType"
                    , new { COMP_CD = _operationWeekPlanModelArgs.Select_Main_Comp_Cd }
                    , "Code", "Name");
            LookUpEditHelper
                .SetGridColumnCommonCode(
                    colBASE_UNIT
                    , _operationWeekPlanModelArgs.Select_Main_Comp_Cd, "UNIT");
            //LookUpEditHelper
            //    .SetGridColumnCommonCode(
            //    colwe
            //    , _operationWeekPlanModelArgs.Select_Main_Comp_Cd, "UNIT");
        }

        private void SelectComplate()
        {
            if (((WeekItemMasterModel)strapGridControl1.SelectedModel)?.ITEM_CD == null)
            {
                StrapMessageBox.Show("A001", 50, MessageBoxButtons.OK);
                return;
            }
            WeekItemMasterModel model = (WeekItemMasterModel)strapGridControl1.SelectedModel;

            WeekItemModel WeekItem
                = new WeekItemModel()
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
                    COMP_CD = _operationWeekPlanModelArgs.Select_Main_Comp_Cd
                         ,
                    PLANT_CD = _operationWeekPlanModelArgs.Select_Main_Plant_Cd
                         ,
                    ITEM_CD = model.ITEM_CD
                         ,
                    ITEM_GR_1 = model.ITEM_GR_1
                         ,
                    ITEM_NM = model.ITEM_NM
                         ,
                    YEAR_CD = strapDateEdit1.DateTime.ToString("yyyy")
                };

            //2022.02.,08 체크로직 추가
            List<WeekItemModel> WeekItemModels = GetGridMonthModel();
            if (WeekItemModels
                    .Exists(v => v.COMP_CD == WeekItem.COMP_CD
                             && v.PLANT_CD == WeekItem.PLANT_CD
                                && v.ITEM_CD == WeekItem.ITEM_CD
                ) == false
                )
            {
                bindingSource1.Add(WeekItem);
            }

        }

        private List<WeekItemModel> GetGridMonthModel()
        {
            List<WeekItemModel> models = new List<WeekItemModel>();
            int rowHandle = 0;
            while (gridView2.IsValidRowHandle(rowHandle))
            {
                models.Add((WeekItemModel)gridView2.GetRow(rowHandle));
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

            List<WeekItemModel> models = new List<WeekItemModel>();

            foreach (var model in bindingSource1.List)
            {
                models.Add((WeekItemModel)model);
            }

            _weekPlanPocket.SaveWeekItemModel(models);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
