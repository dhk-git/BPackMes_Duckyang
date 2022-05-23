using BPack.Common.Model;
using BPack.CommonMes.Helpers;
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
    public partial class NonOperGroup : StrapSubForm_OnlyOneGrid_V2
    {
        public event EventHandler DataCRUD_Refersh;

        PrdNonOperArgs _prdNonOperArgs;
        PrdNonOperPocket _PrdNonOperPocket;
        public NonOperGroup(PrdNonOperArgs prdNonOperArgs, PrdNonOperPocket prdNonOperPocket)
        {
            InitializeComponent();
            _prdNonOperArgs = prdNonOperArgs;
            _PrdNonOperPocket = prdNonOperPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();

            LookUpEditHelper.SetGridColumnSysCode(colWORK_STATUS, "WORK_STATUS");

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() 
            { 
                BindingSource= nonOperGroupModelBindingSource,
                 FormArgs= _prdNonOperArgs,
                 GridView = gridView1,
                InitModelType = typeof(NonOperGroupModel),
                ModelArgs = _prdNonOperArgs.PrdNonOperModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdNonOperModelArgs, NonOperGroupModel>(
                _PrdNonOperPocket.SelectNonOperGroupModels, 
                _PrdNonOperPocket.SaveNonOperGroupModel,
                _PrdNonOperPocket.SaveNonOperGroupModel);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((NonOperGroupModel)model).COMP_CD = _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Comp_Code;
            ((NonOperGroupModel)model).PLANT_CD = _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Plant_Code;

            base.SetInsertDefaultValue(model);
        }

        //public override void Delete(ArgsBase args)
        //{
        //    base.Delete(args);
        //}

        protected override void SaveSuccess(ModelBase model)
        {
            base.SaveSuccess(model);

            //상위 호출 Refesh 호출.
            DataCRUD_Refersh?.Invoke(this,null);
        }

    }
}
