using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvOrderHist;
using BPack.Pocket.App.SD.DlvOrderHist;
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

namespace BPack.Carrying.App.SD.DlvOrderHist
{
    public partial class DlvOrderHistHuDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvOrderHistArgs _dlvOrderArgs;
        private DlvOrderHistPocket _dlvOrderPocket;
        public DlvOrderHistHuDetailList()
        {
            InitializeComponent();
        }
        public DlvOrderHistHuDetailList(DlvOrderHistArgs dlvOrderArgs, DlvOrderHistPocket dlvOrderPocket) : this()
        {
            this._dlvOrderArgs = dlvOrderArgs;
            this._dlvOrderPocket = dlvOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvOrderHistHuDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvOrderHistHuDetailModel),
                ModelArgs = _dlvOrderArgs.DlvOrderHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvOrderHistModelArgs, DlvOrderHistHuDetailModel>(_dlvOrderPocket.SelectDlvOrderHistHuDetailModels, null);
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);


            //LookUpEditHelper.SetGridColumnByQuery(colBP_CD, "MM.PurInbound.BpList", new
            //{
            //    COMP_CD = UserInfo.CompCode
            //}, "CODE", "NAME");


            LookUpEditHelper.SetGridBusinessPartner(colBP_CD, Common.LoginInfo.UserInfo.CompCode, false, true);

            LookUpEditHelper.SetGridColumnByQuery(colWH_CD, "WareHouses_WithCode"
                , new
                {
                    COMP_CD = UserInfo.CompCode
                    ,
                    PLANT_CD = UserInfo.PlantCode
                }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colLOC_CD, "Locations_WithCode"
                , new
                {
                    COMP_CD = UserInfo.CompCode
                    ,
                    PLANT_CD = UserInfo.PlantCode
                    ,
                    WH_CD = ""
                }
                , "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup",
                 new
                 {
                     COMP_CD = UserInfo.CompCode,
                     PLANT_CD = UserInfo.PlantCode,
                     ITEM_GR_CLS = "ITEM_GR_1"
                 }, "제품군", "제품군");
        }
    }
}
