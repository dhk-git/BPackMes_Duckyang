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
    public partial class OrgDeptList : StrapSubForm_OnlyOneGrid_V2
    {
        private OrgDeptArgs _orgDeptArgs;
        private OrgDeptPocket _orgDeptPocket;
                
        public OrgDeptList(OrgDeptArgs orgDeptArgs, OrgDeptPocket orgDeptPocket)
        {
            InitializeComponent();
            _orgDeptArgs = orgDeptArgs;
            _orgDeptPocket = orgDeptPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = gridView1,
                BindingSource = deptModelBindingSource,
                FormArgs = _orgDeptArgs,
                ModelArgs = _orgDeptArgs.orgDeptModelArgs,
                InitModelType = typeof(DeptModel),
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<OrgDeptModelArgs, DeptModel>(_orgDeptPocket.SelectDeptModels, _orgDeptPocket.SaveDeptModel, _orgDeptPocket.SaveDeptModels);
            gridView1.OptionsView.ColumnAutoWidth = true;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((DeptModel)model).COMP_CD = _orgDeptArgs.orgDeptModelArgs.Select_Comp_Code;
            ((DeptModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((DeptModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);

            base.SetInsertDefaultValue(model);
        }
    }
}
