using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Helpers
{
    public static class GridUnboundColumn
    {
        public static void SetUnboundColumn(DevExpress.XtraGrid.Views.Grid.GridView gridView, DevExpress.XtraGrid.Columns.GridColumn column
            , Type modelType, string fieldName, string unboundExpression, bool isShowFooter = true)
        {
            //gridView.OptionsView.ShowFooter = isShowFooter;
            var prop = modelType.GetProperty(fieldName);
            var caption = ((DisplayAttribute)prop.GetCustomAttributes().Where(a => a.GetType() == typeof(DisplayAttribute)).SingleOrDefault()).Name;

            column.FieldName = "Unbound_" + fieldName;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            column.UnboundExpression = unboundExpression; //"[SOD_QTY] * [SOD_PRICE]";

            if (isShowFooter)
            {
                DevExpress.XtraGrid.GridColumnSummaryItem gridColumnSummaryItem = new DevExpress.XtraGrid.GridColumnSummaryItem();
                gridColumnSummaryItem.FieldName = column.FieldName;
                gridColumnSummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                gridColumnSummaryItem.DisplayFormat = "{0:#,##0.#}";
                column.Summary.Add(gridColumnSummaryItem);
            }

            var trLang = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, caption);
            if (!string.IsNullOrEmpty(trLang))
            {
                column.Caption = trLang;
            }
            else
            {
                column.Caption = caption;
            }
        }
    }
}
