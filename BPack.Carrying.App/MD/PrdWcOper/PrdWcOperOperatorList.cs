using BPack.Common.Model;
using BPack.Model.App.MD.PrdWcOper;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdWcOper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;
using BPack.Common.Pocket;
using BPack.Strap.EditControls;

namespace BPack.Carrying.App.MD.PrdWcOper
{
    public partial class PrdWcOperOperatorList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdWcOperPocket pdWcOperPocket;
        private PrdWcOperArgs pdWcOperArgs;
        private LookUpEditPocket _lep;

        public PrdWcOperOperatorList()
        {
            InitializeComponent();
        }

        public PrdWcOperOperatorList(PrdWcOperArgs prdWorkCenterArgs, PrdWcOperPocket prdWorkCenterPocket) : this()
        {
            pdWcOperArgs = prdWorkCenterArgs;
            pdWcOperPocket = prdWorkCenterPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = prdWcOperOperatorModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = pdWcOperArgs,
                GridView = gridView1,
                InitModelType = typeof(PrdWcOperOperatorModel),
                ModelArgs = pdWcOperArgs.PrdWcOperModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdWcOperModelArgs, PrdWcOperOperatorModel>(pdWcOperPocket.SelectPrdWcOperOperatorModels, pdWcOperPocket.SavePrdWcOperOperatorModel, pdWcOperPocket.SavePrdWcOperOperatorModels);
            _lep = LookUpEditPocket.GetInstance();
            _lep.SetGridColumnByQuery(colOPER_USER_ID, "AllUsers", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "사용자ID", "사용자명");
            ((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)colOPER_USER_ID.ColumnEdit).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((PrdWcOperOperatorModel)model).COMP_CD = pdWcOperArgs.PrdWcOperModelArgs.Select_Main_Comp_Code;
            ((PrdWcOperOperatorModel)model).PLANT_CD = pdWcOperArgs.PrdWcOperModelArgs.Select_Main_Plant_Code;
            ((PrdWcOperOperatorModel)model).WC_CD = pdWcOperArgs.PrdWcOperModelArgs.Select_WorkCenter_Code;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
    }
}
