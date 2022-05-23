using BPack.Common.Model;
using BPack.Model.App.MD.PrdNonOper;
using BPack.Pocket.App.MD.PrdNonOper;
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

namespace BPack.Carrying.App.MD.PrdNonOper
{
    public partial class NonOperList : StrapSubForm_OnlyOneGrid_V2
    {
        private readonly PrdNonOperArgs _prdNonOperArgs;
        private readonly PrdNonOperPocket _prdNonOperPocket;

        public NonOperList(PrdNonOperArgs prdNonOperArgs, PrdNonOperPocket prdNonOperPocket)
        {
            InitializeComponent();
            this._prdNonOperArgs = prdNonOperArgs;
            this._prdNonOperPocket = prdNonOperPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = nonOperModelBindingSource,
                FormArgs = _prdNonOperArgs,
                GridView = gridView1,
                InitModelType = typeof(NonOperModel),
                ModelArgs = _prdNonOperArgs.PrdNonOperModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdNonOperModelArgs, NonOperModel>(
                _prdNonOperPocket.SelectNonOperModels,
                _prdNonOperPocket.SaveNonOperModel,
                _prdNonOperPocket.SaveNonOperModel);

        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((NonOperModel)model).COMP_CD = _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Comp_Code;
            ((NonOperModel)model).PLANT_CD = _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Plant_Code;
            ((NonOperModel)model).NOTWORK_GROUP_CD = _prdNonOperArgs.PrdNonOperModelArgs.NOTWORK_GROUP_CD;

            base.SetInsertDefaultValue(model);
        }
    }
}
