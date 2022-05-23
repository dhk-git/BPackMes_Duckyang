using BPack.Common.Model;
using BPack.Model.App.MI.CommonCodeManager;
using BPack.Pocket.App.MI.CommonCodeManager;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MI.CommonCodeManager
{
    public partial class ChildCode : Strap.FormControls.StrapSubForm_OnlyOneGrid_V2
    {

        private CommonCodeManagerArgs _commonCodeManagerArgs;
        private CommonCodeManagerPocket _commonCodeManagerPocket;

        public ChildCode()
        {
            InitializeComponent();
        }


        public ChildCode(CommonCodeManagerArgs commonCodeManagerArgs, CommonCodeManagerPocket commonCodeManagerPocket) : this()
        {
            _commonCodeManagerArgs = commonCodeManagerArgs;
            _commonCodeManagerPocket = commonCodeManagerPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = gridView1,
                BindingSource = childCodeModelBindingSource,
                FormArgs = _commonCodeManagerArgs,
                ModelArgs = _commonCodeManagerArgs.CommonCodeManagerModelArgs,
                InitModelType = typeof(ChildCodeModel),
                ExcelUploadModelType = null,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<CommonCodeManagerModelArgs, ChildCodeModel>(_commonCodeManagerPocket.SelectChildeCodeModels, _commonCodeManagerPocket.SaveChildeCodeModel, _commonCodeManagerPocket.SaveChildeCodeModels);
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ChildCodeModel)model).P_CODE = _commonCodeManagerArgs.CommonCodeManagerModelArgs.Select_PCode;
            base.SetInsertDefaultValue(model);
        }

        protected override void SetUpdateDefaultValue(ModelBase model)
        {
            base.SetUpdateDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            ParentCodeModel parentCodeModel = args.SelectedModelArgsBase.SelectedModelBase as ParentCodeModel;
            colVALUE_1.Caption = string.IsNullOrWhiteSpace(parentCodeModel.VALUE_1_DESC) ? "값1" : colVALUE_1.Caption = parentCodeModel.VALUE_1_DESC;
            colVALUE_2.Caption = string.IsNullOrWhiteSpace(parentCodeModel.VALUE_2_DESC) ? "값2" : colVALUE_2.Caption = parentCodeModel.VALUE_2_DESC;
            colVALUE_3.Caption = string.IsNullOrWhiteSpace(parentCodeModel.VALUE_3_DESC) ? "값3" : colVALUE_3.Caption = parentCodeModel.VALUE_3_DESC;
            colVALUE_4.Caption = string.IsNullOrWhiteSpace(parentCodeModel.VALUE_4_DESC) ? "값4" : colVALUE_4.Caption = parentCodeModel.VALUE_4_DESC;
            colVALUE_5.Caption = string.IsNullOrWhiteSpace(parentCodeModel.VALUE_5_DESC) ? "값5" : colVALUE_5.Caption = parentCodeModel.VALUE_5_DESC;
            base.DataRefresh(args);
        }
    }
}
