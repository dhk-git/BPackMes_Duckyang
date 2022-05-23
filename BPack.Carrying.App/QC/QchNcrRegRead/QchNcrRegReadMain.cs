using BPack.Carrying.App.QC.QchPatrolRead;
using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchNcrRegRead;
using BPack.Pocket.App.QC.QchNcrRegRead;
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

namespace BPack.Carrying.App.QC.QchNcrRegRead
{
    public partial class QchNcrRegReadMain : StrapMainForm
    {
        private QchNcrRegReadArgs _readArgs;
        private QchNcrRegReadPocket _regReadPocket;
        private QchNcrRegReadHeaderList _headerList;
        private QchNcrRegReadDetailList _detailList;
        public QchNcrRegReadMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _readArgs = new QchNcrRegReadArgs();
            _regReadPocket = new QchNcrRegReadPocket();
            _headerList = new QchNcrRegReadHeaderList(_readArgs, _regReadPocket);
            _detailList= new QchNcrRegReadDetailList(_readArgs, _regReadPocket);
            AddSubForm(this, _headerList, layoutControlGroup2);
            AddSubForm(this, _detailList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _readArgs,
                InitlistForm = _headerList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, false, false, false);

            LookUpEditHelper.SetCompCode(sleCompCd);
            LookUpEditHelper.SetSysCode(ctl_nchType, "NCH_TYPE");

            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;
            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;
            strapButtonEdit_ItemMaster1.InitStrap();

            sleCompCd.EditValue = UserInfo.CompCode;
            slePlantCd.EditValue = UserInfo.PlantCode;
            De_Start_dt.EditValue = DateTime.Now;
            De_End_dt.EditValue = DateTime.Now;
            _headerList.ModelSelectedEvent += _headerList_ModelSelectedEvent;

        }

        private void _headerList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _readArgs.QchNcrRegReadModelArgs.Comp_cd
          = ((QchNcrRegReadHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _readArgs.QchNcrRegReadModelArgs.Plant_cd
                = ((QchNcrRegReadHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
            _readArgs.QchNcrRegReadModelArgs.Start_dt
                            = ((QchNcrRegReadHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).NCH_DT;
            _readArgs.QchNcrRegReadModelArgs.Item_cd
                = ((QchNcrRegReadHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;


            _detailList.DataRefresh(_readArgs);
        }

        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
            _readArgs.QchNcrRegReadModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            strapButtonEdit_ItemMaster1.InitCompCode(_readArgs.QchNcrRegReadModelArgs.Select_Main_Comp_Cd);
        }
        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _readArgs.QchNcrRegReadModelArgs.Plant_cd = slePlantCd.EditValue?.ToString();
            strapButtonEdit_ItemMaster1.InitPlantCode(_readArgs.QchNcrRegReadModelArgs.Plant_cd);
            LookUpEditHelper.SetByQuery(strapLookUpEditItem_Gr_1, "ItemGroupDetail", 
                new { COMP_CD = _readArgs.QchNcrRegReadModelArgs.Comp_cd,
                        PLANT_CD = slePlantCd.EditValue?.ToString(), ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _readArgs.QchNcrRegReadModelArgs.Select_Main_Comp_Cd
              = sleCompCd.EditValue?.ToString();
            _readArgs.QchNcrRegReadModelArgs.Select_Main_Plant_Cd
                = slePlantCd.EditValue?.ToString();
            _readArgs.QchNcrRegReadModelArgs.Select_Main_Start_dt
                = De_Start_dt.DateTime;
            _readArgs.QchNcrRegReadModelArgs.Select_Main_End_dt
                = De_End_dt.DateTime;
            _readArgs.QchNcrRegReadModelArgs.Select_Main_Item_Group1= strapLookUpEditItem_Gr_1.EditValue?.ToString();
            _readArgs.QchNcrRegReadModelArgs.Select_Main_Item_Cd = strapButtonEdit_ItemMaster1.EditValue?.ToString();
            _readArgs.QchNcrRegReadModelArgs.Select_Main_Item_Nm = strapTextEdit1.EditValue?.ToString();

            _readArgs.QchNcrRegReadModelArgs.Select_Main_Nch_Type = ctl_nchType.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
            _headerList.SelectModelAndRaiseEvent(0);
        }
    }
}
