using BPack.Common.Model;
using BPack.Model.App.MD.EquInfo;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.EquInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.EquInfo
{
    public partial class CheckList : StrapSubForm_OnlyOneGrid_V2
    {
        EquInfoArgs _equInfoArgs;
        EquInfoPocket _equInfoPocket;

        public CheckList(EquInfoArgs equInfoArgs, EquInfoPocket equInfoPocket)
        {
            InitializeComponent();

            _equInfoArgs = equInfoArgs;
            _equInfoPocket = equInfoPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = checkModelBindingSource,
                FormArgs = _equInfoArgs,
                GridView = gridView1,
                InitModelType = typeof(EquInfoCheckModel),
                ModelArgs = _equInfoArgs.EquInfoModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<EquInfoModelArgs, EquInfoCheckModel>(_equInfoPocket.SelectCheckModels, _equInfoPocket.SaveCheckModel, _equInfoPocket.SaveCheckModels);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((EquInfoCheckModel)model).COMP_CD = _equInfoArgs.EquInfoModelArgs.Select_Main_Comp_Code;
            ((EquInfoCheckModel)model).PLANT_CD = _equInfoArgs.EquInfoModelArgs.Select_Main_Plant_Code;
            ((EquInfoCheckModel)model).EQUIP_CD = _equInfoArgs.EquInfoModelArgs.Select_Equip_Code;

            base.SetInsertDefaultValue(model);
        }
    }
}
