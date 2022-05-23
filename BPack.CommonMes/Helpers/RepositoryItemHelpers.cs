using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Helpers
{
    public static class RepositoryItemHelpers
    {
        private static RepositoryItemTimeSpanEdit _repositoryItemTimeSpanEdit = new RepositoryItemTimeSpanEdit();
        private static RepositoryItemLookUpEdit _repositoryItemLookUpEdit;

        public static void SetRepositoryItemTimeSpanEdit(GridColumn gridColumn, string editMask = "HH:mm", string displayFormatString = "HH:mm", bool allowEditDays = false, bool allowEditHours = true, bool allowEditMinutes = true, bool allowEditSeconds = false)
        {
            _repositoryItemTimeSpanEdit.AllowEditDays = allowEditDays;
            _repositoryItemTimeSpanEdit.AllowEditHours = allowEditHours;
            _repositoryItemTimeSpanEdit.AllowEditMinutes = allowEditMinutes;
            _repositoryItemTimeSpanEdit.AllowEditSeconds = allowEditSeconds;

            _repositoryItemTimeSpanEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            _repositoryItemTimeSpanEdit.Mask.EditMask = editMask;
            _repositoryItemTimeSpanEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            _repositoryItemTimeSpanEdit.DisplayFormat.FormatString = displayFormatString;
            gridColumn.ColumnEdit = _repositoryItemTimeSpanEdit;
        }

        public static RepositoryItemLookUpEdit CreateRepItemLookUpEdit(string valueMember = "CODE", string valueCaption = "코드", string displayMember = "NAME", string displayCaption = "명칭", object dataSource = null, string nullText = "", BestFitMode bestFitMode = BestFitMode.BestFitResizePopup)
        {
            _repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();

            var columninfoList = new LookUpColumnInfo[]
            {
              new LookUpColumnInfo { Caption = valueCaption, FieldName = valueMember },
              new LookUpColumnInfo { Caption = displayCaption, FieldName = displayMember }
            };

            _repositoryItemLookUpEdit.Columns.AddRange(columninfoList);
            _repositoryItemLookUpEdit.ValueMember = valueMember;
            _repositoryItemLookUpEdit.DisplayMember = displayMember;
            _repositoryItemLookUpEdit.DataSource = dataSource;
            _repositoryItemLookUpEdit.NullText = nullText;
            _repositoryItemLookUpEdit.BestFitMode = bestFitMode;
            return _repositoryItemLookUpEdit;
        }

        /// <summary>
        /// PopUp filter 적용 (목록 필터링)
        /// </summary>
        /// <param name="repositoryItemLookUpEdit"></param>
        /// <param name="criteria"></param>
        public static void PopupFilter(this RepositoryItemLookUpEdit repositoryItemLookUpEdit, string criteria = "DEL_FG != 'Y'")
        {
            var source = (repositoryItemLookUpEdit.DataSource as System.Data.DataTable);
            if (source == null || source.Select().Where(r => r["DEL_FG"].ToString() == "Y").Count() == 0) return;

            repositoryItemLookUpEdit.PopupFilter += (object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e) =>
            {
                e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(criteria);
            };
        }

    }
}
