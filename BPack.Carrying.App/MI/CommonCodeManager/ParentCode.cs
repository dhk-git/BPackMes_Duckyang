using BPack.Model.App.MI.CommonCodeManager;
using BPack.Pocket.App.MI.CommonCodeManager;

namespace BPack.Carrying.App.MI.CommonCodeManager
{
    public partial class ParentCode : Strap.FormControls.StrapSubForm_OnlyOneGrid_V2
    {
        private CommonCodeManagerArgs _commonCodeManagerArgs;
        private CommonCodeManagerPocket _commonCodeManagerPocket;

        public ParentCode()
        {
            InitializeComponent();
        }

        public ParentCode(CommonCodeManagerArgs commonCodeManagerArgs, CommonCodeManagerPocket commonCodeManagerPocket) : this()
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
                BindingSource = parentCodeModelBindingSource,
                FormArgs = _commonCodeManagerArgs,
                ModelArgs = _commonCodeManagerArgs.CommonCodeManagerModelArgs,
                InitModelType = typeof(ParentCodeModel)
            });
            InitPocketDelegate<CommonCodeManagerModelArgs, ParentCodeModel>(_commonCodeManagerPocket.SelectParentCodeModels, _commonCodeManagerPocket.SaveParentCodeModel);
        }


    }
}
