using BPack.Common.Model;
using BPack.Model.App.MD.QciFMLGroup;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.QciFMLGroup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.QciFMLGroup
{
    public partial class QciFMLGroupList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciFMLGroupArgs _qciFMLGroupArgs;
        private QciFMLGroupPocket _qciFMLGroupPocket;

        public QciFMLGroupList(QciFMLGroupArgs qciFMLGroupArgs, QciFMLGroupPocket qciFMLGroupPocket)
        {
            InitializeComponent();

            _qciFMLGroupArgs = qciFMLGroupArgs;
            _qciFMLGroupPocket = qciFMLGroupPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource =  qciFMLGroupModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qciFMLGroupArgs,
                GridView = gridView1,
                InitModelType = typeof(QciFMLGroupModel),
                ModelArgs = _qciFMLGroupArgs.QciFMLGroupModelArgs
            });
            InitPocketDelegate<QciFMLGroupModelArgs, QciFMLGroupModel>(_qciFMLGroupPocket.SelectQciFMLGroupModels, _qciFMLGroupPocket.SaveQciFMLGroupModel);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((QciFMLGroupModel)model).COMP_CD = _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Comp_CD;
            ((QciFMLGroupModel)model).PLANT_CD = _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Plant_CD;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
    }
}
