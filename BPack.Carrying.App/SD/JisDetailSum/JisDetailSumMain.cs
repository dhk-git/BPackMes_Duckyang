using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Pocket.App.SD.JisDetailSum;
using BPack.Strap.FormControls;
using System;

namespace BPack.Carrying.App.SD.JisDetailSum
{
    public partial class JisDetailSumMain : StrapMainForm
    {
        private JisDetailSumArgs _JisDetailSumArgs;
        private JisDetailSumPocket _JisDetailSumPocket;
        private JisDetailSumList _JisDetailSumList;

        public JisDetailSumMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _JisDetailSumArgs = new JisDetailSumArgs();
            _JisDetailSumPocket = new JisDetailSumPocket();
            _JisDetailSumList = new JisDetailSumList(_JisDetailSumArgs, _JisDetailSumPocket);

            AddSubForm(this, _JisDetailSumList, lcgSumList);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _JisDetailSumArgs,
                InitlistForm = _JisDetailSumList,
                StrapLayout = strapLayout1
            });

            rdgDT_OPT.SelectedIndex = 1;
            dteDT_FROM.EditValue = dteDT_TO.EditValue = DateTime.Now;

            InitRibbonButtons(true);

            lueCOMP_CD.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(luePLANT_CD, new { COMP_CD = lueCOMP_CD.EditValue?.ToString() }, isFirstSelect: true);
                LookUpEditHelper.SetByQuery(lueITEM_TYPE, "SD.JisDetail.Sum.ItemType", new { COMP_CD = lueCOMP_CD.EditValue?.ToString() }, "품목유형코드", "품목유형");
            };
            luePLANT_CD.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetDeliveryPlace(lueDLV_PLC_CD, lueCOMP_CD.EditValue?.ToString(), luePLANT_CD.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true);
                LookUpEditHelper.SetByQuery(lueITEM_GR_1, "MasterDataControls.Item.ItemGr1", new
                {
                    COMP_CD = lueCOMP_CD.EditValue?.ToString(),
                    PLANT_CD = luePLANT_CD.EditValue?.ToString()
                }, "차종코드", "차종");

                LookUpEditHelper.SetByQuery(lueALC_TYPE, "MasterDataControls.Item.ItemGr3", new
                {
                    COMP_CD = lueCOMP_CD.EditValue?.ToString(),
                    PLANT_CD = luePLANT_CD.EditValue?.ToString()
                }, "서열유형코드", "서열유형");

                _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
                _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
                _JisDetailSumList.SetGridRepository();
            };

            rdgDT_OPT.EditValueChanged += txtALC_CD_EditValueChanged;
            dteDT_FROM.EditValueChanged += txtALC_CD_EditValueChanged;
            dteDT_TO.EditValueChanged += txtALC_CD_EditValueChanged;
            lueDLV_PLC_CD.EditValueChanged += txtALC_CD_EditValueChanged;
            lueALC_TYPE.EditValueChanged += txtALC_CD_EditValueChanged;
            lueITEM_TYPE.EditValueChanged += txtALC_CD_EditValueChanged;
            lueITEM_GR_1.EditValueChanged += txtALC_CD_EditValueChanged;
            txtALC_CD.TextChanged += txtALC_CD_EditValueChanged;

            LookUpEditHelper.SetCompCode(lueCOMP_CD, isFirstSelect: true);

            if (lueCOMP_CD.EditValue?.ToString() != UserInfo.CompCode)
            {
                lueCOMP_CD.EditValue = UserInfo.CompCode;
            }
        }

        private void RefreshAppHistHeader()
        {
            _JisDetailSumList.DataClear(_JisDetailSumArgs);

            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Dt_Opt = rdgDT_OPT.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Dt_From = (DateTime)dteDT_FROM.EditValue;
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Dt_To = (DateTime)dteDT_TO.EditValue;
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Dlv_Plc_Cd = lueDLV_PLC_CD.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Alc_Type = lueALC_TYPE.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Item_Type = lueITEM_TYPE.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Item_Gr_1 = lueITEM_GR_1.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Alc_Cd = txtALC_CD.Text;

            _JisDetailSumList.DataRefresh(_JisDetailSumArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            rdgDT_OPT.EditValueChanged -= txtALC_CD_EditValueChanged;
            dteDT_FROM.EditValueChanged -= txtALC_CD_EditValueChanged;
            dteDT_TO.EditValueChanged -= txtALC_CD_EditValueChanged;
            lueDLV_PLC_CD.EditValueChanged -= txtALC_CD_EditValueChanged;
            lueALC_TYPE.EditValueChanged -= txtALC_CD_EditValueChanged;
            lueITEM_TYPE.EditValueChanged -= txtALC_CD_EditValueChanged;
            lueITEM_GR_1.EditValueChanged -= txtALC_CD_EditValueChanged;
            txtALC_CD.TextChanged -= txtALC_CD_EditValueChanged;

            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Dt_Opt = rdgDT_OPT.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Dt_From = dteDT_FROM.DateTime;// (DateTime)dteDT_FROM.EditValue;
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Dt_To = dteDT_TO.DateTime;// (DateTime)dteDT_TO.EditValue;
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Dlv_Plc_Cd = lueDLV_PLC_CD.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Alc_Type = lueALC_TYPE.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Item_Type = lueITEM_TYPE.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Item_Gr_1 = lueITEM_GR_1.EditValue?.ToString();
            _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Alc_Cd = txtALC_CD.Text;

            base.Refresh_From_ExecuteByRibbonButton();

            rdgDT_OPT.EditValueChanged += txtALC_CD_EditValueChanged;
            dteDT_FROM.EditValueChanged += txtALC_CD_EditValueChanged;
            dteDT_TO.EditValueChanged += txtALC_CD_EditValueChanged;
            lueDLV_PLC_CD.EditValueChanged += txtALC_CD_EditValueChanged;
            lueALC_TYPE.EditValueChanged += txtALC_CD_EditValueChanged;
            lueITEM_TYPE.EditValueChanged += txtALC_CD_EditValueChanged;
            lueITEM_GR_1.EditValueChanged += txtALC_CD_EditValueChanged;
            txtALC_CD.TextChanged += txtALC_CD_EditValueChanged;
        }

        private void txtALC_CD_EditValueChanged(object sender, EventArgs e)
        {
            RefreshAppHistHeader();
        }
    }
}
