using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.OrgPlant;
using BPack.Pocket.App.MD.OrgPlant;
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

namespace BPack.Carrying.App.MD.OrgPlant
{
    public partial class OrgPlantWktmList : StrapSubForm_OnlyOneGrid_V2
    {
        private OrgPlantArgs _orgPlantArgs;
        private OrgPlantPocket _orgPlantPocket;

        public OrgPlantWktmList()
        {
            InitializeComponent();
        }

        public OrgPlantWktmList(OrgPlantArgs orgPlantArgs, OrgPlantPocket orgPlantPocket): this()
        {
            this._orgPlantArgs = orgPlantArgs;
            this._orgPlantPocket = orgPlantPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            //IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = plantWkModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _orgPlantArgs,
                GridView = gridView1,
                InitModelType = typeof(PlantWkModel),
                ModelArgs = _orgPlantArgs.OrgPlantModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<OrgPlantModelArgs, PlantWkModel>(_orgPlantPocket.SelectPlantWKModels, null, _orgPlantPocket.SavePlantWKModels);

            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colSTART_TM);
            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colEND_TM);


            LookUpEditHelper.SetGridColumnSysCode(colWTM_TYPE, "WTM_TYPE");
            //LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "ShiftList_WithCode", new { COMP_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code, PLANT_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Plant_Code }, "코드", "명칭");
            //LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "ShiftList_WithCode", new { COMP_CD = "1000", PLANT_CD = "1100" }, "코드", "명칭");

            //LookUpEditHelper.SetGridColumnCommonCode(colTM_NM, Common.LoginInfo.UserInfo.CompCode, "TM_NM");
           LookUpEditHelper.SetGridColumnByQuery(colTM_CD, "TMList_WithCode", new { COMP_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code }, "코드", "명칭");
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnByQuery(colTM_CD, "TMList_WithCode", new { COMP_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code }, "코드", "명칭");
            //LookUpEditHelper.SetGridColumnByQuery(colTM_CD, "ShiftList_WithCode", new { COMP_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code}, "코드", "명칭");

        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((PlantWkModel)model).COMP_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code;
            ((PlantWkModel)model).PLANT_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Plant_Code;
            ((PlantWkModel)model).VALID_DT = DateTime.Now.Date;
            ((PlantWkModel)model).VALID_DT_KEY = DateTime.Now.Date;
            base.SetInsertDefaultValue(model);
        }
    }
}
