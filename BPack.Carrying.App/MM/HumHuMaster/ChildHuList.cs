using BPack.Common.Model;
using BPack.Model.App.MM.HumHuMaster;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.HumHuMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.HumHuMaster
{
    public partial class ChildHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private HumHuMasterArgs _humHuMasterArgs;
        private HumHuMasterPocket _humHuMasterPocket;

        public ChildHuList()
        {
            InitializeComponent();
        }

        public ChildHuList(HumHuMasterArgs humHuMasterArgs, HumHuMasterPocket humHuMasterPocket) : this()
        {
            _humHuMasterArgs = humHuMasterArgs;
            _humHuMasterPocket = humHuMasterPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = huModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _humHuMasterArgs,
                GridView = gridView1,
                InitModelType = typeof(HuModel),
                ModelArgs = _humHuMasterArgs.HumHuMasterModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<HumHuMasterModelArgs, HuModel>(_humHuMasterPocket.SelectChildHuModels, null, null);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((HuModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            base.SetInsertDefaultValue(model);
        }
    }
}
