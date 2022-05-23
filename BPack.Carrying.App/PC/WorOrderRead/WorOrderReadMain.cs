using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WorOrderRead;
using System;
using System.Collections.Generic;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.PC.WorOrderRead
{
    public partial class WorOrderReadMain : StrapMainForm
    {
        private WorOrderReadArgs _worOrderReadArgs;
        private WorOrderReadPocket _worOrderReadPocket;
        private WorOrderReadHeaderList _worOrderReadHeaderList;

        public WorOrderReadMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _worOrderReadArgs = new WorOrderReadArgs();
            _worOrderReadPocket = new WorOrderReadPocket();
            _worOrderReadHeaderList = new WorOrderReadHeaderList(_worOrderReadArgs, _worOrderReadPocket);

            AddSubForm(this, _worOrderReadHeaderList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm() {
                FormArgs = _worOrderReadArgs,
                InitlistForm = _worOrderReadHeaderList,
                StrapLayout = strapLayout1
            });
            //strapDateEdit1.EditValue = DateTime.Now.Date.AddDays(-30);
            InitRibbonButtons(true, false, false, false);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);

                LookUpEditHelper.SetCommonCode(strapLookUpEdit3, strapLookUpEdit1.EditValue?.ToString(), "LINE");
                LookUpEditHelper.FirstRowSelect(strapLookUpEdit3);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetWorkCenter(strapLookUpEdit4, strapLookUpEdit1.EditValue?.ToString(), strapLookUpEdit2.EditValue?.ToString(), strapLookUpEdit3.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true );
            };

            strapLookUpEdit3.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetWorkCenter(strapLookUpEdit4, strapLookUpEdit1.EditValue?.ToString(), strapLookUpEdit2.EditValue?.ToString(), strapLookUpEdit3.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true);
            };

            strapLookUpEdit1.EditValue = BPack.Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_Comp_Cd = strapLookUpEdit1.EditValue?.ToString();
            _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_Plant_Cd = strapLookUpEdit2.EditValue?.ToString();
            _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_ParentWorkCenter_Cd = strapLookUpEdit3.EditValue?.ToString();
            _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_WorkCenter_Cd = strapLookUpEdit4.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }


        protected override void SetControlAndGroupDicSort()
        {
            _controlAndGroupDic = new Dictionary<string, ControlAndGroup>
            {
                { strapDateEdit1.Name, null },
                { strapDateEdit2.Name, null },
                { strapLookUpEdit1.Name, null },
                { _worOrderReadHeaderList.Name, null },
                //{ _workOrderDetailList.Name, null },
                //{ _workOrderMaterialList.Name, null }
            };
            base.SetControlAndGroupDicSort();
        }
    }
}
