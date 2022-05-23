using BPack.Common.Model;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.BpaInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.BpaInfo
{
    public partial class BpList : StrapSubForm_OnlyOneGrid_V2
    {
        private BpaInfoArgs _bpaInfoArgs;
        private BpaInfoPocket _bpaInfoPocket;

        public BpList()
        {
            InitializeComponent();
        }

        public BpList(BpaInfoArgs bpaInfoArgs, BpaInfoPocket bpaInfoPocket) : this()
        {
            _bpaInfoArgs = bpaInfoArgs;
            _bpaInfoPocket = bpaInfoPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = bpGrv,
                BindingSource = bpModelBindingSource,
                FormArgs = _bpaInfoArgs,
                ModelArgs = _bpaInfoArgs.bpaInfoModelArgs,
                InitModelType = typeof(Model.App.MD.BpaInfo.BparModel)
            });
            InitPocketDelegate<Model.App.MD.BpaInfo.BpaInfoModelArgs, Model.App.MD.BpaInfo.BparModel>(_bpaInfoPocket.SelectBparModels, _bpaInfoPocket.SaveBparModel);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((Model.App.MD.BpaInfo.BparModel)model).COMP_CD = _bpaInfoArgs.bpaInfoModelArgs.Select_Main_Comp_Cd;
            ((Model.App.MD.BpaInfo.BparModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((Model.App.MD.BpaInfo.BparModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);

            base.SetInsertDefaultValue(model);
        }
    }
}
