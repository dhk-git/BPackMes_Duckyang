using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvLineCarType;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvLineCarType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvLineCarType
{
    public partial class CarTypeList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvLineCarTypeArgs _dlvLineCarTypeArgs;
        private DlvLineCarTypePocket _dlvLineCarTypePocket;

        public CarTypeList(DlvLineCarTypeArgs dlvLineCarTypeArgs, DlvLineCarTypePocket dlvLineCarTypePocket)
        {
            InitializeComponent();

            _dlvLineCarTypeArgs = dlvLineCarTypeArgs;
            _dlvLineCarTypePocket = dlvLineCarTypePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = dlvLineCarTypeModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvLineCarTypeArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvLineCarTypeModel),
                ModelArgs = _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs
            });
            InitPocketDelegate<DlvLineCarTypeModelArgs, DlvLineCarTypeModel>(_dlvLineCarTypePocket.SelectCarTypeModels, _dlvLineCarTypePocket.SaveCarTypeModel);
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((DlvLineCarTypeModel)model).COMP_CD = _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Main_Comp_CD;
            ((DlvLineCarTypeModel)model).PLANT_CD = _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Main_Plant_CD;
            ((DlvLineCarTypeModel)model).DLV_PLC_CD = _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Gate_Dlv_Plc_CD;

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Main_Comp_CD, PLANT_CD = _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Main_Plant_CD, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");
        }
    }
}
