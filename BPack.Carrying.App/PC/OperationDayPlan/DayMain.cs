using BPack.Common.LoginInfo;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.OperationDayPlan;
using BPack.Pocket.App.PC.OperationDayPlan;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BPack.Carrying.App.PC.OperationDayPlan
{
    public partial class DayMain : StrapMainForm
    {
        private OperationDayPlanArgs _operationDayPlanArgs;
        private OperationDayPlanPocket _operationDayPlanPocket;
        DayList _dayList;
        public DayMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _operationDayPlanArgs = new OperationDayPlanArgs();
            _operationDayPlanPocket = new OperationDayPlanPocket();
            _dayList = new DayList(_operationDayPlanArgs, _operationDayPlanPocket);
            AddSubForm(this, _dayList, layoutControlGroup2);

            _dayList.ChagneDetailPlan += _dayList_ChagneDetailPlan;
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _operationDayPlanArgs,
                InitlistForm = _dayList,
                //IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });

            InitRibbonButtons(true, save: true);
            //회사
            LookUpEditHelper.SetCompCode(ctl_ComCd);
            ctl_ComCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
                LookUpEditHelper.SetPlantCode(ctl_PlantCd, new { COMP_CD = ctl_ComCd.EditValue?.ToString() }, isFirstSelect: true);
                _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
            };
            strapButtonEdit_ItemMaster1.InitStrap();
            //공장
            ctl_PlantCd.EditValueChanged += Ctl_PlantCd_EditValueChanged;

            //ctl_PlantCd.EditValueChanged += (object sender, EventArgs e) =>
            //{
            //    //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
            //    _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
            //    _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd = ctl_PlantCd.EditValue?.ToString();

            //    //작업장
            //    LookUpEditHelper.SetByQuery(
            //        ctl_Wc_Cd
            //        , "CoreSettingsWorkCenterList"
            //        , new { 
            //            COMP_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd
            //            , PLANT_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd
            //        }
            //        , "작업장코드", "작업장명", isTotalRow: true, isFirstSelect: true);
            //    //제품군
            //    LookUpEditHelper.SetByQuery(ctl_ItemGr, "MasterDataControls.Item.ItemGr1"
            //        , new
            //        {
            //            COMP_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd
            //                ,
            //            PLANT_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd
            //        }
            //        , "Code", "Name");

            //    strapButtonEdit_ItemMaster1.InitPlantCode(_operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd);
            //};
            //제품군
            ctl_ItemGr.EditValueChanged += (object sender, EventArgs e) =>
            {
                _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Item_Group_cd = ctl_ItemGr.EditValue?.ToString();
            };

            //확정여부
            LookUpEditHelper.SetSysCode(Ctl_Snop_Status, "SNOP_STATUS", total: true, isFirstSelect: true);

            //정렬
            LookUpEditHelper.SetSysCode(ctl_orderby, "SNOP_DY_ORDERBY", total: false, isFirstSelect: true);
            ctl_orderby.EditValueChanged += (object sender, EventArgs e) =>
            {
                _dayList.ChnageOrderby(ctl_orderby.EditValue?.ToString());
            };

            ctl_ComCd.EditValue = UserInfo.CompCode;
            ctl_PlantCd.EditValue = UserInfo.PlantCode;

            strapButtonEdit_ItemMaster1.InitCompCode(UserInfo.CompCode);
            strapButtonEdit_ItemMaster1.InitPlantCode(UserInfo.PlantCode);



            ctl_Plan_Start_dt.EditValueChanged += Ctl_Plan_Start_dt_EditValueChanged;
            ctl_Plan_Start_dt.EditValue = DateTime.Now;
        }

        private void _dayList_ChagneDetailPlan(object sender, Model.App.PC.OperationDayPlan.DayPlanSumModel e)
        {
            //var dateList = from b in e.DetailGrModel_DataTable.AsEnumerable()


            try
            {
                var MinDate = e.DetailGrModel_DataTable.AsEnumerable().GroupBy(f => string.Empty).Select(f => new
                {
                    Date = f.Min(g => g["WORK_DT_CD"])
                }).FirstOrDefault();

                DateTime _date = DateTime.Parse(MinDate.Date.ToString());
                strapDateEdit1.EditValue = _date;
                strapDateEdit2.EditValue = _date;
            }
            catch { }

            var _WcList = from b in e.headerGrModel.AsEnumerable()
                           group b by new
                           {
                               b.COMP_CD
                              ,
                               b.PLANT_CD
                              ,
                               b.WC_CD
                              ,
                               b.WC_NM

                           } into g
                           select new
                           {
                               Code = g.Key.WC_CD
                                          ,
                               Name = g.Key.WC_NM + "(" + g.Key.WC_CD + ")"
                           };
            var list = new[]
                {
                    new { Code = "", Name = "All" }
                };
            //ItemList.Concat(list);
            var WcList = list.Concat(_WcList.ToList()).ToList();

            strapLookUpEdit4.Properties.DataSource = WcList;
            strapLookUpEdit4.Properties.PopulateColumns();
            strapLookUpEdit4.Properties.ValueMember = "Code";
            strapLookUpEdit4.Properties.DisplayMember = "Name";
            strapLookUpEdit4.EditValue = strapLookUpEdit4.Properties.GetDataSourceValue(strapLookUpEdit4.Properties.ValueMember, 0);

        }

        private void Ctl_PlantCd_EditValueChanged(object sender, EventArgs e)
        {
            //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd = ctl_PlantCd.EditValue?.ToString();

            //작업장
            LookUpEditHelper.SetByQuery(
                ctl_Wc_Cd
                , "CoreSettingsWorkCenterList"
                , new
                {
                    COMP_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd
                    ,
                    PLANT_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd
                }
                , "작업장코드", "작업장명", isTotalRow: true, isFirstSelect: true);
            //제품군
            LookUpEditHelper.SetByQuery(ctl_ItemGr, "MasterDataControls.Item.ItemGr1"
                , new
                {
                    COMP_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd
                        ,
                    PLANT_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd
                }
                , "Code", "Name");
            strapButtonEdit_ItemMaster1.InitCompCode(_operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd);
            strapButtonEdit_ItemMaster1.InitPlantCode(_operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd);
        }

        private void Ctl_Plan_Start_dt_EditValueChanged(object sender, EventArgs e)
        {
            SimplePocket simplePocket;
            simplePocket = SimplePocket.GetInstance();
            List<DayPlanWeek> source = simplePocket.SelectData<DayPlanWeek>(
                "PC.OperationWeekPlan.MonthWeekCalnlList.R", 
                new
                    {
                        COMP_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd,
                        PLANT_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd,
                        MONTH_CD = ctl_Plan_Start_dt.DateTime.ToString("yyyy-MM-01")
                    });
            ctl_monthWeek.Properties.DataSource = source;
            ctl_monthWeek.Properties.DisplayMember = "NAME";
            ctl_monthWeek.Properties.ValueMember = "CODE";
            ctl_monthWeek.EditValue = source.FirstOrDefault()?.CODE;
            ctl_monthWeek.Properties.PopupSizeable = true; 
            //ctl_monthWeek.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            ctl_monthWeek.Properties.PopupWidth = 500;
            DayPlanWeek model = source.Where(v => v.TODAY == "Y").SingleOrDefault();

            if (model !=null &&  model.CODE != null)
            {
                ctl_monthWeek.EditValue = model.CODE;
            }



            //LookUpEditHelper.SetByQuery(
            //    ctl_monthWeek,
            //    "PC.OperationWeekPlan.MonthWeekCalnlList.R",
            //    new
            //    {
            //        COMP_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd
            //             ,
            //        PLANT_CD = _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd
            //         ,
            //        MONTH_CD = ctl_Plan_Start_dt.DateTime.ToString("yyyy-MM-01")
            //    },
            //    new Dictionary<string, string>() 
            //    {
            //        {"Code","Code"} ,
            //        {"Name","Name"} ,
            //        {"Desc","Desc"} ,
            //        {"Today","Today"} ,
            //    }
            //    , "Code", "Name",isTotalRow:true,isFirstSelect:true
            //    );
        }

        
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd
                = ctl_ComCd.EditValue?.ToString();
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd
                = ctl_PlantCd.EditValue?.ToString();
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plan_Month_dt
                = ctl_Plan_Start_dt.DateTime;

            int MonthWeek = 0;
            if (ctl_monthWeek.EditValue == null || ctl_monthWeek.EditValue.ToString() == "")
            {
                MonthWeek = 0;
            }
            else
            {
                MonthWeek = int.Parse(ctl_monthWeek.EditValue.ToString());
            }

            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Month_Week_Cd
                = MonthWeek;
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Wc_Cd
                = ctl_Wc_Cd.EditValue?.ToString();

            //확정여부
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Snop_Status
                = Ctl_Snop_Status.EditValue.ToString();

            //제품군
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Item_Group_cd
                = ctl_ItemGr.EditValue?.ToString();
            _operationDayPlanArgs.OperationDayPlanModelArgs.Select_Main_Item_cd
            = strapButtonEdit_ItemMaster1.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            List<DayPlanWeek> models = ctl_monthWeek.Properties.DataSource as List<DayPlanWeek>;
            DayPlanWeek model = models.Where(v => v.CODE == Convert.ToInt32(ctl_monthWeek.EditValue)).Single();
            
            TimeSpan t1 = strapDateEdit1.DateTime - Convert.ToDateTime(model.START_DT);
            TimeSpan t2 = strapDateEdit1.DateTime - Convert.ToDateTime(model.END_DT);
            TimeSpan t3 = strapDateEdit2.DateTime - Convert.ToDateTime(model.START_DT);
            TimeSpan t4 = strapDateEdit2.DateTime - Convert.ToDateTime(model.END_DT);
            //t1 >=0 이어야 정상
            //t2<=0 이어야 정상
            if (t1.TotalDays >= 0 && t2.TotalDays <= 0 && t3.TotalDays >= 0 && t4.TotalDays <= 0)
            {
                //정상
                _dayList.DayPlanConfirm
                    (strapLookUpEdit4.EditValue?.ToString()
                    , strapDateEdit1.DateTime
                    , strapDateEdit2.DateTime
                    , "CLOSE");
            }
            else
            {
                //확정 일자는 조회된 날짜사이에 존재해야 합니다.
                StrapMessageBox.Show("A002", 34);

            }
            

         
        }
    }
}
