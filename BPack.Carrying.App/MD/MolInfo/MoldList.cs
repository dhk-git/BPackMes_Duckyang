using BPack.Common.Model;
using BPack.Model.App.MD.MolInfo;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.MolInfo;
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

namespace BPack.Carrying.App.MD.MolInfo
{
    public partial class MoldList : StrapSubForm_OnlyOneGrid_V2
    {
        MolInfoArgs _molInfoArgs;
        MolInfoPocket _molInfoPocket;

        public MoldList(MolInfoArgs molInfoArgs, MolInfoPocket molInfoPocket)
        {
            InitializeComponent();

            _molInfoArgs = molInfoArgs;
            _molInfoPocket = molInfoPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = moldListModelBindingSource,
                FormArgs = _molInfoArgs,
                ModelArgs = _molInfoArgs.MolInfoModelArgs,
                InitModelType = typeof(MoldListModel),
                GridView = gridView1
            });
            InitPocketDelegate<MolInfoModelArgs, MoldListModel>(_molInfoPocket.SelectMoldListModels, _molInfoPocket.SaveMoldListModel);

            LookUpEditHelper.SetGridColumnCommonCode(colMOLD_CLS, _molInfoArgs.MolInfoModelArgs.Select_Main_Comp_Code, "MOLD_CLS");
            
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((MoldListModel)model).COMP_CD = _molInfoArgs.MolInfoModelArgs.Select_Main_Comp_Code;
            ((MoldListModel)model).PLANT_CD = _molInfoArgs.MolInfoModelArgs.Select_Main_Plant_Code;

            base.SetInsertDefaultValue(model);
        }

    }
}
