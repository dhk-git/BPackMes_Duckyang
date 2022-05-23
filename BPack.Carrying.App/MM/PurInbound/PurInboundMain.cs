using BPack.Common.Pocket;
using BPack.Model.App.MM.PurInbound;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.PurInbound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MM.PurInbound
{
    public partial class PurInboundMain : StrapMainForm
    {
        private PurInboundArgs _purInboundArgs;
        private InHeaderList _inHeaderList;
        private InDetailList _inDetailList;
        //private InHuList _inHuList;
        private PackList _packList;
        private PurInboundPocket _purInboundPocket;
        //private LookUpEditPocket _lep;
        public PurInboundMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _purInboundArgs = new PurInboundArgs(); //FormArgs
            _purInboundPocket = new PurInboundPocket();
            _inHeaderList = new InHeaderList(_purInboundArgs, _purInboundPocket); //해더 서브폼
            _inDetailList = new InDetailList(_purInboundArgs, _purInboundPocket); //디테일 서브폼
            //_inHuList = new InHuList(_purInboundArgs, _purInboundPocket); //디테일 서브폼
            _packList = new PackList(_purInboundArgs, _purInboundPocket);
            AddSubForm(this, _inHeaderList, layoutControlGroup2); //헤더서브폼을 Layout에 추가
            AddSubForm(this, _inDetailList, layoutControlGroup3); //디테일서브폼을 Layout에 추가
            //AddSubForm(this, _inHuList, layoutControlGroup4); //디테일서브폼을 Layout에 추가
            AddSubForm(this, _packList, layoutControlGroup5);
            _inHeaderList.AddRefreshTargetSubForm(_inDetailList); //데이터 갱신시 미저장데이터 체크
            //_inHeaderList.AddRefreshTargetSubForm(_inHuList); //데이터 갱신시 미저장데이터 체크
            //_inDetailList.AddRefreshTargetSubForm(_inHuList); //데이터 갱신시 미저장데이터 체크
            InitFields(new FieldArgs_StrapMainForm() //메인폼 초기화 메서드
            {
                FormArgs = _purInboundArgs,
                InitlistForm = _inHeaderList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, false, true, true);   //리본메뉴 초기화
            _inHeaderList.ModelSelectedEvent += InHeaderList_ModelSelectedEvent; //헤더폼의 모델셀렉티드 이벤트
            _inDetailList.ModelSelectedEvent += InDetailList_ModelSelectedEvent; //헤더폼의 디테일셀렉티드 이벤트
            _inDetailList.ModelDeletedEvent += InDetailList_ModelDeletedEvent;
            _inHeaderList.ModelDeletedEvent += InHeaderList_ModelDeletedEvent;
            _inHeaderList.ModelUpdatedEvent += InHeaderList_ModelUpdatedEvent;
            this.SelectedSubFormChanged += PurInboundMain_SelectedSubFormChanged; //서브폼 선택 변경시 이벤트(리본버튼조정)

            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "MM.PurInbound.BpList_WithAll", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode
            }, "CODE", "NAME");
            //LookUpEditHelper.SetWareHouse(strapLookUpEdit2, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode, false);
            LookUpEditHelper.SetByQuery(strapLookUpEdit2, "WareHouses_WhereRawMaterial", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = _purInboundArgs.PurInboundModelArgs.Select_Extra_Plant_Cd
            }, "CODE", "NAME", isFirstSelect: true);
            //strapLookUpEdit2.EditValueChanged += StrapLookUpEdit2_EditValueChanged;
            //strapLookUpEdit2.EditValueChanged += StrapLookUpEdit2_EditValueChanged;
            //strapLookUpEdit3.EditValueChanged += StrapLookUpEdit3_EditValueChanged;
        }

        private void InDetailList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _packList.DataRefresh(_purInboundArgs);
        }

        private void InHeaderList_ModelUpdatedEvent(object sender, ArgsBase e)
        {
            _purInboundArgs.PurInboundModelArgs.Select_Pih_No = null;
            _purInboundArgs.PurInboundModelArgs.Select_Pih_Status = null;
            //패킹리스트 등록 버튼 
            btnAddPackingList.Enabled = false;
            _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_Start_Dt = strapDateEdit3.DateTime;
            _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_End_Dt = strapDateEdit4.DateTime;
            _packList.DataRefresh(_purInboundArgs);
        }

        private void InHeaderList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _purInboundArgs.PurInboundModelArgs.Select_Pih_No = null;
            _purInboundArgs.PurInboundModelArgs.Select_Pih_Status = null;
            //패킹리스트 등록 버튼 
            btnAddPackingList.Enabled = false;
            _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_Start_Dt = strapDateEdit3.DateTime;
            _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_End_Dt = strapDateEdit4.DateTime;
            _packList.DataRefresh(_purInboundArgs);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        //private void StrapLookUpEdit3_EditValueChanged(object sender, EventArgs e)
        //{
        //    _purInboundArgs.Select_Main_InTarget_Loc_Cd = strapLookUpEdit3.EditValue?.ToString();
        //}

        //private void StrapLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        //{
        //    _purInboundArgs.Select_Main_InTarget_Wh_Cd = strapLookUpEdit2.EditValue?.ToString();
        //    LookUpEditHelper.SetByQuery(strapLookUpEdit3, "Locations", new
        //    {
        //        COMP_CD = Common.LoginInfo.UserInfo.CompCode,
        //        PLANT_CD = _purInboundArgs.PurInboundModelArgs.Select_Extra_Plant_Cd,
        //        WH_CD = _purInboundArgs.Select_Main_InTarget_Wh_Cd
        //    }, "위치코드", "위치명");
        //}

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _purInboundArgs.PurInboundModelArgs.Select_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _purInboundArgs.PurInboundModelArgs.Select_Main_Bp_Cd = strapLookUpEdit1.EditValue?.ToString();
            _purInboundArgs.PurInboundModelArgs.Select_Main_Pih_No = strapTextEdit1.EditValue?.ToString();

            _purInboundArgs.PurInboundModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _purInboundArgs.PurInboundModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;

            _purInboundArgs.PurInboundModelArgs.Select_Pih_No = null;
            _purInboundArgs.PurInboundModelArgs.Select_Pih_Status = null;
            //패킹리스트 등록 버튼 
            btnAddPackingList.Enabled = false;

            base.Refresh_From_ExecuteByRibbonButton();

            _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_Start_Dt = strapDateEdit3.DateTime;
            _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_End_Dt = strapDateEdit4.DateTime;
            _packList.DataRefresh(_purInboundArgs);
        }

        private void PurInboundMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _inHeaderList)
            {
                if (_purInboundArgs.PurInboundModelArgs.Select_Pih_Status != null
                       && _purInboundArgs.PurInboundModelArgs.Select_Pih_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, true, true, true, false);
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(true, true, false, false, false);
                }
                
            }
            if (this.SelectedSubForm == _inDetailList)
            {
                if (_purInboundArgs.PurInboundModelArgs.Select_Pih_Status != null
                    && _purInboundArgs.PurInboundModelArgs.Select_Pih_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, true, false, true, true);
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(true, false, false, false, false);
                }
            }
            if (this.SelectedSubForm == _packList)
            {
                SetRibbonButtonsEnable_ByAuth(true, false, false, false, false);
            }
        }

        private void InDetailList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _purInboundArgs.PurInboundModelArgs.Select_Pid_No = ((InDetailModel)e.SelectedModelArgsBase.SelectedModelBase).PID_NO;
            //_inHuList.DataRefresh(_purInboundArgs);

        }

        private void InHeaderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _purInboundArgs.PurInboundModelArgs.Select_Pih_No = ((InHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PIH_NO;
            // _purInboundArgs.PurInboundModelArgs.Select_Extra_Plant_Cd = ((InHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).IN_PLANT_CD;
            _purInboundArgs.Select_Extra_Bp_Cd = ((InHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _purInboundArgs.PurInboundModelArgs.Select_Pid_No = null; //헤더를 선택했을때 식별표가 전부 조회 되도록 수정 20200407
            _purInboundArgs.PurInboundModelArgs.Select_Pih_Status = ((InHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PIH_STATUS;
            //_purInboundArgs.Select_Extra_Bp_Nm = InHeaderList 그리드에서 가져옴
            _inDetailList.DataRefresh(_purInboundArgs);
            //_inHuList.DataRefresh(_purInboundArgs);
            //_inHuList.DataClear(_purInboundArgs);
            if (_purInboundArgs.PurInboundModelArgs.Select_Pih_Status.Equals("WAIT"))
            {
                btnAddPackingList.Enabled = true;
            }
            else
            {
                btnAddPackingList.Enabled = false;
            }
            //상태값에 따라 데이터 컨트롤 변경
            if (_purInboundArgs.PurInboundModelArgs.Select_Pih_Status != null
                      && _purInboundArgs.PurInboundModelArgs.Select_Pih_Status.Equals("WAIT"))
            {
                SetRibbonButtonsEnable_ByAuth(true, true, true, true, false);
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(true, true, false, false, false);
            }
        }


        //선택전표 입고처리 버튼 --사용안함
        private void LayoutControlGroup2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //_inHeaderList.BpInHeader();
        }
        //선택품목 입고처리 버튼 --사용안함
        private void LayoutControlGroup3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //_inDetailList.BpInDetail();
        }
   

        // 입고처리버튼 20211025
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg;
            if (_inHeaderList.CheckConfirm(out msg) == false)
            {
                StrapMessageBox.Show(msg);
                return;
            }
            if (_inDetailList.CheckConfirm(out msg) == false)
            {
                StrapMessageBox.Show(msg);
                return;
            }

            if (StrapMessageBox.Show("A001", 20, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConfirmInHeaderModel confirmInHeaderModel = new ConfirmInHeaderModel()
                {
                    COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                    PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                    PIH_NO = _purInboundArgs.PurInboundModelArgs.Select_Pih_No,
                    CREATE_DTTM = DateTime.Now,
                    MODIFY_DTTM = DateTime.Now,
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                    WH_CD = strapLookUpEdit2.EditValue.ToString()
                };
                try
                {
                    _purInboundPocket.BpInHeader(confirmInHeaderModel);
                    _inHeaderList.DataRefresh(_purInboundArgs);
                    _inDetailList.DataClear(_purInboundArgs);

                    _purInboundArgs.PurInboundModelArgs.Select_Pih_No = null;
                    _purInboundArgs.PurInboundModelArgs.Select_Pih_Status = null;
                    //패킹리스트 등록 버튼 
                    btnAddPackingList.Enabled = false;
                    _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_Start_Dt = strapDateEdit3.DateTime;
                    _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_End_Dt = strapDateEdit4.DateTime;
                    _packList.DataRefresh(_purInboundArgs);

                    StrapMessageBox.Show("A001", 18);//처리완료 되었습니다.
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }

            }

        }
        //패킹리스트 조회 버튼
        private void btnSearchPackingList_Click(object sender, EventArgs e)
        {
            _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_Start_Dt = strapDateEdit3.DateTime;
            _purInboundArgs.PurInboundModelArgs.Select_Main_PackingList_End_Dt = strapDateEdit4.DateTime;
            _packList.DataRefresh(_purInboundArgs);
        }
        //입고데이터 생성 버튼
        private void btnAddPackingList_Click(object sender, EventArgs e)
        {
            var selectedPurPackModels = _packList.GetSelectedModels();
            if (selectedPurPackModels.Count() == 0)
            {
                StrapMessageBox.Show("A002", 12); //선택된 건이 없습니다.
                return;
            }
            
            foreach (var model in _inDetailList.SelectedModels as List<InDetailModel>)
            {
                if (selectedPurPackModels.Where(a => a.PAC_NO == model.PAC_NO).Any())
                {
                    StrapMessageBox.Show("A002", 22); //이미 등록된 패킹리스트가 존재합니다.
                    return;
                }
            }
            List<InDetailModel> inDetailModels = new List<InDetailModel>();
            foreach (var model in selectedPurPackModels)
            {
                if (!model.PAC_STATUS.Equals("WAIT"))
                {
                    StrapMessageBox.Show("A002", 14); //입고할수 없는 상태 건이 선택했습니다.
                    inDetailModels.Clear();
                    return;
                }
                inDetailModels.Add(new InDetailModel
                {
                    COMP_CD = model.COMP_CD,
                    PLANT_CD = model.PLANT_CD,
                    CREATE_DTTM = DateTime.Now,
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    DEL_FG = "N",
                    ITEM_CD = model.ITEM_CD,
                    ITEM_GR_1 = model.ITEM_GR_1,
                    ITEM_NM = model.ITEM_NM,
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                    MODIFY_DTTM = DateTime.Now,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    PID_QTY = model.PAC_QTY,
                    PIH_NO = _purInboundArgs.PurInboundModelArgs.Select_Pih_No,
                    PAC_NO = model.PAC_NO,
                    POD_NO = model.POD_NO,
                    HU_NO = model.HU_NO,
                    RowState = Common.Model.RowState.Added,
                    IsCheck = true,
                    PID_STATUS = "WAIT",
                    GIR_DT = model.ARRIVAL_DT       //수불일자는 도착일자로 처리함 20220428
                });
            }
            _inDetailList.AddInDetailModels(inDetailModels);
            try
            {
                _inDetailList.Save(_purInboundArgs);
                _packList.DataRefresh(_purInboundArgs);
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
            
        }
    }
}
