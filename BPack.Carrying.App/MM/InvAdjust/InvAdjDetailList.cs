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
    public partial class InvAdjDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvAdjustArgs _invAdjustArgs;
        private InvAdjustPocket _invAdjustPocket;
        private LookUpEditPocket _lep;
        public InvAdjDetailList()
        {
            InitializeComponent();
        }

        public InvAdjDetailList(InvAdjustArgs invAdjustArgs, InvAdjustPocket invAdjustPocket) : this()
        {
            this._invAdjustArgs = invAdjustArgs;
            this._invAdjustPocket = invAdjustPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _lep = LookUpEditPocket.GetInstance();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = invAdjDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _invAdjustArgs,
                GridView = gridView1,
                InitModelType = typeof(InvAdjDetailModel),
                ModelArgs = _invAdjustArgs.InvAdjustModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<InvAdjustModelArgs, InvAdjDetailModel>(_invAdjustPocket.SelectInvAdjDetailModels, null, null);
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                if (col != colIsCheck)
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }
            colIsCheck.VisibleIndex = 0;
            _lep.SetGridColumnSysCode(colINV_GR, "INV_GR");
            _lep.SetGridColumnSysCode(colINVD_STATUS, "INVD_STATUS");
        }

        public List<InvAdjDetailModel> GetSelectedInvAdjDetailModels()
        {
            List<InvAdjDetailModel> selectedInvAdjDetailModels = ((List<InvAdjDetailModel>)invAdjDetailModelBindingSource.DataSource)
                                                        .Where(a => a.IsCheck == true).ToList();
            return selectedInvAdjDetailModels;
        }

        public void AdjustInvDetail(List<InvAdjDetailModel> selectedInvAdjDetailModels)
        {
            _invAdjustPocket.BpAdjustInvDetail(selectedInvAdjDetailModels);
        }
        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetWareHouse(colWH_CD, Common.LoginInfo.UserInfo.CompCode, _invAdjustArgs.InvAdjustModelArgs.Select_Main_Plant_Cd);
            LookUpEditHelper.SetLocation(colLOC_CD, Common.LoginInfo.UserInfo.CompCode, _invAdjustArgs.InvAdjustModelArgs.Select_Main_Plant_Cd, "");
            base.DataRefresh(args); 
        }
    }
}
