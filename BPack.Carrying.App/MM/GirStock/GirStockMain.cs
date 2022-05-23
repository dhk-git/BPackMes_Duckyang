using BPack.Common.Pocket;
using BPack.Model.App.MM.GirStock;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;
using BPack.IStrap.Forms;

namespace BPack.Carrying.App.MM.GirStock
{
    public partial class GirStockMain : StrapMainForm
    {
        private GirStockArgs _girStockArgs;
        private GirStockPocket _girStockPocket;
        private StockList _stockList;
        private GirList _girList;
        //private WhHuList _whHuList;

        public GirStockMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _girStockArgs = new GirStockArgs();
            _girStockPocket = new GirStockPocket();
            _stockList = new StockList(_girStockArgs, _girStockPocket);
            _girList = new GirList(_girStockArgs, _girStockPocket);
            //_whHuList = new WhHuList(_girStockArgs, _girStockPocket);
            AddSubForm(this, _stockList, layoutControlGroup2);
            AddSubForm(this, _girList, layoutControlGroup3);
            //AddSubForm(this, _whHuList, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _girStockArgs,
                InitlistForm = _stockList,
                StrapLayout = strapLayout1
            });

            InitRibbonButtons(true);

            _stockList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _girStockArgs.GirStockModelArgs.Select_Stock_Item_Cd = ((StockModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
                _girList.DataRefresh(_girStockArgs);
                //_whHuList.DataRefresh(_girStockArgs);
            };

            _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetWareHouse(strapLookUpEdit2, _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd, strapLookUpEdit1.EditValue?.ToString(), isFirstSelect: true);
                LookUpEditHelper.SetByQuery(lueItemType, "ItemType", new { COMP_CD = _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd }, "품목유형코드", "품목유형명", isTotalRow: true, isFirstSelect: true);
            };

            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, new { COMP_CD = _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd }, isFirstSelect: true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit3, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);

            strapDateEdit1.EditValue = DateTime.Now.Date;
            strapDateEdit2.EditValue = DateTime.Now.Date;

        }

        public override void ExecuteByRibbonButton(ButtonKind buttonKind)
        {
            if (buttonKind == ButtonKind.Refresh)
            {
                if ((DateTime)strapDateEdit1.EditValue > (DateTime)strapDateEdit2.EditValue)
                {
                    StrapMessageBox.Show("A003", 17, MessageBoxButtons.OK);
                    strapDateEdit1.Focus();
                    return;
                }
            }
            base.ExecuteByRibbonButton(buttonKind);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _girStockArgs.GirStockModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _girStockArgs.GirStockModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _girStockArgs.GirStockModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _girStockArgs.GirStockModelArgs.Select_Main_Wh_Cd = strapLookUpEdit2.EditValue?.ToString();
            _girStockArgs.GirStockModelArgs.Select_Main_Item_Type = lueItemType.EditValue?.ToString();
            _girStockArgs.GirStockModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit3.EditValue?.ToString();
            _girStockArgs.GirStockModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _girStockArgs.GirStockModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}
