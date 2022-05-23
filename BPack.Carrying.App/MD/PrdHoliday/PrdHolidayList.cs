using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdHoliday;
using BPack.Pocket.App.MD.PrdHoliday;
using BPack.Strap.FormControls;
using System;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdHoliday
{
    public partial class PrdHolidayList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdHolidayArgs _prdHolidayArgs;
        private PrdHolidayPocket _prdHolidayPocket;

        //public PrdHolidayList()
        //{

        //}

        public PrdHolidayList(PrdHolidayArgs prdHolidayArgs, PrdHolidayPocket prdHolidayPocket)
        {
            InitializeComponent();
            this._prdHolidayArgs = prdHolidayArgs;
            this._prdHolidayPocket = prdHolidayPocket;
            IsBestFitStrapGrid = true;
        }
        public override void InitStrap()
        {
            base.InitStrap();

            LookUpEditHelper.SetGridColumnSysCode(colWORK_TYPE, "WORK_TYPE");

            LookUpEditHelper.SetGridColumnCommonCode(colMD_HOLIDAY_TYPE
                , _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Comp_Code
                , "MD_HOLIDAY_TYPE");
            //LookUpEditHelper.SetGridColumnSysCode(colMD_HOLIDAY_TYPE, "MD_HOLIDAY_TYPE");


            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = holidayModelBindingSource,
                FormArgs = _prdHolidayArgs,
                GridView = gridView1,
                InitModelType = typeof(HolidayModel),
                ModelArgs = _prdHolidayArgs.PrdHolidayModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });

            InitPocketDelegate<PrdHolidayModelArgs, HolidayModel>(
        _prdHolidayPocket.SelectHolidayModels,
        _prdHolidayPocket.SaveHolidayModel,
        _prdHolidayPocket.SaveHolidayModel);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((HolidayModel)model).COMP_CD = _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Comp_Code;
            ((HolidayModel)model).PLANT_CD = _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Plant_Code;
            ((HolidayModel)model).WORK_DT = DateTime.Now;
            base.SetInsertDefaultValue(model);
        }

        public void CopyYearHoliday(string Year)
        {
            //복사하시겠습니까?
            var msgResult = StrapMessageBox.Show("A001", 34, messageBoxButtons: MessageBoxButtons.YesNo);
            if (msgResult != DialogResult.Yes) return;

            //복사대상 년도를 확인하세요 
            if (string.IsNullOrEmpty(Year))
            {
                StrapMessageBox.Show("A001", 71, messageBoxButtons: MessageBoxButtons.OK);
                return;
            }

            //대상 년도를 확인하세요 
            if (string.IsNullOrEmpty(_prdHolidayArgs.PrdHolidayModelArgs.Year_CD))
            {
                StrapMessageBox.Show("A001", 72, messageBoxButtons: MessageBoxButtons.OK);
                return;
            }

            if (Year == _prdHolidayArgs.PrdHolidayModelArgs.Year_CD)
            {
                //동일 년도 입니다.
                StrapMessageBox.Show("A001", 73, messageBoxButtons: MessageBoxButtons.OK);
                return;
            }


            var sp = PrdHolidayPocket.GetInstance();
            sp.CopyYearHoliday(new HolidayCopyModel()
            {
                COMP_CD = _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Comp_Code
                ,
                PLANT_CD = _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Plant_Code
                ,
                YEAR_CD = _prdHolidayArgs.PrdHolidayModelArgs.Year_CD
                ,
                COPY_YEAR_CD = Year
            });
            StrapMessageBox.Show("A001", 36);

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnSysCode(colWORK_TYPE, "WORK_TYPE");
            LookUpEditHelper.SetGridColumnCommonCode(colMD_HOLIDAY_TYPE
                , _prdHolidayArgs.PrdHolidayModelArgs.Select_Main_Comp_Code
                , "MD_HOLIDAY_TYPE");
        }
    }
}
