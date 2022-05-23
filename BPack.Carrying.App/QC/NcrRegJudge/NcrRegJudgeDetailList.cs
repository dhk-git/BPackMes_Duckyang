using BPack.Common.Config;
using BPack.Common.LoginInfo;
using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrRegJudge;
using BPack.Pocket.App.QC.NcrRegJudge;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.NcrRegJudge
{
    public partial class NcrRegJudgeDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private NcrRegJudgePocket _regPocket;
        private NcrRegJudgeArgs _ncrRegArgs;

        public NcrRegJudgeDetailList()
        {
            InitializeComponent();
        }

        public NcrRegJudgeDetailList(NcrRegJudgePocket regPocket, NcrRegJudgeArgs ncrRegArgs) : this()
        {
            this._regPocket = regPocket;
            this._ncrRegArgs = ncrRegArgs;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = ncrRegJudgDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _ncrRegArgs,
                GridView = gridView1,
                InitModelType = typeof(NcrRegJudgeDetailModel),
                ModelArgs = _ncrRegArgs.NcrRegJudgModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<NcrRegJudgeModelArgs, NcrRegJudgeDetailModel>
                (_regPocket.SelectNcrRegJudgDetailModels, _regPocket.SaveNcrRegJudgDetailModel, _regPocket.SaveNcrRegJudgDetailModels);

            //gridView1.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((NcrRegJudgeDetailModel)model).COMP_CD = _ncrRegArgs.NcrRegJudgModelArgs.Select_Main_Comp_Cd;
            ((NcrRegJudgeDetailModel)model).PLANT_CD = _ncrRegArgs.NcrRegJudgModelArgs.Select_Main_Plant_Cd;
            ((NcrRegJudgeDetailModel)model).NCD_NO = _ncrRegArgs.NcrRegJudgModelArgs.NCD_NO_KEY;
            ((NcrRegJudgeDetailModel)model).NCD_NO_KEY = _ncrRegArgs.NcrRegJudgModelArgs.NCD_NO_KEY;
            ((NcrRegJudgeDetailModel)model).JUDGE_QTY = 1;
            ((NcrRegJudgeDetailModel)model).JUDGE_STATUS = "WAIT";
            base.SetInsertDefaultValue(model);
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnSysCode(colJUDGE_CD, "JUDGE_CD");
            LookUpEditHelper.SetGridColumnByQuery(colTO_WH_CD, "WareHouses_WithCode",
             new
             {
                 COMP_CD = ((NcrRegJudgeArgs)args).NcrRegJudgModelArgs.Select_Main_Comp_Cd
                 ,
                 PLANT_CD = ((NcrRegJudgeArgs)args).NcrRegJudgModelArgs.Select_Main_Plant_Cd
             }
             , "Code", "Name");
            LookUpEditHelper.SetGridColumnSysCode(colJUDGE_STATUS, "JUDGE_STATUS");
        }

        public override void AddNew(ArgsBase args)
        {
            if (_ncrRegArgs.NcrRegJudgModelArgs.JUDGE_RESULT == "N")
            {
                //추가 불가
                return;
            }
            else
            {
                base.AddNew(args);
            }
        }
        public override void Save(ArgsBase args)
        {
            int _defect_qty = _ncrRegArgs.NcrRegJudgModelArgs.DEFECT_QTY;

            List<NcrRegJudgeDetailModel> models
                = GetCheckedData();
            int SumQty = models.Sum(v => v.JUDGE_QTY);

            if (models.Exists(v => v.JUDGE_QTY <= 0)
                || SumQty > _defect_qty
                )
            {
                //부적합 등록수량과 판정수량을 확인하세요.
                StrapMessageBox.Show("A001", 91);
                return;
            }

            if (models.Exists(v => string.IsNullOrEmpty(v.JUDGE_CD) == true
                                || (v.JUDGE_CD== "JUDGE_OK" && string.IsNullOrEmpty(v.TO_WH_CD) == true)
                                
                                ))
            {
                //판정 결과 또는  출고창고를 확인하세요
                StrapMessageBox.Show("A001", 92);
                return;
            }

            //2022.02.10 
            // JUDGE_BAD_PRINT_YN='N'인 경우 신규 식별표 발행 안함 옵션으로 팝업창에서
            //담당자가 설정하도록
            if (((BPack.Carrying.App.QC.NcrRegJudgeArgs)args).NcrRegJudgModelArgs.JUDGE_NEW_PRINT_YN == "N")
            {
                List<NcrRegJudgeDetailModel> allModels = GetCheckedData(true);

                //양품이 있고 이전 식별표가 존재하는 경우
                //신규 식별표를 출력하시겠습니까?
                if (models.Exists(v => v.JUDGE_CD == "JUDGE_OK")
                    && String.IsNullOrEmpty(((BPack.Carrying.App.QC.NcrRegJudgeArgs)args).NcrRegJudgModelArgs.PRE_HU_NO)==false
                    )
                {
                    if (((BPack.Carrying.App.QC.NcrRegJudgeArgs)args).NcrRegJudgModelArgs.JUDGE_HU_STATUS=="N")
                    {
                        if (allModels.Where(v => v.JUDGE_CD == "JUDGE_OK").Count() > 1)
                        {
                            //기존 식별표 사용시 양품처리는 1건만 가능합니다.
                            StrapMessageBox.Show("A001", 112);
                            return;
                        }
                    }

                    //신규 식별표를 생성하시겠습니까?
                    //신규 생성시 기존 바코드(식별표)는 사용불가능합니다.
                    DialogResult res = StrapMessageBox.Show("A001", 111, MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        //YES 인 경우 기존과 동일
                    }
                    else if (res == DialogResult.No)
                    {
                        //NO 인 경우 
                        // 등록된 상세 부적합 List 중 양품 처리는 1건 이어야 함
                        
                        if (allModels.Where(v => v.JUDGE_CD == "JUDGE_OK").Count() > 1)
                        {
                            //기존 식별표 사용시 양품처리는 1건만 가능합니다.
                            StrapMessageBox.Show("A001", 112);
                            return;
                        }
                        var okModel = models.Where(v => v.JUDGE_CD == "JUDGE_OK").ToList();
                        foreach (var _model in okModel)
                        {
                            _model.JUDGE_NEW_PRINT_YN = "N";
                        }
                        // 불량 + 양품 =전체 수량 일 필요는 없는듯...
                    }

                }
            }
           

            base.Save(args);

        }

        internal List<NcrRegJudgeDetailModel> GetCheckedData(bool allSelect=false)
        {
            if (allSelect == false)
            {
                //선택한 행만 return
                return ((List<NcrRegJudgeDetailModel>)this.SelectedModels).Where(v => v.IsCheck == true).ToList();
            }
            else
            {
                //전체 return
                return ((List<NcrRegJudgeDetailModel>)this.SelectedModels).ToList();
            }
            //var value = this.SelectedModels;
            //List<NcrRegJudgeDetailModel> models = new List<NcrRegJudgeDetailModel>();
            //var selectedRowHandlers = gridView1.GetSelectedRows();
            //foreach (var selectedRowHandler in selectedRowHandlers)
            //{
            //    models.Add(gridView1.GetRow(selectedRowHandler) as NcrRegJudgeDetailModel);
            //}
            //return models;
        }

        internal void Confirm(List<NcrRegJudgeDetailModel> models)
        {
            //미저장데이터 있면 리턴
            if (models.Exists(v => v.RowState == RowState.Added))
            {
                //신규 데이터는 저장 후 확정가능합니다.
                StrapMessageBox.Show("A001", 93);
                return;
            }
            else if (models.Exists(v => v.JUDGE_STATUS == "CLOSE"))
            {
                //이미 확정된 데이터가 있습니다.
                StrapMessageBox.Show("A001", 94);
                return;
            }

            if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<NcrRegJudgeConfirmModel> Confirmmodels = new List<NcrRegJudgeConfirmModel>();
                foreach (var model in models)
                {
                    Confirmmodels.Add(new NcrRegJudgeConfirmModel()
                    {
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID
                            ,
                        MODIFY_DTTM = DateTime.Now
                          ,
                        MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
                          ,
                        CREATE_DTTM = DateTime.Now
                         ,
                        LANG_CODE = UserInfo.Sys_Language
                        ,
                        COMP_CD = model.COMP_CD
                        ,
                        PLANT_CD = model.PLANT_CD
                        ,
                        NCD_NO_KEY = model.NCD_NO_KEY
                        ,
                        JUDGE_SEQ_KEY = model.JUDGE_SEQ_KEY
                        ,
                        JUDGE_STATUS = "CLOSE"
                    });
                }
                _regPocket.SaveNcrRegJudgConfirmModel(Confirmmodels);

                DataRefresh(_ncrRegArgs);
            }

        }
    }
}
