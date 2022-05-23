using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.MaterialRequest;
using BPack.Pocket.App.PC.MaterialRequest;
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

namespace BPack.Carrying.App.PC.MaterialRequest
{
    public partial class MrqdHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private MaterialRequestArgs _materialRequestArgs;
        private MaterialRequestPocket _materialRequestPocket;
        public MrqdHuList(MaterialRequestArgs materialRequestArgs, MaterialRequestPocket materialRequestPocket)
        {
            InitializeComponent();
            _materialRequestArgs = materialRequestArgs;
            _materialRequestPocket = materialRequestPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            //IsBestFitStrapGrid = true;
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {

                BindingSource = mrqdHuListModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _materialRequestArgs,
                GridView = gridView1,
                InitModelType = typeof(MrqdHuListModel),
                ModelArgs = _materialRequestArgs.MaterialRequestModelArgs,
                StrapEditMode = StrapEditMode.Default

            }) ;
            InitPocketDelegate<MaterialRequestModelArgs, MrqdHuListModel>
               (_materialRequestPocket.SelectMrqdHuListModels
                   , _materialRequestPocket.SaveMrqdHuListModel
                   , _materialRequestPocket.SaveMrqdHuListModels
               );

            colIsCheck.VisibleIndex = 0;
            colIsCheck.Visible = false;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnSysCode(colMRD_HU_STATUS, "MRD_HU_STATUS");

            //창고
            LookUpEditHelper.SetGridColumnByQuery(
           colWH_CD,
           "WareHouses_WithCode",
           new
           {
               COMP_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD,
               PLANT_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD,
           }
           , "창고"
           , "창고명");

            LookUpEditHelper.SetWareHouse(
                colWH_CD,
                _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD,
                _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD
                );

            LookUpEditHelper.SetLocation(colLOC_CD,
                _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD,
                _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD
                , "");

            LookUpEditHelper.SetGridColumnSysCode(colHU_INSP_STATUS, "HU_INSP_STATUS");
        }

        public List<MrqdHuListModel> GetCheckedData()
        {
            List<MrqdHuListModel> models = new List<MrqdHuListModel>();
            var selectedRowHandlers = gridView1.GetSelectedRows();
            foreach (var selectedRowHandler in selectedRowHandlers)
            {
                models.Add(gridView1.GetRow(selectedRowHandler) as MrqdHuListModel);
            }
            //checkedBarcodeModels = gridView1.GetSelectedRows();
            return models;

        }

        internal void SaveMrqdHuListModel(List<MrqdHuListModel> data)
        {

            _materialRequestPocket.SaveMrqdHuListModels(data);

        }

        public void CleanSelectRow()
        {
            gridView1.ClearSelection();
        }

    }
}
