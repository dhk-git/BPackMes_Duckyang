using BPack.Common.Model;
using BPack.Model.App.MM.MovDoc;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.MovDoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.MovDoc
{
    public partial class MovHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private MovDocArgs _movDocArgs;
        private MovDocPocket _movDocPocket;

        public MovHuList()
        {
            InitializeComponent();
        }

        public MovHuList(MovDocArgs movDocArgs, MovDocPocket movDocPocket) : this()
        {
            _movDocArgs = movDocArgs;
            _movDocPocket = movDocPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = movHuModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _movDocArgs,
                GridView = gridView1,
                InitModelType = typeof(MovHuModel),
                ModelArgs = _movDocArgs.MovDocModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<MovDocModelArgs, MovHuModel>(_movDocPocket.SelectMovHuModels, null, _movDocPocket.SaveMovHuModels);
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            if (_movDocArgs.MovDocModelArgs.Select_Mod_No == null)
            {
                StrapMessageBox.Show("품목이 선택되지 않았습니다.");
                DataRefresh(_movDocArgs);
                return;
            }
            ((MovHuModel)model).MOD_NO = _movDocArgs.MovDocModelArgs.Select_Mod_No;
            base.SetInsertDefaultValue(model);
        }

    }
}
