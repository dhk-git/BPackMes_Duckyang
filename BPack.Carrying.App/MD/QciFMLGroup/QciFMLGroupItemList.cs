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
    public partial class QciFMLGroupItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciFMLGroupArgs _qciFMLGroupArgs;
        private QciFMLGroupPocket _qciFMLGroupPocket;
        private QciFMLGroupItemEditForm _qciFMLGroupItemEditForm;
        public QciFMLGroupItemList(QciFMLGroupArgs qciFMLGroupArgs, QciFMLGroupPocket qciFMLGroupPocket)
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
                BindingSource = qciFMLGroupItemModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qciFMLGroupArgs,
                GridView = gridView1,
                InitModelType = typeof(QciFMLGroupItemModel),
                ModelArgs = _qciFMLGroupArgs.QciFMLGroupModelArgs
            });
            InitPocketDelegate<QciFMLGroupModelArgs, QciFMLGroupItemModel>(_qciFMLGroupPocket.SelectQciFMLGroupItemModels, _qciFMLGroupPocket.SaveQciFMLGroupItemModel);

            _qciFMLGroupItemEditForm = new QciFMLGroupItemEditForm(_qciFMLGroupArgs);
            gridView1.OptionsEditForm.CustomEditFormLayout = _qciFMLGroupItemEditForm;
            gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            {
                _qciFMLGroupItemEditForm.DataRefresh(qciFMLGroupItemModelBindingSource.Current);
            };
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((QciFMLGroupItemModel)model).COMP_CD = _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Comp_CD;
            ((QciFMLGroupItemModel)model).PLANT_CD = _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Plant_CD;
            ((QciFMLGroupItemModel)model).FML_GR = _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Type_Fml_GR;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }

    }
}
