using BPack.Model.App.MM.GirLocStock;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirLocStock;
using System;
using System.Windows.Forms;
using BPack.IStrap.Forms;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MM.GirLocStock
{
    public partial class GirLocStockMain : StrapMainForm
    {
        private GirLocStockArgs _girLocStockArgs;
        private GirLocStockPocket _girLocStockPocket;
        private LocStockList _locStockList;
        private LocGirList _locGirList;
        private LocHuList _locHuList;

        public GirLocStockMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _girLocStockArgs = new GirLocStockArgs();
            _girLocStockPocket = new GirLocStockPocket();
            _locStockList = new LocStockList(_girLocStockArgs, _girLocStockPocket);
            _locGirList = new LocGirList(_girLocStockArgs, _girLocStockPocket);
            _locHuList = new LocHuList(_girLocStockArgs, _girLocStockPocket);
            AddSubForm(this, _locStockList, layoutControlGroup2);
            AddSubForm(this, _locGirList, layoutControlGroup3);
            AddSubForm(this, _locHuList, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _girLocStockArgs,
                InitlistForm = _locStockList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);

            _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;

             luePlant.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girLocStockArgs.GirLocStockModelArgs.Select_Main_Plant_Cd = luePlant.EditValue?.ToString();

                LookUpEditHelper.SetWareHouse(lueWarehouse, _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd, luePlant.EditValue?.ToString(), isFirstSelect: true);
                LookUpEditHelper.SetByQuery(lueItemType, "ItemType", new { COMP_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd }, "품목유형코드", "품목유형명", isTotalRow: true, isFirstSelect: true);
            };


            lueWarehouse.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girLocStockArgs.GirLocStockModelArgs.Select_Main_Wh_Cd = lueWarehouse.EditValue?.ToString();
                LookUpEditHelper.SetLocation(lueLocation, _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd, luePlant.EditValue?.ToString(), lueWarehouse.EditValue?.ToString(), isFirstSelect: true);

            };

            lueLocation.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girLocStockArgs.GirLocStockModelArgs.Select_Main_Loc_Cd = lueLocation.EditValue?.ToString();
            };

            LookUpEditHelper.SetPlantCode(luePlant, _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd, isFirstSelect: true);
            _locStockList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _girLocStockArgs.GirLocStockModelArgs.Select_Stock_Item_Cd = ((LocStockModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
                _girLocStockArgs.GirLocStockModelArgs.Select_Item_Stock_Qty = ((LocStockModel)e.SelectedModelArgsBase.SelectedModelBase).CUR_STOCK_QTY;
                _locGirList.DataRefresh(_girLocStockArgs);
                _locHuList.DataRefresh(_girLocStockArgs);
            };
            //재고조정 버튼 권한
            if (this.LoginMenuAuthModel.DUMMY1_AUTH == true)
            {
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            
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
            _girLocStockArgs.GirLocStockModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _girLocStockArgs.GirLocStockModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _girLocStockArgs.GirLocStockModelArgs.Select_Main_Plant_Cd = luePlant.EditValue?.ToString();
            _girLocStockArgs.GirLocStockModelArgs.Select_Main_Wh_Cd = lueWarehouse.EditValue?.ToString();
            _girLocStockArgs.GirLocStockModelArgs.Select_Main_Loc_Cd = lueLocation.EditValue?.ToString();
            _girLocStockArgs.GirLocStockModelArgs.Select_Main_Item_Type = lueItemType.EditValue?.ToString();
            _girLocStockArgs.GirLocStockModelArgs.Select_Stock_Item_Cd = null;
            base.Refresh_From_ExecuteByRibbonButton();
        }
        //선택 식별표 재출력 버튼
        private void simpleButton11_Click(object sender, EventArgs e)
        {
            _locHuList.PrintHu();
        }

        private void chkTestPrint_CheckedChanged(object sender, EventArgs e)
        {
            _girLocStockArgs.GirLocStockModelArgs.TestPrint = chkTestPrint.Checked;
        }
        //선택행 재고조정
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_girLocStockArgs.GirLocStockModelArgs.Select_Stock_Item_Cd))
            {
                MessageBox.Show("품번이 선택되지 않았습니다.");
                return;
            }
            GirLocStockAdjust girLocStockAdjust = new GirLocStockAdjust(_girLocStockArgs, _girLocStockPocket);
            girLocStockAdjust.CompletedAdjust += GirLocStockAdjust_CompletedAdjust;
            girLocStockAdjust.ShowDialog();
            
        }

        private void GirLocStockAdjust_CompletedAdjust(object sender, EventArgs e)
        {
            _locStockList.DataRefresh(_girLocStockArgs);
            _locGirList.DataClear(_girLocStockArgs);
            _locHuList.DataClear(_girLocStockArgs);
        }
    }
}
