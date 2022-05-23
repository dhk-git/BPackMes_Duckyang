using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdCaln;
using BPack.Pocket.App.MD.PrdCaln;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdCaln
{
    public partial class PrdCalnList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdCalnArgs _prdCalnArgs;
        private PrdCalnPocket _prdCalnPocket;
        public PrdCalnList(PrdCalnArgs prdCalnArgs, PrdCalnPocket prdCalnPocket)
        {
            InitializeComponent();
            _prdCalnArgs = prdCalnArgs;
            _prdCalnPocket = prdCalnPocket;
            IsBestFitStrapGrid = true;
        }

        public override void InitStrap()
        {
            base.InitStrap();


            DataRefreshLookUpEdit();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = calnModelBindingSource,
                FormArgs = _prdCalnArgs,
                GridView = gridView1,
                InitModelType = typeof(CalnModel),
                ModelArgs = _prdCalnArgs.PrdCalnModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });

            InitPocketDelegate<PrdCalnModelArgs, CalnModel>(
                         _prdCalnPocket.SelectCalnModel,
                         _prdCalnPocket.SaveCalnModel,
                         _prdCalnPocket.SaveCalnModel);
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            DataRefreshLookUpEdit();

            
        }

        private void DataRefreshLookUpEdit()
        {
            //작업장
            LookUpEditHelper.SetWorkCenter(
                colWC_CD,
                Common.LoginInfo.UserInfo.CompCode
                , _prdCalnArgs.PrdCalnModelArgs.Select_Main_Plant_Code
                );

            //근무유형
            LookUpEditHelper.SetGridColumnSysCode(colWORK_TYPE, "WORK_TYPE");

            //근무조 그룹
            LookUpEditHelper.SetGridColumnByQuery(
              colSHIFT_GROUP_CD,
              "MD.SHIH.Select",
              new
              {
                  COMP_CD = _prdCalnArgs.PrdCalnModelArgs.Select_Main_Comp_Code,
                  PLANT_CD = _prdCalnArgs.PrdCalnModelArgs.Select_Main_Plant_Code
              }
              , "근무조그룹"
              , "근무조그룹명");



            //휴일
            LookUpEditHelper.SetGridColumnByQuery(
              colMD_HOLIDAY_TYPE,
              "MD.Holiday.Select",
              new
              {
                  WORK_TYPE = ""
              },
              "Code", "Name");

        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            SimplePocket simplePocket;
            DataTable source;
            switch (e.Column.FieldName)
            {
                case "MD_HOLIDAY_TYPE":
                    simplePocket = SimplePocket.GetInstance();
                    source = simplePocket.SelectData("MD.Holiday.Select", new
                    {
                        //COMP_CD = _prdCalnArgs.PrdCalnModelArgs.Select_Main_Comp_Code,
                        //PLANT_CD = _prdCalnArgs.PrdCalnModelArgs.Select_Main_Plant_Code,
                        WORK_TYPE = grv.GetRowCellValue(e.RowHandle, colWORK_TYPE)

                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "Code", displayCaption: "Name");
                    break;
            }

        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var curModel = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as CalnModel;
            switch (e.Column.FieldName)
            {
                case "WORK_TYPE":
                    curModel.MD_HOLIDAY_TYPE = "";
                    break;
            }
        }

        internal void CreateCalendaer(string Year, string Month)
        {
            //생성하시겠습니까? 
            var msgResult = StrapMessageBox.Show("A001", 74, messageBoxButtons: MessageBoxButtons.YesNo);
            if (msgResult != DialogResult.Yes) return;
            //복사대상(년도 또는 월)를 확인하세요
            if (string.IsNullOrEmpty(Year))
            {
                StrapMessageBox.Show("A001", 75, messageBoxButtons: MessageBoxButtons.OK);
                return;
            }
            //복사대상(년도 또는 월)를 확인하세요
            if (string.IsNullOrEmpty(Year))
            {
                StrapMessageBox.Show("A001", 75, messageBoxButtons: MessageBoxButtons.OK);
                return;
            }
            var sp = PrdCalnPocket.GetInstance();
            sp.CreateCalendar(new CalnCreateModel()
            {
                COMP_CD = _prdCalnArgs.PrdCalnModelArgs.Select_Main_Comp_Code
                ,
                PLANT_CD = _prdCalnArgs.PrdCalnModelArgs.Select_Main_Plant_Code
                ,
                YEAR_CD = Year
                ,
                MONTH_CD = Month
            });

            //생성되었습니다 todo
            StrapMessageBox.Show("A001", 76);
        }

        //private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        //{
        //    GridView view = sender as GridView;
        //    var model =(CalnModel) view.GetRow(e.RowHandle);

        //    if (model != null)
        //    {
        //        if (model.WORK_TYPE == "WT002")
        //        {
        //            e.Appearance.ForeColor = Color.Red;
        //        }
        //    }
        //}

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            var model = (CalnModel)view.GetRow(e.RowHandle);

            if (model != null)
            {
                if (model.WORK_TYPE == "WT002")
                {
                    if (e.Column.FieldName == "WORK_DT"
                        || e.Column.FieldName == "WORK_DT_NM"
                        )
                    { 
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
