using BPack.Common.Model;
using BPack.Model.App.MD.QciNcr;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.QciNcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.QciNcr
{
    public partial class NcrTypeList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciNcrArgs _qciNcrArgs;
        private QciNcrPocket _qciNcrPocket;

        public NcrTypeList(QciNcrArgs qciNcrArgs, QciNcrPocket qciNcrPocket)
        {
            InitializeComponent();

            _qciNcrArgs = qciNcrArgs;
            _qciNcrPocket = qciNcrPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = qciNcrTypeModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qciNcrArgs,
                GridView = gridView1,
                InitModelType = typeof(QciNcrTypeModel),
                ModelArgs = _qciNcrArgs.QciNcrModelArgs
            });
            InitPocketDelegate<QciNcrModelArgs, QciNcrTypeModel>(_qciNcrPocket.SelectQciNcrTypeModels, _qciNcrPocket.SaveQciNcrTypeModel);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((QciNcrTypeModel)model).COMP_CD = _qciNcrArgs.QciNcrModelArgs.Select_Main_Comp_CD;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
    }
}
