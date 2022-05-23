using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Pocket.App.PC.WoeRsPivot;
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

namespace BPack.Carrying.App.PC.WoeRsPivot
{
    public partial class WoeRsPivotMain : StrapMainForm
    {
        private WoeRsPivotArgs _woeRsPivotArgs;
        private WoeRsPivotPocket _woeRsPivotPocket;
        private RsPivotList _rsPivotList;
        private RsBatchList _rsBatchList;

        string trLang;

        public WoeRsPivotMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _woeRsPivotArgs = new WoeRsPivotArgs();
            _woeRsPivotPocket = new WoeRsPivotPocket();
            _rsPivotList = new RsPivotList(_woeRsPivotArgs, _woeRsPivotPocket);
            AddSubForm(this, _rsPivotList, layoutControlGroup2);
            _rsBatchList = new RsBatchList(_woeRsPivotArgs, _woeRsPivotPocket);
            AddSubForm(this, _rsBatchList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _woeRsPivotArgs,
                InitlistForm = _rsPivotList,
                StrapLayout = strapLayout1,
                //IsAutoDataRefreshOnShown=false
            });
            InitRibbonButtons(true, false, false, false);
            ctl_Start_dt.EditValue = DateTime.Now.AddDays(-7);
            ctl_End_dt.EditValue = DateTime.Now;

            
            LookUpEditHelper.SetCompCode(sleCompCd);
            sleCompCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Comp_CD = sleCompCd.EditValue?.ToString();
                LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);

                LookUpEditHelper.SetItemType(ctl_Item_Type, Common.LoginInfo.UserInfo.CompCode, true, true, false);
            };


            slePlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Plant_CD = slePlantCd.EditValue?.ToString();
                LookUpEditHelper.SetWorkCenter(ctl_Wc_cd
                    , _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Comp_CD
                    , _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Plant_CD
                    ,isTotalRow:true);
                LookUpEditHelper.SetByQuery(ctl_Shift_Group_cd
                    , "MD.SHIH.Select"
                    , new
                    {
                        COMP_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Comp_CD,
                        PLANT_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Plant_CD,
                    }
                    , "Code", "Name", isFirstSelect: true);


                LookUpEditHelper.SetByQuery(ctl_Item_gr_1
                                    , "ItemGroup"
                                    , new
                                    {
                                        COMP_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Comp_CD,
                                        PLANT_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Plant_CD,
                                        ITEM_GR_CLS= "ITEM_GR_1"
                                    }
                                    , "Code", "Name",isTotalRow:true);

            };
            ctl_Shift_Group_cd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _woeRsPivotArgs.WoeRsPivotModelArgs.SHIFT_GROUP_CD = ctl_Shift_Group_cd.EditValue?.ToString();
                LookUpEditHelper.SetByQuery(ctl_Shift_cd
                , "MD.SHID.Select"
                , new
                {
                    COMP_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Comp_CD,
                    PLANT_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Plant_CD,
                    SHIFT_GROUP_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.SHIFT_GROUP_CD
                }
                , "Code", "Name", isTotalRow: true);
            };
            ctl_Wc_cd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _woeRsPivotArgs.WoeRsPivotModelArgs.WC_CD = ctl_Wc_cd.EditValue?.ToString();
            };

            sleCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;
            _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Comp_CD = sleCompCd.EditValue?.ToString();
            slePlantCd.EditValue = Common.LoginInfo.UserInfo.PlantCode;
            _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Plant_CD = slePlantCd.EditValue?.ToString();


            //2022.03.17 정수교 언어변환 
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup2.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup2.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup3.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup3.Text = trLang;
            }
        }

        private void Ctl_Shift_Group_cd_EditValueChanged(object sender, EventArgs e)
        {
            _woeRsPivotArgs.WoeRsPivotModelArgs.SHIFT_GROUP_CD = ctl_Shift_Group_cd.EditValue?.ToString();
            LookUpEditHelper.SetByQuery(ctl_Shift_cd
            , "MD.SHID.Select"
            , new
            {
                COMP_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Comp_CD,
                PLANT_CD = _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Plant_CD,
                SHIFT_GROUP_CD= _woeRsPivotArgs.WoeRsPivotModelArgs.SHIFT_GROUP_CD
            }
            , "Code", "Name",isTotalRow:true);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Comp_CD = sleCompCd.EditValue?.ToString();
            _woeRsPivotArgs.WoeRsPivotModelArgs.Select_Main_Plant_CD = slePlantCd.EditValue?.ToString();
            _woeRsPivotArgs.WoeRsPivotModelArgs.START_DT = ctl_Start_dt.DateTime;
            _woeRsPivotArgs.WoeRsPivotModelArgs.END_DT = ctl_End_dt.DateTime;
            _woeRsPivotArgs.WoeRsPivotModelArgs.WC_CD = ctl_Wc_cd.EditValue?.ToString();
            _woeRsPivotArgs.WoeRsPivotModelArgs.SHIFT_GROUP_CD = ctl_Shift_Group_cd.EditValue?.ToString();
            _woeRsPivotArgs.WoeRsPivotModelArgs.SHIFT_CD = ctl_Shift_cd.EditValue?.ToString();
            _woeRsPivotArgs.WoeRsPivotModelArgs.ITEM_GR_1 = ctl_Item_gr_1.EditValue?.ToString();
            _woeRsPivotArgs.WoeRsPivotModelArgs.ITEM_TYPE = ctl_Item_Type.EditValue?.ToString();
            _woeRsPivotArgs.WoeRsPivotModelArgs.ITEM_CD = ctl_Item_cd.EditValue?.ToString();
            _woeRsPivotArgs.WoeRsPivotModelArgs.ITEM_NM = ctl_Item_nm.EditValue?.ToString();

            _rsPivotList.DataRefresh(_woeRsPivotArgs);
            _rsBatchList.DataRefresh(_woeRsPivotArgs);


        }

       
    }
}
