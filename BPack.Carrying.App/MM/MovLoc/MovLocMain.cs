using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.MovLoc;
using BPack.Pocket.App.MM.MovLoc;
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

namespace BPack.Carrying.App.MM.MovLoc
{
    public partial class MovLocMain : StrapMainForm
    {

        private MovLocArgs _movLocArgs;
        private MovLocPocket _movLocPocket;
        private MovLocList _movLocList;
        private MovLocItemList _movLocItemList;

        public MovLocMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();

            _movLocArgs = new MovLocArgs();
            _movLocPocket = new MovLocPocket();
            _movLocList = new MovLocList(_movLocArgs, _movLocPocket);
            _movLocItemList = new MovLocItemList(_movLocArgs, _movLocPocket);

            AddSubForm(this, _movLocList, layoutControlGroup2);
            AddSubForm(this, _movLocItemList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _movLocArgs,
                InitlistForm = _movLocList,
                StrapLayout = strapLayout1
            });
            LookUpEditHelper.SetCompCode(sleCompCd);

            sleCompCd.EditValue = _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd = UserInfo.CompCode;
            slePlantCd.EditValue = _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd = UserInfo.PlantCode;
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;
            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;

            strapDateEdit1.EditValue = DateTime.Now.Date;
            strapDateEdit2.EditValue = DateTime.Now.Date;


            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _movLocList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: true); }
                if (this.SelectedSubForm == _movLocItemList)
                {
                    if (_movLocArgs.MovLocModelArgs.MOV_STATUS == "CLOSE")
                    {
                        SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: false);
                    }
                    else
                    {
                        SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: true);
                    }

                }

            };

            _movLocList.ModelSelectedEvent += _movLocList_ModelSelectedEvent;


            //나중에 공장정보 넣어줘야함.
            LookUpEditHelper.SetWareHouse
                (strapLookUpEdit1
                , _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd
                , _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd
                , isTotalRow: true);
            LookUpEditHelper.SetWareHouse
                (strapLookUpEdit2
                , _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd
                , _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd
                , isTotalRow: true);

            InitRibbonButtons(true);
        }

        private void _movLocList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd = _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd;
            _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd = _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd;
            _movLocArgs.MovLocModelArgs.Select_Main_MOV_NO = ((MovLocModel)e.SelectedModelArgsBase.SelectedModelBase).MOV_NO;
            _movLocArgs.MovLocModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _movLocArgs.MovLocModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _movLocArgs.MovLocModelArgs.MOV_STATUS = ((MovLocModel)e.SelectedModelArgsBase.SelectedModelBase).MOV_STATUS;
            _movLocItemList.DataRefresh(_movLocArgs);

            if (_movLocArgs.MovLocModelArgs.MOV_STATUS == "CLOSE")
            {
                SetRibbonButtonsEnable_ByAuth(edit: false, delete: false, save: true);
                strapButton1.Enabled = false;
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: true);
                strapButton1.Enabled = true;
            }
        }

        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd = slePlantCd.EditValue?.ToString();
        }

        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
            _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd = sleCompCd.EditValue?.ToString();
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd = _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd;
            _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd = _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd;
            _movLocArgs.MovLocModelArgs.Select_Main_FROM_WH_CD = strapLookUpEdit1.EditValue?.ToString();
            _movLocArgs.MovLocModelArgs.Select_Main_TO_WH_CD = strapLookUpEdit2.EditValue?.ToString();
            _movLocArgs.MovLocModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _movLocArgs.MovLocModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            base.Refresh_From_ExecuteByRibbonButton();
            _movLocList.SelectModelAndRaiseEvent(0);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (_movLocArgs.MovLocModelArgs.Select_Main_MOV_NO == null)
            {
                //선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                StrapMessageBox.Show("A001", 9);
                return;
            }
            if (_movLocArgs.MovLocModelArgs.MOV_STATUS == "CLOSE")
            {
                //이미 확정된 데이터가 있습니다
                StrapMessageBox.Show("A001", 104);
                return;
            }

            if (!_movLocItemList.SelectedModels.Any())
            {
                StrapMessageBox.Show("A002", 27); //재고이동 품목이 존재하지 않습니다.
                return;
            }

            foreach (MovLocItemModel model in _movLocItemList.SelectedModels)
            {
                if (model.MOV_QTY == 0)
                {
                    StrapMessageBox.Show("A002", 33); //수량이 0 인 데이터가 존재합니다.
                    return;
                }
            }

            //선택된 데이터를 재고이동 처리하시겠습니까?
            if (StrapMessageBox.Show("A001", 103, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _movLocList.MovLoc_Confirm(_movLocList.GetSelectedModel());
                    _movLocList.DataRefresh(_movLocArgs);
                    _movLocItemList.DataRefresh(_movLocArgs);
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }

            }
        }
    }
}
