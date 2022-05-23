using BPack.Common.Model;
using BPack.CommonMes.Enums;
using BPack.CommonMes.Extensions;
using BPack.Model.App.MD.PrdCalendar;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdCalendar;
using DevExpress.XtraGrid.Views.Base;
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

namespace BPack.Carrying.App.MD.PrdCalendar
{
    public partial class CalendarList : StrapSubForm_OnlyOneGrid_V2
    {
        PrdCalendarArgs _prdCalendarArgs;
        PrdCalendarPocket _prdCalendarPocket;
        private StrapSplashScreenManager _strapSplashScreenManager;

        public CalendarList()
        {
            InitializeComponent();
        }

        public CalendarList(PrdCalendarArgs prdCalendarArgs, PrdCalendarPocket prdCalendarPocket) : this()
        {
            _prdCalendarArgs = prdCalendarArgs;
            _prdCalendarPocket = prdCalendarPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = calendarModelBindingSource,
                GridView = gridView1,
                FormArgs = _prdCalendarArgs,
                InitModelType = typeof(CalendarModel),
                ModelArgs = _prdCalendarArgs.PrdCalendarModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdCalendarModelArgs, CalendarModel>(_prdCalendarPocket.SelectCalendarModels, _prdCalendarPocket.SaveCalendarModel, _prdCalendarPocket.SaveCalendarModels);

            _strapSplashScreenManager = new StrapSplashScreenManager(this);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            
            ((CalendarModel)model).COMP_CD = _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Comp_Code;
            ((CalendarModel)model).PLANT_CD = _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Plant_Code;
            var source = (List<CalendarModel>)calendarModelBindingSource.DataSource;
            var maxDate = source.Select(r => r.WORK_DT).Max() <= DateTime.Now ? DateTime.Today.AddDays(1) : source.Select(r => r.WORK_DT).Max().AddDays(1);
            ((CalendarModel)model).WORK_DT = maxDate;
            ((CalendarModel)model).WORK_DT_KEY = maxDate;
            ((CalendarModel)model).WORK_TYPE = maxDate.GetWorkType();
        }

        public void DataCreate()
        {
            try
            {
                _strapSplashScreenManager.ShowWaitForm();

                var dtFrom = DateTime.Parse(_prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Date_From);
                var dtTo = DateTime.Parse(_prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Date_To);
                var dtCount = dtTo.Subtract(dtFrom).Days;
                var source = (List<CalendarModel>)calendarModelBindingSource.DataSource;

                for (int i = 0; i < dtCount + 1; i++)
                {
                    try
                    {
                        var dupCount = source.Select(r => r).Where(R => R.WORK_DT.ToShortDateString() == dtFrom.ToShortDateString()).FirstOrDefault();
                        if (dupCount != null) continue;

                        CalendarModel calendarModel = new CalendarModel()
                        {
                            COMP_CD = _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Comp_Code,
                            PLANT_CD = _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Plant_Code,
                            WORK_DT = dtFrom,
                            WORK_DT_KEY = dtFrom,
                            WORK_TYPE = dtFrom.GetWorkType(),
                            CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                            MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                            IsCheck = true,
                            RowState = RowState.Added
                        };
                        source.Add(calendarModel);
                    }
                    finally
                    {
                        dtFrom = dtFrom.AddDays(1);
                    }
                }
                gridView1.RefreshData();
                gridView1.BestFitColumns();

            }
            finally
            {
                _strapSplashScreenManager.CloseWaitForm();
            }
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnCommonCode(colWORK_TYPE, _prdCalendarArgs.PrdCalendarModelArgs.Select_Main_Comp_Code, "WORK_TYPE");

            base.DataRefresh(args);

            var source = (List<CalendarModel>)calendarModelBindingSource.DataSource;
            var rows = source.Select(r => r).Where(r => r.WORK_TYPE == SysCode.WorkType.HOLIDAY);
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var source = (CalendarModel)grv.GetRow(e.RowHandle);

            if (view.IsValidRowHandle(e.RowHandle) && source.WORK_DT.DayOfWeek == DayOfWeek.Saturday)
                e.Appearance.ForeColor = Color.Blue;
            else  if (view.IsValidRowHandle(e.RowHandle) && source.WORK_TYPE == SysCode.WorkType.HOLIDAY)
                e.Appearance.ForeColor = Color.Red;
        }
    }
}
