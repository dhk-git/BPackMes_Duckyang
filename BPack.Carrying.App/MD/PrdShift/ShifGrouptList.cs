using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdShift;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdShift;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MD.PrdShift
{
    public partial class ShifGrouptList : StrapSubForm_OnlyOneGrid_V2
    {
        PrdShiftArgs _prdShiftArgs;
        PrdShiftPocket _prdShiftPocket;

        public ShifGrouptList(PrdShiftArgs prdShiftArgs, PrdShiftPocket prdShiftPocket)
        {
            InitializeComponent();

            _prdShiftArgs = prdShiftArgs;
            _prdShiftPocket = prdShiftPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();



            LookUpEditHelper.SetGridColumnSysCode(colWORK_TYPE, "WORK_TYPE");

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = shiftModelBindingSource,
                FormArgs = _prdShiftArgs,
                GridView = gridView1,
                InitModelType = typeof(ShiftGroupModel),
                ModelArgs = _prdShiftArgs.PrdShiftModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdShiftModelArgs, ShiftGroupModel>(_prdShiftPocket.SelectShiftGroupModels, _prdShiftPocket.SaveShiftGroupModel, _prdShiftPocket.SaveShiftGroupModels);

        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ShiftGroupModel)model).COMP_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code;
            ((ShiftGroupModel)model).PLANT_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code;
            ((ShiftGroupModel)model).WORK_TYPE = "WT001";

            base.SetInsertDefaultValue(model);
        }
        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnSysCode(colWORK_TYPE, "WORK_TYPE");
            base.DataRefresh(args);
        }

    }
}
