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
    public partial class InHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurInboundArgs _purInboundArgs;
        private PurInboundPocket _purInboundPocket;
        //private LookUpEditPocket _lep;

        public InHeaderList()
        {
            InitializeComponent();
        }

        public InHeaderList(PurInboundArgs purInboundArgs, PurInboundPocket purInboundPocket) : this()
        {
            _purInboundArgs = purInboundArgs;
            _purInboundPocket = purInboundPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() //Sub 멥버변수 초기화
            {
                BindingSource = inHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _purInboundArgs,
                GridView = gridView1,
                InitModelType = typeof(InHeaderModel),
                ModelArgs = _purInboundArgs.PurInboundModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<PurInboundModelArgs, InHeaderModel>(_purInboundPocket.SelectInHeaderModels, 
                _purInboundPocket.SaveInHeaderModel, _purInboundPocket.SaveInHeaderModels); //Pocket의 Select 메서드와 Save 메서드 초기화

            //LookUpEditHelper.SetGridColumnByQuery(colIN_PLANT_CD, "PlantList", new
            //{
            //    COMP_CD = Common.LoginInfo.UserInfo.CompCode
            //}, "공장코드", "공장명");
            LookUpEditHelper.SetGridColumnByQuery(colBP_CD, "MM.PurInbound.BpList", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode
            }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnSysCode(colPIH_STATUS, "PIH_STATUS");
            this.ModelSelectedEvent += InHeaderList_ModelSelectedEvent;
        }

        private void InHeaderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            //입고처리시 REF_REMARK 정보를 위해 할당함
            _purInboundArgs.Select_Extra_Bp_Nm = gridView1.GetFocusedRowCellDisplayText(colBP_CD);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((InHeaderModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((InHeaderModel)model).PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            ((InHeaderModel)model).PIH_STATUS = "WAIT";
            ((InHeaderModel)model).DEL_FG = "N";

            base.SetInsertDefaultValue(model);
        }

        //public void BpInHeader()
        //{
        //    List<InHeaderModel> checkedModels = ((List<InHeaderModel>)SelectedModels).Where(a => a.IsCheck == true).ToList();
        //    if (checkedModels.Count == 0)
        //    {
        //        StrapMessageBox.Show("선택된 행이 없습니다.");
        //        return;
        //    }
        //    if (MessageBox.Show("선택된 전표을 입고처리 합니다.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //        _purInboundPocket.BpInHeader(checkedModels);
        //    };
        //}


        //미사용 
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
                List<InHuHeaderModel> inHuProcessModels = new List<InHuHeaderModel>();
                //입고할 창고/위치 선택
                foreach (var model in checkedModels)
                {
                    inHuProcessModels.Add(new InHuHeaderModel()
                    {
                        REMARK = model.REMARK,
                        CREATE_DTTM = SystemConfig.ServerDateTime,
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        MODIFY_DTTM = SystemConfig.ServerDateTime,
                        MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        PIH_NO = model.PIH_NO,
                     
                        COMP_CD = model.COMP_CD,
                        PLANT_CD = model.PLANT_CD,
                        WH_CD = _purInboundArgs.Select_Main_InTarget_Wh_Cd,
                      
                    });
                }
                _purInboundPocket.BpInHeader(inHuProcessModels);
            };
        }

        public bool CheckConfirm(out string msg)
        {
            if (_purInboundArgs.PurInboundModelArgs.Select_Pih_No == null)
            {
                msg = StrapMessageBox.GetMessage("A002", 12); //선택된 건이 없습니다.
                return false;
            }
            else if (_purInboundArgs.PurInboundModelArgs.Select_Pih_Status.Equals("CLOSE"))
            {
                msg = StrapMessageBox.GetMessage("A002", 3); //이미 확정된 건 입니다.
                return false;
            }
            else
            {
                msg = null;
                return true;
            }
            
        }
    }
}
