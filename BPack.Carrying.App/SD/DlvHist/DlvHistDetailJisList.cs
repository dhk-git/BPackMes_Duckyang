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
    public partial class DlvHistDetailJisList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvHistArgs _dlvHistArgs;
        private DlvHistPocket _dlvHistPocket;
        private LookUpEditPocket _lep;
        public DlvHistDetailJisList()
        {
            InitializeComponent();
        }

        public DlvHistDetailJisList(DlvHistArgs dlvHistArgs, DlvHistPocket dlvHistPocket) : this()
        {
            this._dlvHistArgs = dlvHistArgs;
            this._dlvHistPocket = dlvHistPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvHistDetailJisModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvHistArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvHistDetailJisModel),
                ModelArgs = _dlvHistArgs.DlvHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvHistModelArgs, DlvHistDetailJisModel>(_dlvHistPocket.SelectDlvHistDetailJisModels, null, null);
            _lep = LookUpEditPocket.GetInstance();
            //_lep.SetGridColumnByQuery(colGATE_CD, "DeliveryPlaceList", new
            //{
            //    DEL_FG = "N",
            //    COMP_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Comp_Cd,
            //    PLANT_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Plant_Cd
            //}, "납품장소코드", "납품장소명");
            _lep.SetGridColumnByQuery(colDLV_PLC_CD, "DeliveryPlaceList", new
            {
                DEL_FG = "N",
                COMP_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Comp_Cd,
                PLANT_CD = _dlvHistArgs.DlvHistModelArgs.Select_Main_Plant_Cd
            }, "납품장소코드", "납품장소명");
            LookUpEditHelper.SetGridColumnSysCode(colCHK_RESULT, "CHK_RESULT");
            LookUpEditHelper.SetGridColumnSysCode(colDLV_STATUS, "DLV_STATUS");
            //gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;
        }

    }
}
