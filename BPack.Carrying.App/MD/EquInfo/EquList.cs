using BPack.Common.Model;
using BPack.CommonMes.Helpers;
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
    public partial class EquList : StrapSubForm_OnlyOneGrid_V2
    {
        EquInfoArgs _equInfoArgs;
        EquInfoPocket _equInfoPocket;

        public EquList(EquInfoArgs equInfoArgs, EquInfoPocket equInfoPocket)
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
                BindingSource = equModelBindingSource,
                FormArgs = _equInfoArgs,
                GridView = gridView1,
                InitModelType = typeof(EquInfoEquipModel),
                ModelArgs = _equInfoArgs.EquInfoModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<EquInfoModelArgs, EquInfoEquipModel>(_equInfoPocket.SelectEquModels, _equInfoPocket.SaveEquModel, _equInfoPocket.SaveEquModels);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((EquInfoEquipModel)model).COMP_CD = _equInfoArgs.EquInfoModelArgs.Select_Main_Comp_Code;
            ((EquInfoEquipModel)model).PLANT_CD = _equInfoArgs.EquInfoModelArgs.Select_Main_Plant_Code;

            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnCommonCode(colEQUIP_CLS, _equInfoArgs.EquInfoModelArgs.Select_Main_Comp_Code, "EQUIP_CLS");

            base.DataRefresh(args);
        }
    }
}
