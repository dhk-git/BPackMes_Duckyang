using BPack.Common.Model;
using BPack.Model.App.MD.OrgPlant;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgComp;
using BPack.Pocket.App.MD.OrgPlant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.OrgPlant
{
    public partial class OrgCompList : StrapSubForm_OnlyOneGrid_V2
    {
        private OrgPlantArgs _orgPlantArgs;
        private OrgPlantPocket _orgPlantPocket;

        public OrgCompList(OrgPlantArgs orgPlantArgs, OrgPlantPocket orgPlantPocket)
        {
            InitializeComponent();

            _orgPlantArgs = orgPlantArgs;
            _orgPlantPocket = orgPlantPocket;
        }

        public override void InitStrap()
        {
            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = compModelBindingSource,
                FormArgs = _orgPlantArgs,
                ModelArgs = _orgPlantArgs.OrgPlantModelArgs,
                InitModelType = typeof(CompModel),
                GridView = gridView1
            });
            InitPocketDelegate<OrgPlantModelArgs, CompModel>(_orgPlantPocket.SelectCompModels, null);
            gridView1.OptionsView.ColumnAutoWidth = true;
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
      
            ((CompModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((CompModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);

            base.SetInsertDefaultValue(model);
        }
    }
}
