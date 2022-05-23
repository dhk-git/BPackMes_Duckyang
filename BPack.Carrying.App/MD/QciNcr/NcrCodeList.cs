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
    public partial class NcrCodeList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciNcrArgs _qciNcrArgs;
        private QciNcrPocket _qciNcrPocket;

        public NcrCodeList(QciNcrArgs qciNcrArgs, QciNcrPocket qciNcrPocket)
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
                BindingSource = qciNcrCodeModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qciNcrArgs,
                GridView = gridView1,
                InitModelType = typeof(QciNcrCodeModel),
                ModelArgs = _qciNcrArgs.QciNcrModelArgs
            });
            InitPocketDelegate<QciNcrModelArgs, QciNcrCodeModel>(_qciNcrPocket.SelectQciNcrCodeModels, _qciNcrPocket.SaveQciNcrCodeModel);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((QciNcrCodeModel)model).COMP_CD = _qciNcrArgs.QciNcrModelArgs.Select_Main_Comp_CD;
            ((QciNcrCodeModel)model).NCR_TYPE = _qciNcrArgs.QciNcrModelArgs.Select_Type_Ncr_Type;
        }
        
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
    }
}
