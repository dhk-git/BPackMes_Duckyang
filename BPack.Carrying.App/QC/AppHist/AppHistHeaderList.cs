using BPack.Common.LoginInfo;
using BPack.Model.App.QC.AppHist;
using BPack.Pocket.App.QC.AppHist;
using BPack.Strap.FormControls;
using System.Collections.Generic;
using System.Drawing;

namespace BPack.Carrying.App.QC.AppHist
{
    public partial class AppHistHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private AppHistArgs _AppHistArgs;
        private AppHistPocket _AppHistPocket;

        public AppHistHeaderList()
        {
            InitializeComponent();
        }

        public AppHistHeaderList(AppHistArgs AppHistArgs, AppHistPocket AppHistPocket) : this()
        {
            _AppHistArgs = AppHistArgs;
            _AppHistPocket = AppHistPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = AppHistHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _AppHistArgs,
                GridView = gridView1,
                InitModelType = typeof(AppHistHeaderModel),
                ModelArgs = _AppHistArgs.AppHistModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<AppHistModelArgs, AppHistHeaderModel>(_AppHistPocket.SelectAppHistHeaderModels, null);

            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.AllowCellMerge = false;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }

        public AppHistHeaderModel GetSelectedModel()
        {
            return (AppHistHeaderModel)AppHistHeaderModelBindingSource.Current;
        }

        public List<AppHistHeaderModel> GetSelectedModels()
        {
            return (List<AppHistHeaderModel>)AppHistHeaderModelBindingSource.DataSource;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0)
                return;

            if (_AppHistArgs.AppHistModelArgs.Select_Main_Opt == "1")    // 결재요청화면 
            {
                if (gridView1.GetRowCellValue(e.RowHandle, "INSP_APP_STATUS") == null || gridView1.GetRowCellValue(e.RowHandle, "INSP_APP_STATUS")?.ToString() == "RET")
                {
                    e.Appearance.Font = new Font(e.Appearance.GetFont(), FontStyle.Bold);
                }
                else
                {
                    e.Appearance.Font = new Font(e.Appearance.GetFont(), FontStyle.Regular);
                }
            }
            else if (_AppHistArgs.AppHistModelArgs.Select_Main_Opt == "2")    // 결재화면 
            {
                if (gridView1.GetRowCellValue(e.RowHandle, "APP_USER_ID_REV")?.ToString() == UserInfo.UserID && gridView1.GetRowCellValue(e.RowHandle, "APP_STATUS_REV")?.ToString() == "REQ")
                {
                    e.Appearance.Font = new Font(e.Appearance.GetFont(), FontStyle.Bold);
                }
                else if (gridView1.GetRowCellValue(e.RowHandle, "APP_USER_ID_APP")?.ToString() == UserInfo.UserID && gridView1.GetRowCellValue(e.RowHandle, "APP_STATUS_APP")?.ToString() == "REQ")
                {
                    e.Appearance.Font = new Font(e.Appearance.GetFont(), FontStyle.Bold);
                }
                else
                {
                    e.Appearance.Font = new Font(e.Appearance.GetFont(), FontStyle.Regular);
                }
            }

            if (e.RowHandle == gridView1.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Blue;
                e.Appearance.ForeColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (e.FocusedRowHandle < 0)
            //    return;

            //string InspAppStatus = gridView1.GetFocusedRowCellValue("INSP_APP_STATUS")?.ToString();
            //if (InspAppStatus == null)
            //    InspAppStatus = string.Empty;

            //switch (this._AppHistArgs.AppHistModelArgs.Select_Main_Opt)
            //{
            //    case "1":   // 결재요청
            //        if (InspAppStatus != string.Empty && InspAppStatus != "RET")    // 결재요청 해야 할 데이터와 반려된 데이터만 선택가능 
            //        {
            //            gridView1.SetFocusedRowCellValue("IsCheck", false);                        
            //        }
            //        break;
            //    case "2":   // 승인, 반려 
            //        if (InspAppStatus != "REQ" && InspAppStatus != "RUN")     // 결재요청 됐거나, 결재 진행중인 것만 선택 가능 
            //        {
            //            gridView1.SetFocusedRowCellValue("IsCheck", false);
            //        }
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
