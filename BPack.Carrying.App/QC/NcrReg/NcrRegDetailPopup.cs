using BPack.Common.Config;
using BPack.Common.LoginInfo;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrReg;
using BPack.Pocket.App.QC.NcrReg;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraLayout;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.NcrReg
{
    public partial class NcrRegDetailPopup : StrapForm
    {
        private NcrRegArgs _ncrRegArgs;
        private NcrRegPocket _regPocket;

        private ItemMasterSeletor _itemMasterSelector;

        string trLang;

        public NcrRegDetailPopup()
        {
            InitializeComponent();
        }
        public NcrRegDetailPopup(NcrRegArgs ncrRegArgs, NcrRegPocket regPocket) : this()
        {
            this._ncrRegArgs = ncrRegArgs;
            this._regPocket = regPocket;
            itemMasterButtonEdit1.InitStrap();
            itemMasterButtonEdit1.InitCompCode(_ncrRegArgs.NcrRegModelArgs.Comp_cd);
            itemMasterButtonEdit1.InitPlantCode(_ncrRegArgs.NcrRegModelArgs.Plant_cd);
            itemMasterButtonEdit1.SelectedComplate += ItemMasterButtonEdit1_SelectedComplate1;

            _itemMasterSelector = new ItemMasterSeletor();
            _itemMasterSelector.SetCompCode(_ncrRegArgs.NcrRegModelArgs.Comp_cd);
            _itemMasterSelector.SetPlantCode(_ncrRegArgs.NcrRegModelArgs.Plant_cd);

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
            items.Add(layoutControlItem2);
            items.Add(layoutControlItem1);
            items.Add(layoutControlItem3);
            items.Add(layoutControlItem4);
            foreach (LayoutControlItem item in items)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, item.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Text = trLang;
                }
            }
            List<TreeListColumn> columns = new List<TreeListColumn>();
            columns=strapTreeList1.Columns.ToList();
            foreach (TreeListColumn column in columns)
            {
                var customAttributes =
                typeof(NcrRegDetailBomModel).GetProperty(column.FieldName).CustomAttributes.ToList();

                if (customAttributes.Count > 0)
                {
                    var displayNameAttribute 
                        =customAttributes.FirstOrDefault(
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
                //column.FieldName
            }
        }

        private void ItemMasterButtonEdit1_SelectedComplate1(object sender, ItemMasterSelectedEventArgs e)
        {
            SetBomNo(itemMasterButtonEdit1.EditValue?.ToString());
            itemMasterButtonEdit1.ItemMasterModel = null;
        }

        private void itemMasterButtonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (itemMasterButtonEdit1.ItemMasterModel != null)
            {
                strapTextEdit1.EditValue = itemMasterButtonEdit1.ItemMasterModel.ITEM_NM;
                strapTextEdit2.EditValue = itemMasterButtonEdit1.ItemMasterModel.ITEM_GR_1;
            }
            else
            {
                ItemMasterModel model = _itemMasterSelector.GetItemMasterModel(itemMasterButtonEdit1.EditValue?.ToString());
                if (model != null)
                {
                    strapTextEdit1.EditValue = model.ITEM_NM;
                    strapTextEdit2.EditValue = model.ITEM_GR_1;
                }
                else
                {
                    strapTextEdit1.EditValue = "";
                    strapTextEdit2.EditValue = "";
                }
            }
            if (!string.IsNullOrEmpty(strapTextEdit1.EditValue?.ToString()))
            {
                //기준 일자 바인딩
                SetBomNo(itemMasterButtonEdit1.EditValue.ToString());
            }
            else
            {
                strapLookUpEdit1.Properties.DataSource = null;
            }



        }

        private void SetBomNo(string _item_cd)
        {
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "MD.ItmBom.LookUpEdit.Select"
                , new
                {
                    COMP_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd
                    ,
                    PLANT_CD = _ncrRegArgs.NcrRegModelArgs.Plant_cd
                    ,
                    ITEM_CD = _item_cd
                }
                , new Dictionary<string, string>{
                    { "BOM_NO", "BOM_NO" }
                    ,{ "VALID_FROM_DT", "Standard Date" }
                    ,{ "IS_PHANTOM", "PHANTOM" }
                    ,{ "REMARK", "비고" }
                }
                , "BOM_NO"
                , "VALID_FROM_DT"
                );
            strapLookUpEdit1.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
        }


        private void strapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            _ncrRegArgs.NcrRegModelArgs.ITEM_CD = itemMasterButtonEdit1.EditValue?.ToString();
            _ncrRegArgs.NcrRegModelArgs.BOM_NO = strapLookUpEdit1.EditValue?.ToString();

            var model = _regPocket.SelectItemBomModels(_ncrRegArgs.NcrRegModelArgs);

            try
            {
                strapTreeList1.DataSource = model;
                strapTreeList1.ExpandAll();
                strapTreeList1.BestFitColumns();
            }
            catch (Exception)
            {
                strapTreeList1.DataSource = null;
                //strapTreeList1.ExpandAll();
                strapTreeList1.BestFitColumns();
            }
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType"
                , new
                {
                    COMP_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd
                    ,
                    PLANT_CD = _ncrRegArgs.NcrRegModelArgs.Plant_cd
                }
                , "Code", "Name");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode"
                , new
                {
                    COMP_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd
                    ,
                    PLANT_CD = _ncrRegArgs.NcrRegModelArgs.Plant_cd
                    ,
                    ITEM_GR_CLS = "ITEM_GR_1"
                }
                , "Code", "Name");
            LookUpEditHelper.SetTreeGridColumnCommonCode(colDEFECT_CD, _ncrRegArgs.NcrRegModelArgs.Comp_cd, "DEFECT_CD");
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            var model = ((List<NcrRegDetailBomModel>)strapTreeList1.DataSource);

            var ChnagedModel = model.Where(v => v.DEFECT_QTY > 0);
            var cnt_01 = ChnagedModel.Count();
            var cnt_02 = ChnagedModel.Where(v => string.IsNullOrEmpty(v.DEFECT_CD) == true).Count();

            if (cnt_01 == 0)
            {
                //선택된 건이 없습니다.
                StrapMessageBox.Show("A002", 12);
                return;
            }
            if (cnt_02 > 0)
            {
                //불량유형 선택 안한게 있음.
                StrapMessageBox.Show("A002", 19);
                return;
            }
            else
            {
                //저장하시겠습니까?
                if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //List<NcrRegDetailModel>
                    SaveNcrRegDetailModel(ChnagedModel);
                }

            }
        }

        private void SaveNcrRegDetailModel(IEnumerable<NcrRegDetailBomModel> chnagedModel)
        {
            List<NcrRegDetailModel> models = new List<NcrRegDetailModel>();

            foreach (NcrRegDetailBomModel model in chnagedModel)
            {
                models.Add(new NcrRegDetailModel()
                {
                    CREATE_DTTM = DateTime.Now
                     ,
                    CREATE_USER_ID = UserInfo.UserID
                     ,
                    MODIFY_DTTM = DateTime.Now
                     ,
                    MODIFY_USER_ID = UserInfo.UserID
                     ,
                    LANG_CODE = UserInfo.Sys_Language
                     ,
                    RowState = Common.Model.RowState.Added
                     ,
                    COMP_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd
                    ,
                    PLANT_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Plant_Cd
                    ,
                    NCH_NO = _ncrRegArgs.NcrRegModelArgs.NCH_NO_KEY
                    ,
                    ITEM_CD = model.ITEM_CD
                    ,
                    DEFECT_CD = model.DEFECT_CD
                    ,
                    DEFECT_QTY = model.DEFECT_QTY
                });
            }
            _regPocket.SaveNcrRegDetailModels(models);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void strapButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
