using BPack.Model.App.MM.MebLot;
using BPack.Pocket.App.MM.MebLot;
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

namespace BPack.Carrying.App.MM.MebLot
{
    public partial class MebLotMain : StrapMainForm
    {
        private MebLotArgs _mebLotArgs;
        private MebLotPocket _mebLotPocket;
        private LPackAndMPackList _lPackAndMPackList;
        private MPackAndPartList _mPackAndPartList;
        public MebLotMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _mebLotArgs = new MebLotArgs();
            _mebLotPocket = new MebLotPocket();
            _lPackAndMPackList = new LPackAndMPackList(_mebLotArgs, _mebLotPocket);
            _mPackAndPartList = new MPackAndPartList(_mebLotArgs, _mebLotPocket);
            AddSubForm(this, _lPackAndMPackList, layoutControlGroup2);
            AddSubForm(this, _mPackAndPartList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _mebLotArgs,
                InitlistForm = _lPackAndMPackList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            chkAllMPack.CheckState = CheckState.Unchecked;
            _lPackAndMPackList.ModelSelectedEvent += LPackAndMPackList_ModelSelectedEvent;
        }

        private void LPackAndMPackList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _mebLotArgs.MebLotModelArgs.Select_L_Pack_No = ((LPackAndMPackModel)e.SelectedModelArgsBase.SelectedModelBase).PACK_NO;
            _mebLotArgs.MebLotModelArgs.Select_M_Pack_No = ((LPackAndMPackModel)e.SelectedModelArgsBase.SelectedModelBase).M_PACK_NO;
            _mebLotArgs.MebLotModelArgs.Select_Main_Chk_All_MPack = chkAllMPack.CheckState == CheckState.Checked ? "Y" : "N";
            _mPackAndPartList.DataRefresh(_mebLotArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _mebLotArgs.MebLotModelArgs.Select_Main_Start_Dt = dteStartDate.DateTime;
            _mebLotArgs.MebLotModelArgs.Select_Main_End_Dt = dteEndDate.DateTime;
            _mebLotArgs.MebLotModelArgs.Select_Main_CaseNo = txtCaseNo.EditValue?.ToString();
            _mebLotArgs.MebLotModelArgs.Select_Main_LPackNo = txtLPackNo.EditValue?.ToString();
            _mebLotArgs.MebLotModelArgs.Select_Main_MPackNo = txtMPackNo.EditValue?.ToString();
            _mebLotArgs.MebLotModelArgs.Select_Main_PartLotNo = txtPartLotNo.EditValue?.ToString();
            if (!string.IsNullOrEmpty(_mebLotArgs.MebLotModelArgs.Select_Main_MPackNo))
            {
                chkAllMPack.CheckState = CheckState.Unchecked;
                chkAllMPack.Enabled = false;
            }
            else
            {
                chkAllMPack.CheckState = CheckState.Unchecked;
                chkAllMPack.Enabled = true;
            }

            _mebLotArgs.MebLotModelArgs.Select_L_Pack_No = null;
            _mebLotArgs.MebLotModelArgs.Select_M_Pack_No = null;

            base.Refresh_From_ExecuteByRibbonButton();
            //개별LOT로 조회시 중/개별LOT도 바로 조회한다.
            if (!string.IsNullOrEmpty(_mebLotArgs.MebLotModelArgs.Select_Main_PartLotNo))
            {
                _mPackAndPartList.DataRefresh(_mebLotArgs);
            }
        }

        //대/중포장 업로드 버튼
        private void btnLPackMPackUpload_Click(object sender, EventArgs e)
        {
            MebLotExcelUpload mebLotExcelUpload = new MebLotExcelUpload("MEB_LOT_LPACK");
            mebLotExcelUpload.UploadButtonClicked += LPackMPack_MebLotExcelUpload_UploadButtonClicked;
            mebLotExcelUpload.ShowDialog();
        }

