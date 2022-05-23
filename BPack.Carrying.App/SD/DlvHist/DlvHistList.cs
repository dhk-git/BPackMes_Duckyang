using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvHist;
using BPack.Pocket.App.SD.DlvHist;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.SD.DlvHist
{
    public partial class DlvHistList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvHistArgs _dlvHistArgs;
        private DlvHistPocket _dlvHistPocket;
        private LookUpEditPocket _lep;

        public DlvHistList()
        {
            InitializeComponent();
        }

        public DlvHistList(DlvHistArgs dlvHistArgs, DlvHistPocket dlvHistPocket) : this()
        {
            this._dlvHistArgs = dlvHistArgs;
            this._dlvHistPocket = dlvHistPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvHistModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvHistArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvHistModel),
                ModelArgs = _dlvHistArgs.DlvHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvHistModelArgs, DlvHistModel>(_dlvHistPocket.SelectDlvHistModels, null, null);
            _lep = LookUpEditPocket.GetInstance();
            _lep.SetGridColumnByQuery(colDLV_PLC_CD, "DeliveryPlaceList", new
            {
                DEL_FG = "N",
                COMP_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Comp_Cd,
                PLANT_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Plant_Cd
            }, "납품장소코드", "납품장소명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroupDetail", new
            {
                COMP_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Comp_Cd,
                PLANT_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Plant_Cd,
                ITEM_GR_CLS = "ITEM_GR_1"
            }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "ItemGroupDetail", new
            {
                COMP_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Comp_Cd,
                PLANT_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Plant_Cd,
                ITEM_GR_CLS = "ITEM_GR_2"
            }, "CODE", "NAME");

            _lep.SetGridColumnSysCode(colDLV_TYPE, "DLV_TYPE");
        }

        public override void DataRefresh(ArgsBase args)
        {
            //if (_dlvHistArgs.DlvHistModelArgs.Select_Main_Req_Cls == "ORDER")
            //{
            //    colREQ_DT.Visible = true;
            //    colDLV_DT.Visible = false;
            //    colREQ_DT.VisibleIndex = 0;
            //}
            //else
            //{
            //    colREQ_DT.Visible = false;
            //    colDLV_DT.Visible = true;
            //    colDLV_DT.VisibleIndex = 0;
            //}
            base.DataRefresh(args);
        }
    }
}
