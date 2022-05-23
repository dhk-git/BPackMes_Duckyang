using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.MaterialRequest;
using BPack.Pocket.App.PC.MaterialRequest;
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

namespace BPack.Carrying.App.PC.MaterialRequest
{
    public partial class MrqhList : StrapSubForm_OnlyOneGrid_V2
    {
        private MaterialRequestArgs _materialRequestArgs;
        private MaterialRequestPocket _materialRequestPocket;


        public MrqhList(MaterialRequestArgs materialRequestArgs, MaterialRequestPocket materialRequestPocket)
        {
            InitializeComponent();
            this._materialRequestArgs = materialRequestArgs;
            this._materialRequestPocket = materialRequestPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = true;
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {

                BindingSource = mrqhListModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _materialRequestArgs,
                GridView = gridView1,
                InitModelType = typeof(MrqhListModel),
                ModelArgs = _materialRequestArgs.MaterialRequestModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<MaterialRequestModelArgs, MrqhListModel>
                (_materialRequestPocket.SelectMrqhListModels
                    , _materialRequestPocket.SaveMrqhListModel
                    , _materialRequestPocket.SaveMrqhListModels
                );



            //gridView1.OptionsView.ColumnAutoWidth = true;
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {

            ((MrqhListModel)model).COMP_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD;
            ((MrqhListModel)model).PLANT_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD;
            ((MrqhListModel)model).MRH_DT = DateTime.Now;
            ((MrqhListModel)model).MRH_STATUS = "WAIT";

            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnSysCode(colMRH_STATUS, "MRH_STATUS");
            LookUpEditHelper.SetWorkCenter(
                colWC_CD,
                _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD,
                _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD
                );

            gridView1.BestFitColumns();
        }
    }
}
