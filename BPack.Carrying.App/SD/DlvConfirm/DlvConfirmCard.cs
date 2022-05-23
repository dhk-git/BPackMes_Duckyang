using BPack.Model.App.SD.DlvConfirm;
using BPack.Pocket.App.SD.DlvConfirm;
using System.Collections.Generic;
using System.Linq;

namespace BPack.Carrying.App.SD.DlvConfirm
{
    public partial class DlvConfirmCard : DevExpress.XtraReports.UI.XtraReport
    {
        private const int MAX_ROW = 10;

        private DlvConfirmPocket _DlvConfirmPocket;
        private string _Drt_No;

        public DlvConfirmCard(DlvConfirmPocket DlvConfirmPocket, string Drt_NO)
        {
            InitializeComponent();

            _DlvConfirmPocket = DlvConfirmPocket;
            _Drt_No = Drt_NO;

            DataRefresh();
        }

        public void DataRefresh()
        {
            DlvConfirmCardHeaderModel _DlvConfirmCardHeaderModel;
            List<DlvConfirmCardHeaderModel> headerModelList = new List<DlvConfirmCardHeaderModel>();
            _DlvConfirmCardHeaderModel = _DlvConfirmPocket.SelectDlvConfirmCardHeaderModels(_Drt_No).First<DlvConfirmCardHeaderModel>();
            _DlvConfirmCardHeaderModel.detailModels = _DlvConfirmPocket.SelectDlvConfirmCardDetailModels(_Drt_No);

            // 납입카드의 SPACE 공간대신 빈 줄을 채워넣기 위한 조치 
            if(_DlvConfirmCardHeaderModel.detailModels.Count < MAX_ROW)
            {
                for(int i = _DlvConfirmCardHeaderModel.detailModels.Count + 1; i<= MAX_ROW; i++)
                {
                    DlvConfirmCardDetailModel detailModel = new DlvConfirmCardDetailModel();
                    detailModel.RN = i;
                    _DlvConfirmCardHeaderModel.detailModels.Add(detailModel);
                }
            }

            objectDataSource4.DataSource = _DlvConfirmCardHeaderModel;
            /*
            string[] reportTitle = new string[] { "납 입 카 드 (납품처 보관용)", "납 입 카 드 (업체 보관용)" };


            for (int i = 0; i < reportTitle.Count(); i++)
            {
                DlvConfirmCardHeaderModel headerModel = (DlvConfirmCardHeaderModel)_DlvConfirmCardHeaderModel.Copy();
                headerModel.REPORT_TITLE = reportTitle[i];
                headerModelList.Add(_DlvConfirmCardHeaderModel);
            }

            objectDataSource4.DataSource = headerModelList;
            */
        }

    }
}
