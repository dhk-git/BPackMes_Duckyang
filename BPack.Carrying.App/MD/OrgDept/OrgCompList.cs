using BPack.Common.Model;
using BPack.Model.App.MD.OrgDept;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgDept;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.OrgDept
{
    public partial class OrgCompList : StrapSubForm_OnlyOneGrid_V2
    {
        private OrgDeptArgs _orgDeptArgs;
        private OrgDeptPocket _orgDeptPocket;

        public OrgCompList()
        {
            InitializeComponent();
        }

        public OrgCompList(OrgDeptArgs  orgDeptArgs, OrgDeptPocket orgDeptPocket)
        {
            InitializeComponent();

            _orgDeptArgs = orgDeptArgs;
            _orgDeptPocket = orgDeptPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = gridView1,
                BindingSource = compModelBindingSource,
                FormArgs = _orgDeptArgs,
                ModelArgs = _orgDeptArgs.orgDeptModelArgs,
                InitModelType = typeof(CompModel)
            });
            InitPocketDelegate<OrgDeptModelArgs, CompModel>(_orgDeptPocket.SelectCompModels, null);
            gridView1.OptionsView.ColumnAutoWidth = true;
        }
    }
}
