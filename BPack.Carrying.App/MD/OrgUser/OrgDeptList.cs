using BPack.Model.App.MD.OrgUser;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.OrgUser
{
    public partial class OrgDeptList : StrapSubForm_TreeList
    {
        private OrgUserArgs _orgUserArgs;
        private OrgUserPocket _orgUserPocket;

        public OrgDeptList(OrgUserArgs orgUserArgs, OrgUserPocket orgUserPocket)
        {
            InitializeComponent();

            _orgUserArgs = orgUserArgs;
            _orgUserPocket = orgUserPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_TreeList()
            {
                BindingSource = deptModelBindingSource,
                FormArgs = _orgUserArgs,
                ModelArgs = _orgUserArgs.orgUserModelArgs,
                InitModelType = typeof(DeptModel),
                TreeList = strapTreeList1
            });
            InitZipperDelegate<OrgUserModelArgs, DeptModel>(_orgUserPocket.SelectDeptModels, null);
            strapTreeList1.OptionsBehavior.Editable = false;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            strapTreeList1.ExpandAll();
        }
    }
}
