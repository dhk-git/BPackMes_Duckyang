using BPack.Common.Model;
using BPack.Model.App.MD.GirType;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.GirType;
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

namespace BPack.Carrying.App.MD.GirType
{
    public partial class GirTypeList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirTypeArgs _girTypeArgs;
        private GirTypePocket _girTypePocket;

        public GirTypeList(GirTypeArgs girTypeArgs, GirTypePocket girTypePocket)
        {
            InitializeComponent();

            _girTypeArgs = girTypeArgs;
            _girTypePocket = girTypePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = typeModelBindingSource,
                FormArgs = _girTypeArgs,
                ModelArgs = _girTypeArgs.girTypeModelArgs,
                InitModelType = typeof(TypeModel),
                GridView = gridView1
            });
            InitPocketDelegate<GirTypeModelArgs, TypeModel>(_girTypePocket.SelectTypeModels, _girTypePocket.SaveTypeModel);
            LookUpEditHelper.SetGridColumnSysCode(colINOUT_CLS, "INOUT_CLS");
            LookUpEditHelper.SetGridColumnSysCode(colINOUT_TYPE, "INOUT_TYPE");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((TypeModel)model).COMP_CD = _girTypeArgs.girTypeModelArgs.Select_Main_Comp_Code;
        }
    }
}
