using BPack.Common.Model;
using BPack.Model.App.MD.OrgPlant;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgPlant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.OrgPlant
{
    public partial class OrgPlantList : StrapSubForm_OnlyOneGrid_V2
    {
        private OrgPlantArgs _orgPlantArgs;
        private OrgPlantPocket _orgPlantPocket;

        //private OrgPlantWktmList _orgPlantWktmList;

        public OrgPlantList()
        {
            InitializeComponent();
        }

        public OrgPlantList(OrgPlantArgs orgPlantArgs, OrgPlantPocket orgPlantPocket)
        {
            InitializeComponent();

            _orgPlantArgs = orgPlantArgs;
            _orgPlantPocket = orgPlantPocket;
        }

        public override void InitStrap()
        {
            //_orgPlantWktmList = new OrgPlantWktmList(_orgPlantArgs, _orgPlantPocket);

            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = gridView1,
                BindingSource = plantModelBindingSource,
                FormArgs = _orgPlantArgs,
                ModelArgs = _orgPlantArgs.OrgPlantModelArgs,
                InitModelType = typeof(PlantModel)
            });
            //this.ModelSelectedEvent += PlantCode_SelectedEvent;

            InitPocketDelegate<OrgPlantModelArgs, PlantModel>(_orgPlantPocket.SelectPlantModels, _orgPlantPocket.SavePlantModel);
            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colWORK_FROM_TM);
            //RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colWORK_TO_TM);
            LookUpEditHelper.SetGridColumnSysCode(colCURRENCY_TYPE, "CURRENCY_TYPE");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            ((PlantModel)model).COMP_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code;
            ((PlantModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((PlantModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);
        }
        //private void PlantCode_SelectedEvent(object sender, ArgsBase e)
        //{
        //    _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code = ((PlantModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
        //    _orgPlantArgs.OrgPlantModelArgs.Select_Main_Plant_Code = ((PlantModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
        //    //_orgPlantArgs.OrgPlantModelArgs.Select_Main_Plant_Name = strapTextEdit2.EditValue?.ToString();
        //    //_orgPlantWktmList.DataRefresh(_orgPlantArgs);
        //}

    }
}
