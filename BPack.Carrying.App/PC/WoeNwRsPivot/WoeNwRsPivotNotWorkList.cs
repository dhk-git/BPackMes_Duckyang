using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WoeNwRsPivot;
using BPack.Pocket.App.PC.WoeNwRsPivot;
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

namespace BPack.Carrying.App.PC.WoeNwRsPivot
{
    public partial class WoeNwRsPivotNotWorkList : StrapSubForm_OnlyOneGrid_V2
    {
        
        private WoeNwRsPivotArgs _woeNwRsPivotArgs;
        private WoeNwRsPivotPocket _woeNwRsPivotPocket;

        public WoeNwRsPivotNotWorkList()
        {
            InitializeComponent();
        }

        public WoeNwRsPivotNotWorkList(WoeNwRsPivotArgs woeNwRsPivotArgs, WoeNwRsPivotPocket woeNwRsPivotPocket):this()
        {
            this._woeNwRsPivotArgs = woeNwRsPivotArgs;
            this._woeNwRsPivotPocket = woeNwRsPivotPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = nwRsPivotNotworkModelBindingSource,
                FormArgs = _woeNwRsPivotArgs,
                ModelArgs = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs,
                InitModelType = typeof(NwRsPivotNotworkModel),
                StrapEditMode = StrapEditMode.Batch,
                GridView = gridView1
            });
            InitPocketDelegate<WoeNwRsPivotModelArgs, NwRsPivotNotworkModel>(
               _woeNwRsPivotPocket.SelectNwRsPivotNotworkModels
               , _woeNwRsPivotPocket.SaveNwRsPivotNotworkModel
               , _woeNwRsPivotPocket.SaveNwRsPivotNotworkModels
               );

            RepositoryItemHelpers
                .SetRepositoryItemTimeSpanEdit(colSTART_DTTM,editMask:"HH:mm:ss",displayFormatString:"HH:mm:ss");
            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colEND_DTTM, editMask: "HH:mm:ss", displayFormatString: "HH:mm:ss");

            DataRefreshLookUpEdit();

        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            ((NwRsPivotNotworkModel)model).COMP_CD
                = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd;
            ((NwRsPivotNotworkModel)model).PLANT_CD
                = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd;
            ((NwRsPivotNotworkModel)model).WC_CD
                = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Wc_Cd;

        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            DataRefreshLookUpEdit();
        }
        private void DataRefreshLookUpEdit()
        {
            //작업장
            CommonMes.Helpers.LookUpEditHelper.SetWorkCenter(colWC_CD,
                   _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd
                   , _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd
                   );

            //근무조 그룹
            LookUpEditHelper.SetGridColumnByQuery(
              colSHIFT_GROUP_CD,
              "MD.SHIH.Select",
              new
              {
                  COMP_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd,
                  PLANT_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd
              }
              , "근무조그룹"
              , "근무조그룹명");
            //근무조 상세 
            LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "MD.SHIDGroup.Select",
                new
                {
                    COMP_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd,
                    PLANT_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd,
                    SHIFT_GROUP_CD = ""
                }
                , "Code", "Name"
                );
            //비가동 그룹
            //NotWork Group
            LookUpEditHelper.SetGridColumnByQuery(
                colNOTWORK_GROUP_CD,
                "MD.NOTH.Select",
                new
                {
                    COMP_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd,
                    PLANT_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd,
                    WORK_STATUS = "",
                }
                , "CODE", "NAME");

            //비가동 상세
            LookUpEditHelper.SetGridColumnByQuery(
                colNOTWORK_CD,
                "MD.NOTD.Select",
                new
                {
                    COMP_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd,
                    PLANT_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd,
                    NOTWORK_GROUP_CD = "",
                }
                , "CODE", "NAME");

        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var grv = sender as GridView;
            var sp = SimplePocket.GetInstance();
            switch (e.Column.FieldName)
            {
                //근무조그룹
                case "SHIFT_GROUP_CD":
                    string _workdt = grv.GetRowCellValue(e.RowHandle, "WORK_DT")?.ToString();
                    if (string.IsNullOrEmpty(_workdt))
                    {
                        //기준 일자를 선택하세요
                        StrapMessageBox.Show("A001", 113);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Code");
                        dt.Columns.Add("Name");
                        e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: dt, valueCaption: "CODE", displayCaption: "NAME");

                        return; 
                    }
                    if (!DateTime.TryParse(_workdt, out DateTime work_dt))
                    {
                        //기준 일자를 선택하세요
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Code");
                        dt.Columns.Add("Name");
                        e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: dt, valueCaption: "CODE", displayCaption: "NAME");

                        StrapMessageBox.Show("A001", 113);
                        return;
                    }
                    var source = sp.SelectData("MD.SHIH.WorkdtWc.Select", new
                    {
                        COMP_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd,
                        PLANT_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd,
                        WORK_DT = work_dt,
                        WC_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Wc_Cd
                    });
                    if (source == null || source.Rows.Count == 0)
                    {
                        //생산달력을 확인하세요.
                        StrapMessageBox.Show("A001", 114);
                        return;
                    }
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "CODE", displayCaption: "NAME");
                    break;
                case "SHIFT_CD":
                    string _shiftGroupCd = grv.GetRowCellValue(e.RowHandle, "SHIFT_GROUP_CD")?.ToString();
                    if (string.IsNullOrEmpty(_shiftGroupCd))
                    {
                        //근무조 그룹을 선택하세요
                        StrapMessageBox.Show("A001", 115);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Code");
                        dt.Columns.Add("Name");
                        e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: dt, valueCaption: "CODE", displayCaption: "NAME");

                        return;
                    }
                    var source4= sp.SelectData("MD.SHIDGroup.Select", new
                    {
                        COMP_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd,
                        PLANT_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd,
                        SHIFT_GROUP_CD = _shiftGroupCd
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source4, valueCaption: "CODE", displayCaption: "NAME");
                    break;
                case "NOTWORK_GROUP_CD":
                    //var sp = SimplePocket.GetInstance();
                    var source2 = sp.SelectData("MD.NOTH.Select", new
                    {
                        COMP_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd,
                        PLANT_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd,
                        WORK_STATUS = "WS002" //비가동
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source2, valueCaption: "CODE", displayCaption: "NAME");
                    break;
                case "NOTWORK_CD":
                    var NotworkGroup = grv.GetRowCellValue(e.RowHandle, "NOTWORK_GROUP_CD");
                    var sp2 = SimplePocket.GetInstance();
                    var source3 = sp2.SelectData("MD.NOTD.Select", new
                    {
                        COMP_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd,
                        PLANT_CD = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd,
                        NOTWORK_GROUP_CD = NotworkGroup
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source3, valueCaption: "CODE", displayCaption: "NAME");
                    break;
            }

        }

    }
}
