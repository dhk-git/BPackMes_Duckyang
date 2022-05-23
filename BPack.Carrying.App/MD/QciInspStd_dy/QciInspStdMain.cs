using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciInspStd_dy;
using BPack.Pocket.App.MD.QciInspStd_dy;
using BPack.Strap.FormControls;
using BPack.Strap.FormControls.StrapFileManager;
using System;

namespace BPack.Carrying.App.MD.QciInspStd_dy
{
    public partial class QciInspStdMain : StrapMainForm
    {
        private QciInspStd_dyPocket _qciInspStd_DyPocket;
        private QciInspStd_dyArgs _qciInspStd_DyArgs;
        private QciInspStdHeaderList _qciInspStdHeaderList;

        //22022.03.15 첨부파일
        private StrapFileManagerSubForm _strapFileManagerSubForm;
        private StrapFileManagerArgs _strapFileManagerArgs;

        public QciInspStdMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {

            _qciInspStd_DyPocket = new QciInspStd_dyPocket();
            _qciInspStd_DyArgs = new QciInspStd_dyArgs();
            _qciInspStdHeaderList = new QciInspStdHeaderList(_qciInspStd_DyArgs, _qciInspStd_DyPocket);

            //첨부파일
            _strapFileManagerArgs = new StrapFileManagerArgs();
            _strapFileManagerSubForm = new StrapFileManagerSubForm("QciInspStd", _strapFileManagerArgs);

            //멀티 파일 default true
            _strapFileManagerSubForm.AllowMultiFile = true;

            //엑셀파일 필터
            _strapFileManagerSubForm.UploadFileFilter = "Excel files(*.xls,*.xlsx)|*.xls;*.xlsx";

            //업로드 제한 10MB
            _strapFileManagerSubForm.MaxFileSizeMB = 10;


            AddSubForm(this, _strapFileManagerSubForm, layoutControlGroup3);

            AddSubForm(this, _qciInspStdHeaderList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _qciInspStd_DyArgs,
                InitlistForm = _qciInspStdHeaderList,
                StrapLayout = strapLayout1
            });
            this.SelectedSubFormChanged += QciInspStdMain_SelectedSubFormChanged    ;
            InitRibbonButtons(true, false, true, false, true);
            strapLookUpEdit1.EditValue = _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code = UserInfo.CompCode;
            strapLookUpEdit2.EditValue = _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Plant_Code = UserInfo.PlantCode;
            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            LookUpEditHelper.SetPlantCode(strapLookUpEdit2
                , new { COMP_CD = UserInfo.CompCode }
                );

            //2021.12.23 원자재,상품만 조회
            LookUpEditHelper.SetByQuery
                (strapLookUpEdit3
                , "ItemType_Insp"
                , new { COMP_CD= strapLookUpEdit1.EditValue = _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code }
                ,"Code","Name"
                ,isTotalRow:true
                );

            //LookUpEditHelper.SetItemType
            //    (
            //        strapLookUpEdit3
            //        , _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code
            //        , isTotalRow: true, isFirstSelect: true
            //    );
            LookUpEditHelper.SetByQuery
                (strapLookUpEditItem_Gr_1, "ItemGroupDetail"
                   , new
                   {
                       COMP_CD = _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code
                       ,
                       PLANT_CD = _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Plant_Code
                       ,
                       ITEM_GR_CLS = "ITEM_GR_1"
                   }
                   , "CODE", "NAME", isTotalRow: true
               );

            LookUpEditHelper.SetSysCode(strapLookUpEdit4, "QCI_TYPE");
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            strapLookUpEdit2.EditValueChanged += StrapLookUpEdit2_EditValueChanged;

            _qciInspStdHeaderList.ModelSelectedEvent += _qciInspStdHeaderList_ModelSelectedEvent;

        }

        private void QciInspStdMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _strapFileManagerSubForm)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: true, delete: true);
            }
            else if (this.SelectedSubForm == _qciInspStdHeaderList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: true, delete: false);
            }
        }

        private void _qciInspStdHeaderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            var model = (QciLinspStdHeaderModel)e.SelectedModelArgsBase.SelectedModelBase;
            _strapFileManagerArgs.StrapFileManagerModelArgs.Select_Group_FK_1 
                = model.COMP_CD_KEY+"_"
                    +model.PLANT_CD_KEY+"_"
                    +model.ITEM_CD_KEY
                ;
            _strapFileManagerSubForm.DataRefresh(_strapFileManagerArgs);
        }

        private void StrapLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            LookUpEditHelper.SetByQuery(strapLookUpEditItem_Gr_1, "ItemGroupDetail"
               , new
               {
                   COMP_CD = _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code
                   ,
                   PLANT_CD = strapLookUpEdit2.EditValue?.ToString(),
                   ITEM_GR_CLS = "ITEM_GR_1"
               }, "CODE", "NAME", isTotalRow: true);
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code
                    = strapLookUpEdit1.EditValue?.ToString();
            LookUpEditHelper.SetPlantCode(strapLookUpEdit2
                , new
                {
                    COMP_CD = strapLookUpEdit1.EditValue?.ToString()
                }
                , isFirstSelect: true);

            //2021.12.23 원자재,상품만 조회
            LookUpEditHelper.SetByQuery
               (strapLookUpEdit3
               , "ItemType_Insp"
               , new { COMP_CD = strapLookUpEdit1.EditValue = _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code }
               , "Code", "Name"
               , isTotalRow: true
               );
            //LookUpEditHelper.SetItemType(strapLookUpEdit3
            //    , _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code
            //    , isTotalRow: true, isFirstSelect: true);

        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code
                    = strapLookUpEdit1.EditValue?.ToString();
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Plant_Code
                    = strapLookUpEdit2.EditValue?.ToString();
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_ITEM_CD
                    = strapTextEdit1.EditValue?.ToString();
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_ITEM_NM
                    = strapTextEdit2.EditValue?.ToString();
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_ITEM_TYPE_CD
                    = strapLookUpEdit3.EditValue?.ToString();
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_ITEM_GR_1
                    = strapLookUpEditItem_Gr_1.EditValue?.ToString();
            _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_QCI_TYPE
                = strapLookUpEdit4.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}
