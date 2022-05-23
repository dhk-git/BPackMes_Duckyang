using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Pocket.App.PC.OperationMonthPlan;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
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

namespace BPack.Carrying.App.PC.OperationMonthPlan
{
    public partial class MonthMain : StrapMainForm
    {
        OperationMonthPlanArgs _monthPlanArgs;
        OperationMonthPlanPocket _monthPlanPocket;
        MonthList _monthList;
        public MonthMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _monthPlanArgs = new OperationMonthPlanArgs();
            _monthPlanPocket = new OperationMonthPlanPocket();
            _monthList = new MonthList(_monthPlanArgs, _monthPlanPocket);

            AddSubForm(this,_monthList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _monthPlanArgs,
                InitlistForm = _monthList,
                //IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, save: true);

            LookUpEditHelper.SetCompCode(ctl_ComCd);
            ctl_ComCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
                LookUpEditHelper.SetPlantCode(ctl_PlantCd, new { COMP_CD = ctl_ComCd.EditValue?.ToString() }, isFirstSelect: true);
                _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
            };
            strapButtonEdit_ItemMaster1.InitStrap();
            ctl_PlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
                _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
                _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plant_Cd = ctl_PlantCd.EditValue?.ToString();

                LookUpEditHelper.SetByQuery(ctl_ItemGr, "MasterDataControls.Item.ItemGr1"
                    , new { COMP_CD= _monthPlanArgs .OperationMonthPlanModelArgs.Select_Main_Comp_Cd
                            ,PLANT_CD= _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plant_Cd
                    }
                    , "Code", "Name");
                strapButtonEdit_ItemMaster1.InitPlantCode(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plant_Cd);
            };

            ctl_ItemGr.EditValueChanged += (object sender, EventArgs e) =>
            {
                _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Item_Group_cd = ctl_ItemGr.EditValue?.ToString();
            };
            ctl_ComCd.EditValue = UserInfo.CompCode;
            ctl_PlantCd.EditValue = UserInfo.PlantCode;

            
            strapButtonEdit_ItemMaster1.InitCompCode(UserInfo.CompCode);
            strapButtonEdit_ItemMaster1.InitPlantCode(UserInfo.PlantCode);

        }



        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Comp_Cd
                = ctl_ComCd.EditValue?.ToString();
            _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plant_Cd
                = ctl_PlantCd.EditValue?.ToString();
            _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd
                = ctl_PlanYear.DateTime.ToString("yyyy");

            _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Item_Group_cd
                = ctl_ItemGr.EditValue?.ToString();

            _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Item_cd
                = strapButtonEdit_ItemMaster1.EditValue?.ToString();


            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void SetEditorValue(BaseEdit editor, object value)
        {
            if (Visible)
            {
                editor.EditValue = value;
                foreach (Binding i in editor.DataBindings)
                {
                    i.WriteValue();
                }
            }
        }


        private void Btn_CreatPlan_Click(object sender, EventArgs e)
        {
            //계획 생성 팝업창
            MonthPlanItemSeletor itemSeletor
                = new MonthPlanItemSeletor(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Comp_Cd
                                , _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plant_Cd
                                , _monthPlanPocket
                                , ctl_PlanYear.DateTime
                );
            if (itemSeletor.ShowDialog() == DialogResult.OK)
            {
                _monthList.DataRefresh(_monthPlanArgs);
            }

        }
    }
}
