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
    public partial class MovItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private MovDocArgs _movDocArgs;
        private MovDocPocket _movDocPocket;

        public MovItemList()
        {
            InitializeComponent();
        }

        public MovItemList(MovDocArgs movDocArgs, MovDocPocket movDocPocket) : this()
        {
            _movDocArgs = movDocArgs;
            _movDocPocket = movDocPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = movItemModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _movDocArgs,
                GridView = gridView1,
                InitModelType = typeof(MovItemModel),
                ModelArgs = _movDocArgs.MovDocModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<MovDocModelArgs, MovItemModel>(_movDocPocket.SelectMovItemModels, null ,_movDocPocket.SaveMovItemModels);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((MovItemModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((MovItemModel)model).MOV_NO = _movDocArgs.MovDocModelArgs.Select_Mov_No;
            ((MovItemModel)model).PLANT_CD = _movDocArgs.MovDocModelArgs.Select_Plant_Cd;
            base.SetInsertDefaultValue(model);
        }

    }
}
