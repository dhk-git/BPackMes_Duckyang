using BPack.Common.Model;
using BPack.Model.App.MM.PurInbound;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.PurInbound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.PurInbound
{
    public partial class InDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurInboundArgs _purInboundArgs;
        private PurInboundPocket _purInboundPocket;
        private Strap.EditControls.StrapRepositoryItemButtonEdit_ItemMaster _btnItemMaster;

        public InDetailList()
        {
            InitializeComponent();
        }

        public InDetailList(PurInboundArgs purInboundArgs, PurInboundPocket purInboundPocket) : this()
        {
            _purInboundArgs = purInboundArgs;
            _purInboundPocket = purInboundPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = inDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _purInboundArgs,
                GridView = gridView1,
                InitModelType = typeof(InDetailModel),
                ModelArgs = _purInboundArgs.PurInboundModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PurInboundModelArgs, InDetailModel>(_purInboundPocket.SelectInDetailModels, _purInboundPocket.SaveInDetailModel, _purInboundPocket.SaveInDetailModels);
            _btnItemMaster = new Strap.EditControls.StrapRepositoryItemButtonEdit_ItemMaster(colITEM_CD, gridView1);
            _btnItemMaster.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((InDetailModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((InDetailModel)model).PIH_NO = _purInboundArgs.PurInboundModelArgs.Select_Pih_No;
            ((InDetailModel)model).PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            ((InDetailModel)model).PID_STATUS = "WAIT";
            _btnItemMaster.InitPlantCode(Common.LoginInfo.UserInfo.PlantCode);
            base.SetInsertDefaultValue(model);
        }

        internal void BpInDetail()
        {
            var checkedModels = ((List<InDetailModel>)SelectedModels).Where(a => a.IsCheck == true).ToList();
            if (checkedModels.Count == 0)
            {
                StrapMessageBox.Show("선택된 행이 없습니다.");
                return;
            }
            if (MessageBox.Show("선택된 품목을 입고처리 합니다.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _purInboundPocket.BpInDetail(checkedModels);
            };
        }

        public void AddInDetailModels(List<InDetailModel> inDetailModels)
        {
            foreach (var model in inDetailModels)
            {
                ((List<InDetailModel>)this.SelectedModels).Add(model);
            }

            inDetailModelBindingSource.ResetBindings(false);
        }

        public bool CheckConfirm(out string msg)
        {
            if (!this.SelectedModels.Any())
            {
                msg = StrapMessageBox.GetMessage("A002", 28); //입고처리할 데이터가 존재하지 않습니다.
                return false;
            }
            foreach (var model in this.SelectedModels)
            {
                if (((InDetailModel)model).RowState != RowState.UnChanged)
                {
                    msg = StrapMessageBox.GetMessage("A002", 4); //저장되지 않은 데이터가 존재합니다. 저장후 다시 시도바랍니다.
                    return false;
                }
            }

            msg = null;
            return true;
        }
    }
}
