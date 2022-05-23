using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvJisInfo;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvJisInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvJisInfo
{
    public partial class CarTypeList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvJisInfoArgs _dlvJisInfoArgs;
        private DlvJisInfoPocket _dlvJisInfoPocket;
        private JISListEditForm _jISListEditForm;

        public CarTypeList(DlvJisInfoArgs dlvJisInfoArgs, DlvJisInfoPocket dlvJisInfoPocket)
        {
            InitializeComponent();

            _dlvJisInfoArgs = dlvJisInfoArgs;
            _dlvJisInfoPocket = dlvJisInfoPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = dlvJisInfoJISModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvJisInfoArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvJisInfoJISModel),
                ModelArgs = _dlvJisInfoArgs.DlvJisInfoModelArgs
            });
            InitPocketDelegate<DlvJisInfoModelArgs, DlvJisInfoJISModel>(_dlvJisInfoPocket.SelectJISModels, _dlvJisInfoPocket.SaveJISModel);

            _jISListEditForm = new JISListEditForm(_dlvJisInfoArgs);
            gridView1.OptionsEditForm.CustomEditFormLayout = _jISListEditForm;
            gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            {
                _jISListEditForm.DataRefresh(dlvJisInfoJISModelBindingSource.Current);
            };

            LookUpEditHelper.SetGridColumnSysCode(colPRINT_WAY, "PRINT_WAY");
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((DlvJisInfoJISModel)model).COMP_CD = _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Main_Comp_CD;
            ((DlvJisInfoJISModel)model).PLANT_CD = _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Main_Plant_CD;
            ((DlvJisInfoJISModel)model).DLV_PLC_CD = _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Gate_Dlv_Plc_CD;

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
    }
}
