using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdCalendar;

namespace BPack.Pocket.App.MD.PrdCalendar
{
    public class PrdCalendarPocket : PocketBase
    {
        public PrdCalendarPocket()
        {
            InitPocket("PrdCalendar");
        }

        public void SaveCalendarModel(CalendarModel calendarModel)
        {
            PocketExecute("MD.PrdCalendar.CalendarList.Save", calendarModel);
        }

        public void SaveCalendarModels(List<CalendarModel> calendarModels)
        {
            PocketExecute("MD.PrdCalendar.CalendarList.Save", calendarModels);
        }

        public List<CalendarModel> SelectCalendarModels(PrdCalendarModelArgs args)
        {
            return PocketQuery<CalendarModel>("MD.PrdCalendar.CalendarList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                DT_FROM = args.Select_Main_Date_From,
                DT_TO = args.Select_Main_Date_To
            });

        }
    }
}
