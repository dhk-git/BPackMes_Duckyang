using BPack.Common.Model;
using BPack.Model.App.MD.OrgComp;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgComp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.OrgComp
{
    public partial class OrgCompList : StrapSubForm_OnlyOneGrid_V2
    {
        private OrgCompArgs _orgCompArgs;
        private OrgCompPocket _orgCompPocket;

        public OrgCompList(OrgCompArgs orgCompArgs, OrgCompPocket orgCompPocket)
        {
            InitializeComponent();

            _orgCompArgs = orgCompArgs;
            _orgCompPocket = orgCompPocket;
        }

        public override void InitStrap()
        {
            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = gridView1,
                BindingSource = compModelBindingSource,
                FormArgs = _orgCompArgs,
                ModelArgs = _orgCompArgs.orgCompModelArgs,
                InitModelType = typeof(CompModel)
            });
            InitPocketDelegate<OrgCompModelArgs, CompModel>(_orgCompPocket.SelectCompModels, _orgCompPocket.SaveCompModel);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            ((CompModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((CompModel)model).VALID_TO_DT = new DateTime(9999,12,31);
        }
    }
}
