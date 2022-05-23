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
    public partial class HuList : StrapSubForm_OnlyOneGrid_V2
    {
        private HumHuMasterArgs _humHuMasterArgs;
        private HumHuMasterPocket _humHuMasterPocket;

        public HuList()
        {
            InitializeComponent();
        }

        public HuList(HumHuMasterArgs humHuMasterArgs, HumHuMasterPocket humHuMasterPocket) : this()
        {
            _humHuMasterArgs = humHuMasterArgs;
            _humHuMasterPocket = humHuMasterPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = huModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _humHuMasterArgs,
                GridView = gridView1,
                InitModelType = typeof(HuModel),
                ModelArgs = _humHuMasterArgs.HumHuMasterModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<HumHuMasterModelArgs, HuModel>(_humHuMasterPocket.SelectHuModels, _humHuMasterPocket.SaveHuModel, _humHuMasterPocket.SaveHuModels);
            
            
            //Core에서 수정되지 않아 강제 적용 20220503 곽동혁
            gridView1.OptionsBehavior.Editable = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                if (col != colIsCheck)
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }
            
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((HuModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            base.SetInsertDefaultValue(model);
        }
    }
}