        //대/중포장 업로드 
        private void LPackMPack_MebLotExcelUpload_UploadButtonClicked(object sender, UploadButtonClickedEventArgs e)
        {
            try
            {
                List<LPackAndMPackModel> newModels = new List<LPackAndMPackModel>();
                foreach (DataRow row in e.DataTable.Rows)
                {
                    newModels.Add(new LPackAndMPackModel
                    {
                        PACK_NO = row["PACK_NO"].ToString(),
                        M_PACK_NO = row["M_PACK_NO"].ToString(),
                        CASE_NO = row["CASE_NO"].ToString(),
                        ORDER_NO = row["ORDER_NO"].ToString(),
                        PART_NO = row["PART_NO"].ToString(),
                        QTY = Convert.ToInt32(row["QTY"]),
                        LOT = row["LOT"].ToString(),
                        USE_YN = "-",
                        SEND_YN = "-",
                        WORK_DATE = row["WORK_DATE"].ToString(),
                        SAVE_BY = Common.LoginInfo.UserInfo.UserID,
                        CREATE_BY = Common.LoginInfo.UserInfo.UserID,
                        CREATE_DTTM = DateTime.Now,
                        SAVE_DTTM = DateTime.Now,
                        RowState = Common.Model.RowState.Added
                    });
                }
                _mebLotPocket.SaveLPackAndMPackModels(newModels);
                StrapMessageBox.Show("A001", 12); //등록 되었습니다.
                ((Form)sender).Close();
                _lPackAndMPackList.DataRefresh(_mebLotArgs);
                _mPackAndPartList.DataRefresh(_mebLotArgs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }

        }

        //중포장/개별LOT 업로드 버튼
        private void btnMPackPartUpload_Click(object sender, EventArgs e)
        {
            MebLotExcelUpload mebLotExcelUpload = new MebLotExcelUpload("MEB_LOT_MPACK");
            mebLotExcelUpload.UploadButtonClicked += MPackPartLot_MebLotExcelUpload_UploadButtonClicked;
            mebLotExcelUpload.ShowDialog();
        }

        //중포장/개별LOT 업로드
        private void MPackPartLot_MebLotExcelUpload_UploadButtonClicked(object sender, UploadButtonClickedEventArgs e)
        {
            try
            {
                List<MPackAndPartLotModel> newModels = new List<MPackAndPartLotModel>();
                foreach (DataRow row in e.DataTable.Rows)
                {
                    newModels.Add(new MPackAndPartLotModel
                    {
                        PACK_NO = row["PACK_NO"].ToString(),
                        PART_LOT = row["PART_LOT"].ToString(),
                        PACK_DATE = row["PACK_DATE"].ToString(),
                        SHIP_DATE = row["SHIP_DATE"].ToString(),
                        USE_YN = "Y",
                        SEND_YN = "N",
                        SAVE_BY = Common.LoginInfo.UserInfo.UserID,
                        CREATE_BY = Common.LoginInfo.UserInfo.UserID,
                        CREATE_DTTM = DateTime.Now,
                        SAVE_DTTM = DateTime.Now,
                        RowState = Common.Model.RowState.Added,
                    });
                }
                _mebLotPocket.SaveMPackAndMPartModels(newModels);
                StrapMessageBox.Show("A001", 12); //등록 되었습니다.
                ((Form)sender).Close();
                _lPackAndMPackList.DataRefresh(_mebLotArgs);
                _mPackAndPartList.DataRefresh(_mebLotArgs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        private void btnLPackBPackDownload_Click(object sender, EventArgs e)
        {

        }

        //중포장 전체 조회 체크박스
        private void chkAllMPack_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_mebLotArgs.MebLotModelArgs.Select_L_Pack_No))
            {
                _mebLotArgs.MebLotModelArgs.Select_Main_Chk_All_MPack = chkAllMPack.CheckState == CheckState.Checked ? "Y" : "N";
                _mPackAndPartList.DataRefresh(_mebLotArgs);
            }
        }
    }
}
