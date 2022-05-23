using BPack.Common.Model;
using BPack.Model.App.MM.PurInboundHist;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.PurInboundHist;
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

namespace BPack.Carrying.App.MM.PurInboundHist
{
    public partial class PurInboundHistList : StrapSubForm_OnlyOneGrid_V2
    {
        PurInboundHistArgs _purInboundHistArgs;
        PurInboundHistPocket _purInboundHistPocket;

        public PurInboundHistList(PurInboundHistArgs purInboundHistArgs, PurInboundHistPocket purInboundHistPocket)
        {
            InitializeComponent();

            _purInboundHistArgs = purInboundHistArgs;
            _purInboundHistPocket = purInboundHistPocket;

        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = purInboundHistModelBindingSource,
                FormArgs = _purInboundHistArgs,
                ModelArgs = _purInboundHistArgs.PurInboundHistModelArgs,
                InitModelType = typeof(PurInboundHistModel),
                GridView = gridView1
            });
            
            InitPocketDelegate<PurInboundHistModelArgs, PurInboundHistModel>(_purInboundHistPocket.SelectPurInboundHistModels, null);
            LookUpEditHelper.SetGridColumnSysCode(colINHU_IN_STATUS, "INHU_IN_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colINHU_INSP_STATUS, "INHU_INSP_STATUS");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _purInboundHistArgs.PurInboundHistModelArgs.Select_Main_Plant_Cd , ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _purInboundHistArgs.PurInboundHistModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_2" }, "CODE", "NAME");
            //LookUpEditHelper.SetGridColumnSysCode(colITEM_TYPE_CLS, "ITEM_TYPE_CLS");
            colCREATE_DTTM.Visible = true;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            //((PurInboundHistModel)model).COMP_CD = _purInboundHistArgs.PurInboundHistModelArgs.Select_Main_Comp_Code;
        }
    }
}
