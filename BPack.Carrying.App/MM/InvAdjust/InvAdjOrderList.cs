using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.InvAdjust;
using BPack.Pocket.App.MM.InvAdjust;
using BPack.Strap.EditControls;
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

namespace BPack.Carrying.App.MM.InvAdjust
{
    public partial class InvAdjOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvAdjustArgs _invAdjustArgs;
        private InvAdjustPocket _invAdjustPocket;
        private LookUpEditPocket _lep;
        public InvAdjOrderList()
        {
            InitializeComponent();
        }

        public InvAdjOrderList(InvAdjustArgs invAdjustArgs, InvAdjustPocket invAdjustPocket) : this()
        {
            this._invAdjustArgs = invAdjustArgs;
            this._invAdjustPocket = invAdjustPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _lep = LookUpEditPocket.GetInstance();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = invAdjOrderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _invAdjustArgs,
                GridView = gridView1,
                InitModelType = typeof(InvAdjOrderModel),
                ModelArgs = _invAdjustArgs.InvAdjustModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InvAdjustModelArgs, InvAdjOrderModel>(_invAdjustPocket.SelectInvOrderModels, null, null);
            _lep.SetGridColumnSysCode(colTARGET_INV_GR, "INV_GR");
            _lep.SetGridColumnSysCode(colINV_STATUS, "INV_STATUS");
        }
        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetWareHouse(colTARGET_WH_CD, Common.LoginInfo.UserInfo.CompCode, _invAdjustArgs.InvAdjustModelArgs.Select_Main_Plant_Cd);
            base.DataRefresh(args);
        }
    }
}
