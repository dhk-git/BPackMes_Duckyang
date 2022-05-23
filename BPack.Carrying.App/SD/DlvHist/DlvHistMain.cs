using BPack.Common.Command;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvHist;
using BPack.Pocket.App.SD.DlvHist;
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

namespace BPack.Carrying.App.SD.DlvHist
{
    public partial class DlvHistMain : StrapMainForm
    {
        private DlvHistArgs _dlvHistArgs;
        private DlvHistPocket _dlvHistPocket;
        private DlvHistList _dlvHistList;
        private DlvHistDetailList _dlvHistDetailList;
        private DlvHistDetailJisList _dlvHistDetailJisList;

        public DlvHistMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _dlvHistArgs = new DlvHistArgs();
            _dlvHistPocket = new DlvHistPocket();
            _dlvHistList = new DlvHistList(_dlvHistArgs, _dlvHistPocket);
            _dlvHistDetailList = new DlvHistDetailList(_dlvHistArgs, _dlvHistPocket);
            _dlvHistDetailJisList = new DlvHistDetailJisList(_dlvHistArgs, _dlvHistPocket);
            AddSubForm(this, _dlvHistList, layoutControlGroup3);
            AddSubForm(this, _dlvHistDetailList, layoutControlGroup4);
            AddSubForm(this, _dlvHistDetailJisList, layoutControlGroup5);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _dlvHistArgs,
                InitlistForm = _dlvHistList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            }); ;

            InitRibbonButtons(true);
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, new
            {
                COMP_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Comp_Cd
            }, false, true, true);
            _dlvHistList.ModelSelectedEvent += DlvHistList_ModelSelectedEvent;
            /* 조회조건 삭제 - 20210423
            strapLookUpEdit3.Properties.DataSource = new List<CodeAndNameModel>() {
                new CodeAndNameModel{CODE = "ORDER", NAME = "지시일자" },
                new CodeAndNameModel{CODE = "RESULT", NAME = "납품일자" }
            };
            DevExpress.XtraEditors.Controls.LookUpColumnInfo lkc1 = new DevExpress.XtraEditors.Controls.LookUpColumnInfo
            {
                Caption = "코드",
                FieldName = "CODE",
                Visible = false
            };
            DevExpress.XtraEditors.Controls.LookUpColumnInfo lkc2 = new DevExpress.XtraEditors.Controls.LookUpColumnInfo
            {
                Caption = "조회조건",
                FieldName = "NAME"
            };
            strapLookUpEdit3.Properties.Columns.Add(lkc1);
            strapLookUpEdit3.Properties.Columns.Add(lkc2);
            strapLookUpEdit3.Properties.ValueMember = "CODE";
            strapLookUpEdit3.Properties.DisplayMember = "NAME";
            strapLookUpEdit3.Properties.NullText = "";
            strapLookUpEdit3.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            strapLookUpEdit3.EditValue = "RESULT";
            */
            LookUpEditHelper.SetSysCode(strapLookUpEdit4, "DLV_TYPE", false, true, true);
            LookUpEditHelper.SetDeliveryPlace(strapLookUpEdit5, Common.LoginInfo.UserInfo.CompCode, strapLookUpEdit1.EditValue?.ToString(), true, true, true);
            tabbedControlGroup1.SelectedPageChanged += TabbedControlGroup1_SelectedPageChanged;
        }

        private void TabbedControlGroup1_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            if (e.Page == layoutControlGroup5) //직서열 건별 실적 탭일때
            {
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never; //출하유형 감추기
            }
            else
            {
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void DlvHistList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _dlvHistArgs.DlvHistModelArgs.Select_Gate_Cd = ((DlvHistModel)e.SelectedModelArgsBase.SelectedModelBase).GATE_CD;
            _dlvHistArgs.DlvHistModelArgs.Select_Dlv_Plc_Cd = ((DlvHistModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_PLC_CD;
            _dlvHistArgs.DlvHistModelArgs.Select_Dlv_Type = ((DlvHistModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_TYPE;
            _dlvHistArgs.DlvHistModelArgs.Select_Req_Dt = ((DlvHistModel)e.SelectedModelArgsBase.SelectedModelBase).REQ_DT;
            _dlvHistArgs.DlvHistModelArgs.Select_Dlv_Dt = ((DlvHistModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_DT;
            _dlvHistArgs.DlvHistModelArgs.Select_Gate_Cd = ((DlvHistModel)e.SelectedModelArgsBase.SelectedModelBase).GATE_CD;
            _dlvHistArgs.DlvHistModelArgs.Select_Item_Cd = ((DlvHistModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
            _dlvHistDetailList.DataRefresh(_dlvHistArgs);
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetByQuery(strapLookUpEdit2, "ItemGroupDetail", new
            {
                COMP_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Comp_Cd,
                PLANT_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Plant_Cd,
                ITEM_GR_CLS = "ITEM_GR_1"
            }, "CODE", "NAME", isTotalRow: true);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Alc_Cd = strapTextEdit3.EditValue?.ToString();
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit2.EditValue?.ToString();
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Req_Cls = strapLookUpEdit3.EditValue?.ToString();
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _dlvHistArgs.DlvHistModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Dlv_Type = strapLookUpEdit4.EditValue?.ToString();
            _dlvHistArgs.DlvHistModelArgs.Select_Main_Dlv_Plc_Cd = strapLookUpEdit5.EditValue?.ToString();
            TimeSpan dateDiff = _dlvHistArgs.DlvHistModelArgs.Select_Main_Start_Dt - _dlvHistArgs.DlvHistModelArgs.Select_Main_Start_Dt;
            if (dateDiff.Days >= 31)
            {
                if(StrapMessageBox.Show("한달 이상 조회시 . 그래도 조회하시겠습니다.", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
            }
            //_dlvHistDetailList.DataClear(_dlvHistArgs);
            if (tabbedControlGroup1.SelectedTabPageIndex == 0)
            {
                _dlvHistList.DataRefresh(_dlvHistArgs);
                _dlvHistDetailList.DataClear(_dlvHistArgs);
            }
            else
            {
                _dlvHistDetailJisList.DataRefresh(_dlvHistArgs);
            }

            //base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}
