using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrHist;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.NcrHist;
using DevExpress.XtraGrid.Views.Grid;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.QC.NcrHist
{
    public partial class NcrHistHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private NcrHistArgs _ncrHistArgs;
        private NcrHistPocket _ncrHistPocket;
        
        public NcrHistHeaderList(NcrHistArgs ncrHistArgs, NcrHistPocket ncrHistPocket)
        {
            InitializeComponent();

            _ncrHistArgs = ncrHistArgs;
            _ncrHistPocket = ncrHistPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = ncrHistHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _ncrHistArgs,
                GridView = gridView1,
                InitModelType = typeof(NcrHistHeaderModel),
                ModelArgs = _ncrHistArgs.NcrHistModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<NcrHistModelArgs, NcrHistHeaderModel>(_ncrHistPocket.SelectNcrHistHeaderModels, _ncrHistPocket.SaveNcrHistHeaderModel, _ncrHistPocket.SaveNcrHistHeaderModels);
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colNCR_TYPE, "NcrType_WithCode", new { COMP_CD = _ncrHistArgs.NcrHistModelArgs.Select_Main_CompCode }, "부적합유형", "부적합유형명");
            LookUpEditHelper.SetGridColumnByQuery(colNCR_CD, "NcrCode_WithCode", new{ COMP_CD = _ncrHistArgs.NcrHistModelArgs.Select_Main_CompCode, NCR_TYPE = "" }, "부적합코드", "부적합코드명");
            LookUpEditHelper.SetGridColumnByQuery(colR_WC_CD, "CoreSettingsWorkCenterList", new { COMP_CD = _ncrHistArgs.NcrHistModelArgs.Select_Main_CompCode, PLANT_CD = _ncrHistArgs.NcrHistModelArgs.Select_Main_PlantCode }, "작업장코드", "작업장명", isDelButton: true);
            LookUpEditHelper.SetGridColumnByQuery(colR_BP_CD, "BusinessPartner_WithCode", new { COMP_CD = _ncrHistArgs.NcrHistModelArgs.Select_Main_CompCode }, "거래처코드", "거래처명", isDelButton: true);
            LookUpEditHelper.SetShiftCode(colSHIFT_CD, _ncrHistArgs.NcrHistModelArgs.Select_Main_CompCode, _ncrHistArgs.NcrHistModelArgs.Select_Main_PlantCode);

            LookUpEditHelper.SetGridColumnCommonCode(colNCR_STATUS, _ncrHistArgs.NcrHistModelArgs.Select_Main_CompCode, "NCR_STATUS");

            base.DataRefresh(args);
        }

        public NcrHistHeaderModel GetSelectedUserModel()
        {
            return (NcrHistHeaderModel)strapGridControl1.SelectedModel;
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            var grv = sender as GridView;

            switch (e.Column.FieldName)
            {
                case "NCR_CD":
                    var ncrType = grv.GetRowCellValue(e.RowHandle, "NCR_TYPE");

                    var sp = SimplePocket.GetInstance();
                    var source = sp.SelectData("NcrCode_WithCode", new
                    {
                        COMP_CD = _ncrHistArgs.NcrHistModelArgs.Select_Main_CompCode,
                        NCR_TYPE = ncrType
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "부적합코드", displayCaption: "부적합코드명");

                    break;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var curModel = (sender as GridView).GetRow(e.RowHandle) as NcrHistHeaderModel;

            switch (e.Column.FieldName)
            {
                case "NCR_TYPE":
                    curModel.NCR_CD = "";
                    break;
            }
        }
    }
}
