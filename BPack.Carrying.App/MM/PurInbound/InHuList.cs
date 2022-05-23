using BPack.Common.Model;
using BPack.Model.App.MM.PurInbound;
using BPack.Strap.EditControls;
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
using BPack.CommonMes.Helpers;
using BPack.Common.Config;

namespace BPack.Carrying.App.MM.PurInbound
{
    public partial class InHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurInboundArgs _purInboundArgs;
        private PurInboundPocket _purInboundPocket;

        public InHuList()
        {
            InitializeComponent();
        }

        public InHuList(PurInboundArgs purInboundArgs, PurInboundPocket purInboundPocket) : this()
        {
            _purInboundArgs = purInboundArgs;
            _purInboundPocket = purInboundPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = inHuModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _purInboundArgs,
                GridView = gridView1,
                InitModelType = typeof(InHuModel),
                ModelArgs = _purInboundArgs.PurInboundModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PurInboundModelArgs, InHuModel>(_purInboundPocket.SelectInHuModels, _purInboundPocket.SaveInHuModel, _purInboundPocket.SaveInHuModels);
           // LookUpEditHelper.SetGridColumnSysCode(colINHU_INSP_STATUS, "INHU_INSP_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colINHU_IN_STATUS, "INHU_IN_STATUS");
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((InHuModel)model).PIH_NO = _purInboundArgs.PurInboundModelArgs.Select_Pih_No;
            ((InHuModel)model).PID_NO = _purInboundArgs.PurInboundModelArgs.Select_Pid_No;
          //  ((InHuModel)model).INHU_INSP_STATUS = "WAITING";
            ((InHuModel)model).INHU_IN_STATUS = "WAITING";


            base.SetInsertDefaultValue(model);
        }

        internal void BpInHu()
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            var checkedModels = ((List<InHuModel>)SelectedModels).Where(a => a.IsCheck == true).ToList();

            if (checkedModels.Count == 0)
            {
                StrapMessageBox.Show("선택된 행이 없습니다.");
                return;
            }
            if (MessageBox.Show("선택된 식별표를 입고처리 합니다.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SystemConfig.RefreshServerDateTime();
                List<InHuProcessModel> inHuProcessModels = new List<InHuProcessModel>();
                //입고할 창고/위치 선택
                foreach (var model in checkedModels)
                {
                    inHuProcessModels.Add(new InHuProcessModel()
                    {
                        REMARK = model.REMARK,
                        CREATE_DTTM = SystemConfig.ServerDateTime,
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        MODIFY_DTTM = SystemConfig.ServerDateTime,
                        MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        PIH_NO = model.PIH_NO,
                        PID_NO = model.PID_NO,
                        HU_NO = model.HU_NO,
                        COMP_CD = model.COMP_CD,
                        PLANT_CD = model.PLANT_CD,
                        ITEM_CD = model.ITEM_CD,
                        WH_CD = _purInboundArgs.Select_Main_InTarget_Wh_Cd,
                     //   LOC_CD = _purInboundArgs.Select_Main_InTarget_Loc_Cd,
                        GR_QTY = model.GR_QTY,
                        REF_REMARK = $"{ _purInboundArgs.Select_Extra_Bp_Nm } ({_purInboundArgs.Select_Extra_Bp_Cd})"
                    });
                }
                _purInboundPocket.BpInHu(inHuProcessModels);
            };
        }
    }
}
