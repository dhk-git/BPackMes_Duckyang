using BPack.Common.Model;
using BPack.Model.App.MD.BpaInfo;
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
    public partial class ContactList : StrapSubForm_OnlyOneGrid_V2
    {
        private BpaInfoArgs _bpaInfoArgs;
        private BpaInfoPocket _bpaInfoPocket;

        public ContactList(BpaInfoArgs bpaInfoArgs, BpaInfoPocket bpaInfoPocket)
        {
            InitializeComponent();
            _bpaInfoArgs = bpaInfoArgs;
            _bpaInfoPocket = bpaInfoPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = contGrv,
                BindingSource = contModelBindingSource,
                FormArgs = _bpaInfoArgs,
                ModelArgs = _bpaInfoArgs.bpaInfoModelArgs,
                InitModelType = typeof(Model.App.MD.BpaInfo.ContModel),
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<Model.App.MD.BpaInfo.BpaInfoModelArgs, Model.App.MD.BpaInfo.ContModel>(_bpaInfoPocket.SelectContModels, _bpaInfoPocket.SaveContModel, _bpaInfoPocket.SaveContModels);
            //contGrv.OptionsView.ColumnAutoWidth = true;
        }


       /* public ContactList(BpaInfoArgs bpaInfoArgs, BpaInfoPocket bpaInfoPocket):this()
        {
            this._bpaInfoArgs = bpaInfoArgs;
            this._bpaInfoPocket = bpaInfoPocket;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = contGrv,
                BindingSource = contModelBindingSource,
                FormArgs = _bpaInfoArgs,
                ModelArgs = _bpaInfoArgs.bpaInfoModelArgs,
                InitModelType = typeof(Model.App.MD.BpaInfo.ContModel)
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<Model.App.MD.BpaInfo.BpaInfoModelArgs, Model.App.MD.BpaInfo.ContModel>(_bpaInfoPocket.SelectContModels, _bpaInfoPocket.SaveContModel);
            contGrv.OptionsView.ColumnAutoWidth = true;
        }*/

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ContModel)model).COMP_CD = _bpaInfoArgs.bpaInfoModelArgs.Select_Comp_Cd;
            ((ContModel)model).BP_CD = _bpaInfoArgs.bpaInfoModelArgs.Select_Bp_Cd;
            ((ContModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((ContModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);

            base.SetInsertDefaultValue(model);
        }
    }
}
