using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchDlvRead;
using BPack.Pocket.App.QC.QchDlvRead;
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

namespace BPack.Carrying.App.QC.QchDlvRead
{
    public partial class QchDlvReadMain : StrapMainForm
    {
        private QchDlvReadArgs _qchDlvReadArgs;
        private QchDlvReadPocket _qchDlvReadPocket;
        private QchDlvReadHeaderList _qchDlvReadHeaderList;
        private QchDlvReadDetailList _qchDlvReadDetailList;

        public QchDlvReadMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _qchDlvReadArgs = new QchDlvReadArgs();
            _qchDlvReadPocket = new QchDlvReadPocket();
            _qchDlvReadHeaderList = new QchDlvReadHeaderList(_qchDlvReadArgs, _qchDlvReadPocket);
            _qchDlvReadDetailList = new QchDlvReadDetailList(_qchDlvReadArgs, _qchDlvReadPocket);

            AddSubForm(this, _qchDlvReadHeaderList, layoutControlGroup2);
            AddSubForm(this, _qchDlvReadDetailList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _qchDlvReadArgs,
                InitlistForm = _qchDlvReadHeaderList,
                StrapLayout = strapLayout1
            });

            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            LookUpEditHelper.SetSysCode(strapLookUpEdit6, "INSP_JUDGE", isFirstSelect: true);



            strapButtonEdit_ItemMaster1.InitStrap();

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Comp_CD }, isFirstSelect: true);

                strapButtonEdit_ItemMaster1.InitCompCode(_qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Comp_CD);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
                LookUpEditHelper.SetByQuery
                    (strapLookUpEdit5, 
                    "ItemGroup_WithCode",
                    new
                    {
                        COMP_CD = _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Comp_CD
                            ,
                        PLANT_CD = _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Plant_CD
                            ,
                        ITEM_GR_CLS = "ITEM_GR_1"
                    }
                    , "코드", "차종명", isTotalRow: true, isFirstSelect: true);
            };

            ///



            this.SelectedSubFormChanged += QchDlvReadMain_SelectedSubFormChanged;
            _qchDlvReadHeaderList.ModelSelectedEvent += _qchDlvReadHeaderList_ModelSelectedEvent;

            _qchDlvReadDetailList.modelValueChanged += _qchDlvReadDetailList_modelValueChanged;


            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }



        private void QchDlvReadMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _qchDlvReadHeaderList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
            if (this.SelectedSubForm == _qchDlvReadDetailList) { SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: true, delete: false); }
        }

        private void _qchDlvReadHeaderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _qchDlvReadArgs.QchDlvReadModelArgs.Select_Header_Insp_No
                = ((QchDlvReadHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).INSP_NO;


            _qchDlvReadDetailList.DataRefresh(_qchDlvReadArgs);
        }
        private void _qchDlvReadDetailList_modelValueChanged(object sender, List<QchDlvReadDetailModel> e)
        {
            var ngModel = e.Where(r => r.INSP_JUDGE_QC == "NG").Count();

            var curModel = _qchDlvReadHeaderList.GetFocusedRow();
            if (ngModel > 0)
            {
                curModel.INSP_JUDGE_QC = "NG";
            }
            else
            {
                curModel.INSP_JUDGE_QC = "OK";
            }

            _qchDlvReadHeaderList.RowRefresh();
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {

            _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_InspDate_From = strapDateEdit1.DateTime.ToShortDateString();
            _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_InspDate_To = strapDateEdit2.DateTime.ToShortDateString();
            _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_ItemGroup_CD = strapLookUpEdit5.EditValue?.ToString();
            _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Item_CD = strapButtonEdit_ItemMaster1.EditValue?.ToString();
            _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Insp_Judge = strapLookUpEdit6.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}
