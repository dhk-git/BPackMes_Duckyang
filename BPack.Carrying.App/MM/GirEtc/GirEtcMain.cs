using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirEtc;
using BPack.Pocket.App.MM.GirEtc;
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

namespace BPack.Carrying.App.MM.GirEtc
{
    public partial class GirEtcMain : StrapMainForm
    {
        private GirEtcArgs _girEtcArgs;
        private GirEtcPocket _girEtcPocket;
        private GirEtcList _girEtcList;
        private GirEtcItemList _girEtcItemList;

        public GirEtcMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();

            _girEtcArgs = new GirEtcArgs();
            _girEtcPocket = new GirEtcPocket();
            _girEtcList = new GirEtcList(_girEtcArgs, _girEtcPocket);
            _girEtcItemList = new GirEtcItemList(_girEtcArgs, _girEtcPocket);
         
            AddSubForm(this, _girEtcList, layoutControlGroup2);
            AddSubForm(this, _girEtcItemList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _girEtcArgs,
                InitlistForm = _girEtcList,
                StrapLayout = strapLayout1
            });
            strapDateEdit1.EditValue = DateTime.Now.Date;
            strapDateEdit2.EditValue = DateTime.Now.Date;

            this.SelectedSubFormChanged += GirEtcMain_SelectedSubFormChanged;
            _girEtcList.ModelSelectedEvent += GirEtcList_ModelSelectedEvent;
            _girEtcList.ModelDeletedEvent += GirEtcList_ModelDeletedEvent;

            //나중에 공장정보 넣어줘야함.
            LookUpEditHelper.SetWareHouse(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode, isFirstSelect: true, isTotalRow:true);

            InitRibbonButtons(true);
        }

        private void GirEtcList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _girEtcItemList.DataClear(_girEtcArgs);
        }

        private void GirEtcList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _girEtcArgs.GirEtcModelArgs.Select_Etg_No = ((GirEtcModel)e.SelectedModelArgsBase.SelectedModelBase).ETG_NO;
            _girEtcArgs.GirEtcModelArgs.Select_Etg_Git_Status = ((GirEtcModel)e.SelectedModelArgsBase.SelectedModelBase).ETC_GIR_STATUS;
            ChangeEnable();
            _girEtcItemList.DataRefresh(_girEtcArgs);
        }

        private void GirEtcMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            ChangeEnable();
        }

        private void ChangeEnable()
        {
            if (this.SelectedSubForm == _girEtcList)
            {
                if (_girEtcArgs.GirEtcModelArgs.Select_Etg_Git_Status != null
                    && _girEtcArgs.GirEtcModelArgs.Select_Etg_Git_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: false);
                    btnConfirm.Enabled = true;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: false, save: false);
                    btnConfirm.Enabled = false;
                }
            }
            if (this.SelectedSubForm == _girEtcItemList)
            {
                if (_girEtcArgs.GirEtcModelArgs.Select_Etg_Git_Status != null
                    && _girEtcArgs.GirEtcModelArgs.Select_Etg_Git_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save: true);
                    btnConfirm.Enabled = true;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: false);
                    btnConfirm.Enabled = false;
                }
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _girEtcArgs.GirEtcModelArgs.Select_Main_WH_CD = strapLookUpEdit1.EditValue?.ToString();
            _girEtcArgs.GirEtcModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _girEtcArgs.GirEtcModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _girEtcArgs.GirEtcModelArgs.Select_Etg_No = null;
            _girEtcArgs.GirEtcModelArgs.Select_Etg_Git_Status = null;
            btnConfirm.Enabled = false;
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //_girEtcList.EtcInList();
            var checkedModel = _girEtcList.GetSelectedModel();
            if (checkedModel == null)
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }
            var detailList = _girEtcItemList.SelectedModels;
            if (!detailList.Any())
            {
                StrapMessageBox.Show("A002", 29); //입/출고 처리할 데이터가 존재하지 않습니다.
                return;
            }
            foreach (GirEtcItemModel model in detailList)
            {
                if (model.ETC_GIR_QTY == 0)
                {
                    StrapMessageBox.Show("A002", 33); //수량이 0 인 데이터가 존재합니다.
                    return;
                }
            }


            if (StrapMessageBox.Show("A001", 102, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택된 행 입/출고 처리합니다.
            {
                try
                {
                    
                    _girEtcPocket.SaveInOutModel(checkedModel);

                   _girEtcList.DataRefresh(_girEtcArgs);
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }

            };
        }
    }
}
