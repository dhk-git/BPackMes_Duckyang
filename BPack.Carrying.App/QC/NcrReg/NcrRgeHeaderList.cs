using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrReg;
using BPack.Pocket.App.QC.NcrReg;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;

namespace BPack.Carrying.App.QC.NcrReg
{
    public partial class NcrRgeHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private NcrRegArgs _ncrRegArgs;
        private NcrRegPocket _regPocket;

        public NcrRgeHeaderList()
        {
            InitializeComponent();
        }

        public NcrRgeHeaderList(NcrRegArgs ncrRegArgs, NcrRegPocket regPocket) : this()
        {
            this._ncrRegArgs = ncrRegArgs;
            this._regPocket = regPocket;

        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = ncrRegHeaderModelBindingSource,
                FormArgs = _ncrRegArgs,
                ModelArgs = _ncrRegArgs.NcrRegModelArgs,
                InitModelType = typeof(NcrRegHeaderModel),
                GridView = gridView1
            });
            InitPocketDelegate<NcrRegModelArgs, NcrRegHeaderModel>
                (_regPocket.SelectNcrRegHeaderModels, _regPocket.SaveNcrRegHeaderModel, _regPocket.SaveNcrRegHeaderModels);
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }

        /// <summary>
        /// 신규 생성시...
        /// </summary>
        /// <param name="model"></param>
        protected override void SetInsertDefaultValue(ModelBase model)
        {

            ((NcrRegHeaderModel)model).COMP_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd;
            ((NcrRegHeaderModel)model).PLANT_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Plant_Cd;
            ((NcrRegHeaderModel)model).NCH_DT = _ncrRegArgs.NcrRegModelArgs.Select_Main_Start_dt;
            base.SetInsertDefaultValue(model);
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnSysCode(colNCH_TYPE, "NCH_TYPE");
            LookUpEditHelper.SetGridColumnByQuery(colFROM_WH_CD, "WareHouses",
                new
                {
                    COMP_CD = ((NcrRegArgs)args).NcrRegModelArgs.Select_Main_Comp_Cd
                    ,
                    PLANT_CD = ((NcrRegArgs)args).NcrRegModelArgs.Select_Main_Plant_Cd
                }
                , "Code", "Name");

            LookUpEditHelper.SetGridColumnByQuery(colNCR_WH_CD, "WareHouses_NCR",
            new
            {
                COMP_CD = ((NcrRegArgs)args).NcrRegModelArgs.Select_Main_Comp_Cd
                ,
                PLANT_CD = ((NcrRegArgs)args).NcrRegModelArgs.Select_Main_Plant_Cd
            }
            , "Code", "Name");

            LookUpEditHelper.SetGridColumnSysCode(colNCH_STATUS, "NCH_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colREF_DOC_TYPE, "DOC_TYPE");

            gridView1.BestFitColumns();
        }

        internal void UpdateStatus_Confirm(List<NcrRegHeaderConfirmModel> Models)
        {
            _regPocket.ConfirmNcrRegHeaderModels(Models);
            DataRefresh(_ncrRegArgs);
        }

        internal List<NcrRegHeaderModel> GetCheckedData()
        {
            List<NcrRegHeaderModel> models = new List<NcrRegHeaderModel>();
            var selectedRowHandlers = gridView1.GetSelectedRows();
            foreach (var selectedRowHandler in selectedRowHandlers)
            {
                models.Add(gridView1.GetRow(selectedRowHandler) as NcrRegHeaderModel);
            }
            //checkedBarcodeModels = gridView1.GetSelectedRows();
            return models;
        }


    }
}
