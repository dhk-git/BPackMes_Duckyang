using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeRsltInfo;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WoeRsltInfo;
using System;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.PC.WoeRsltInfo
{
    public partial class WoeRsltInfoMain : StrapMainForm
    {
        private WoeRsltInfoPocket _WoeRsltInfoPocket;
        private WoeRsltInfoArgs _WoeRsltInfoArgs;
        //private WoeRsltInfoList _WoeRsltInfoList;
        //private WoeRsltInfoRsList _WoeRsltInfoRsList;
        private WoeRsltInfoHuList _WoeRsltInfoHuList;
        private WorkResultList _workResultList;

        public WoeRsltInfoMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            

            _WoeRsltInfoArgs = new WoeRsltInfoArgs();
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.CompCd = Common.LoginInfo.UserInfo.CompCode;

            _WoeRsltInfoPocket = new WoeRsltInfoPocket();
            _workResultList = new WorkResultList(_WoeRsltInfoArgs, _WoeRsltInfoPocket);
            _WoeRsltInfoHuList = new WoeRsltInfoHuList(_WoeRsltInfoArgs, _WoeRsltInfoPocket);

            AddSubForm(this, _workResultList, layoutControlGroup2);
            AddSubForm(this, _WoeRsltInfoHuList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _WoeRsltInfoArgs,
                InitlistForm = _workResultList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);

            LookUpEditHelper.SetCompCode(sleCompCd);

            sleCompCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isTotalRow: false, isFirstSelect: true);
            };

            slePlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetWorkCenter(sleWcCd, sleCompCd.EditValue?.ToString(), slePlantCd.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true);
            };
            sleCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;

            _workResultList.ModelSelectedEvent += WorkResultList_ModelSelectedEvent;
        }

        private void WorkResultList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.WoNo = ((WorkResultModel)e.SelectedModelArgsBase.SelectedModelBase).WO_NO;
            _WoeRsltInfoHuList.DataRefresh(_WoeRsltInfoArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.CompCd = sleCompCd.EditValue?.ToString();
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.PlantCd = slePlantCd.EditValue?.ToString();
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.WcCd = sleWcCd.EditValue?.ToString();
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.ItemCd = stxtItemCd.EditValue?.ToString();
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.ItemNm = stxtItemNm.EditValue?.ToString();
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.WoDtFrom = sdeWoDtFrom.DateTime;
            _WoeRsltInfoArgs.woeRsltInfoModelArgs.WoDtTo = sdeWoDtTo.DateTime;
            _WoeRsltInfoHuList.DataClear(_WoeRsltInfoArgs);

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}
