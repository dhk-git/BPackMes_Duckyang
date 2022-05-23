using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PO.Mrp;
using BPack.Pocket.App.PO.Mrp;
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

namespace BPack.Carrying.App.PO.Mrp
{
    public partial class PorList : StrapSubForm_OnlyOneGrid_V2
    {
        private MrpArgs _mrpArgs;
        private MrpPocket _mrpPocket;

        public PorList()
        {
            InitializeComponent();
        }

        public PorList(MrpArgs mrpArgs, MrpPocket mrpPocket) : this()
        {
            this._mrpArgs = mrpArgs;
            this._mrpPocket = mrpPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _mrpArgs,
                GridView = gridView1,
                InitModelType = typeof(PorModel),
                ModelArgs = _mrpArgs.MrpModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<MrpModelArgs, PorModel>(_mrpPocket.SelectPorModels, _mrpPocket.SavePorModel);
            LookUpEditHelper.SetGridColumnByQuery(colBP_CD, "BusinessPartner_IsPur_Sales", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                IS_PURCHASE = "1",
                IS_SALES = "0"
            }, "CODE", "NAME");

        }
        public override void AddNew(ArgsBase args)
        {
            if (_mrpArgs.MrpModelArgs.Select_Mrh_Status != null && !_mrpArgs.MrpModelArgs.Select_Mrh_Status.Equals("WAIT")) //MRP 헤더가 WAIT 인거만 추가 생성 가능하다.
            {
                StrapMessageBox.Show("A002", 38); //이미 사용된 데이터입니다. 자재소요계획 재생성 혹은 구매요청서 취소후 일괄등록 가능합니다.
                return;
            }

            base.AddNew(args);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((PorModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((PorModel)model).POR_STATUS = "WAIT";
            ((PorModel)model).POR_DT = DateTime.Now.Date;
            ((PorModel)model).POR_CREATE_CLS = "MRP";
            ((PorModel)model).MRH_NO = _mrpArgs.MrpModelArgs.Select_Mrh_No;
            base.SetInsertDefaultValue(model);
        }
    }
}
