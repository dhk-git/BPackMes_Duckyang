using BPack.Model.App.MD.PrdWorkCenter;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdWorkCenter;
using System;
using BPack.CommonMes.Helpers;
using BPack.Common.LoginInfo;

namespace BPack.Carrying.App.MD.PrdWorkCenter
{
    public partial class PrdWorkCenterMain : StrapMainForm
    {
        private PrdWorkCenterArgs _prdWorkCenterArgs;
        private PrdWorkCenterPocket _prdWorkCenterPocket;

        //private PlantList _plantList;
        private WorkCenterList _workCenterList;
        //private EquipList _equipList;

        private WorkCenterItemList _workCenterItemList;
        private WorkCenterOPList _workCenterOPList;

        string trLang;


        public PrdWorkCenterMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _prdWorkCenterArgs = new PrdWorkCenterArgs();
            _prdWorkCenterPocket = new PrdWorkCenterPocket();

            _workCenterList = new WorkCenterList(_prdWorkCenterArgs, _prdWorkCenterPocket);
            //_equipList = new EquipList(_prdWorkCenterArgs, _prdWorkCenterPocket);
            _workCenterItemList = new WorkCenterItemList(_prdWorkCenterArgs, _prdWorkCenterPocket);
            _workCenterOPList = new WorkCenterOPList(_prdWorkCenterArgs, _prdWorkCenterPocket);
            AddSubForm(this, _workCenterList, layoutControlGroup3);
            AddSubForm(this, _workCenterItemList, layoutControlGroup4);
            AddSubForm(this, _workCenterOPList, layoutControlGroup2);


            //AddSubForm(this, _equipList, layoutControlGroup4);


            //_workCenterList.AddRefreshTargetSubForm(_equipList);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _prdWorkCenterArgs,
                InitlistForm = _workCenterList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
               
            };
            strapLookUpEdit2.EditValueChanged += StrapLookUpEdit2_EditValueChanged;



         
            _workCenterList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
               
                    _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD = ((WorkCenterModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                    _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD = ((WorkCenterModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
                    _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_WorkCenter_WC_CD = ((WorkCenterModel)e.SelectedModelArgsBase.SelectedModelBase).WC_CD;
                    _workCenterItemList.DataRefresh(_prdWorkCenterArgs);
                    _workCenterOPList.DataRefresh(_prdWorkCenterArgs);

            };


            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {

                 if (this.SelectedSubForm == _workCenterList)
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, save: true, delete: true);
                }
                else if (this.SelectedSubForm == _workCenterItemList)
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, save: true, delete: true);
                }
                else if (this.SelectedSubForm == _workCenterOPList)
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, save: true, delete: true);
                }
            };

            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "CompList", null, "회사코드", "회사명");

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;


            //2022.03.17 정수교 언어변환 
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup4.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup4.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup2.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup2.Text = trLang;
            }
        }

        private void StrapLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }
       


    }
}
