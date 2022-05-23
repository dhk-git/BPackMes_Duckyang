using BPack.Pocket.App.MM.PurInboundHist;
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

namespace BPack.Carrying.App.MM.PurInboundHist
{
    public partial class PurInboundSumList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurInboundHistPocket purInboundHistPocket;

        public PurInboundSumList(PurInboundHistArgs _purInboundHistArgs)
        {
            InitializeComponent();
        }

        public PurInboundSumList(PurInboundHistArgs _purInboundHistArgs, PurInboundHistPocket purInboundHistPocket) : this(_purInboundHistArgs)
        {
            this.purInboundHistPocket = purInboundHistPocket;
        }

        //public override void InitStrap()
        //{
        //    InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
        //    {
        //        BindingSource = purInboundHistModelBindingSource,
        //        FormArgs = _purInboundHistArgs,
        //        ModelArgs = _purInboundHistArgs.PurInboundHistModelArgs,
        //        InitModelType = typeof(PurInboundHistModel),
        //        GridView = gridView1
        //    });

        //    InitPocketDelegate<PurInboundHistModelArgs, PurInboundHistModel>(_purInboundHistPocket.SelectPurInboundHistModels, null);
        //    LookUpEditHelper.SetGridColumnSysCode(colINHU_IN_STATUS, "INHU_IN_STATUS");
        //    LookUpEditHelper.SetGridColumnSysCode(colINHU_INSP_STATUS, "INHU_INSP_STATUS");
        //    //LookUpEditHelper.SetGridColumnSysCode(colITEM_TYPE_CLS, "ITEM_TYPE_CLS");
        //    colCREATE_DTTM.Visible = true;
        //}

    }
}
