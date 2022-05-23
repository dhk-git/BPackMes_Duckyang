using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.EquItemCheckList;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.EquItemCheckList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.EquItemCheckList
{
    public partial class EquipList : StrapSubForm_OnlyOneGrid_V2
    {
        EquItemCheckListArgs _equItemCheckListArgs;
        EquItemCheckListPocket _equItemCheckListPocket;

        public EquipList(EquItemCheckListArgs equItemCheckListArgs, EquItemCheckListPocket equItemCheckListPocket)
        {
            InitializeComponent();

            _equItemCheckListArgs = equItemCheckListArgs;
            _equItemCheckListPocket = equItemCheckListPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = equItemCheckListEquipModelBindingSource,
                FormArgs = _equItemCheckListArgs,
                GridView = gridView1,
                InitModelType = typeof(EquItemCheckListEquipModel),
                ModelArgs = _equItemCheckListArgs.EquItemCheckListModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<EquItemCheckListModelArgs, EquItemCheckListEquipModel>(_equItemCheckListPocket.SelectEquipModels, null, null);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnCommonCode(colEQUIP_CLS, _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code, "EQUIP_CLS");

            base.DataRefresh(args);
        }
    }
}
