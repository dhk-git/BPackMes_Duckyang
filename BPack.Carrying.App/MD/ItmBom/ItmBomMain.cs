using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.ItmBom;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmBom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Common.Config;

namespace BPack.Carrying.App.MD.ItmBom
{
    public partial class ItmBomMain : StrapMainForm
    {
        private ItmBomArgs _ItmBomMainArgs;
        private ItmBomPocket _itmBomPocket;
        private ItemList _itemList;
        private BomHeaderList _bomHeader;
        private BomDetailList _bomDetail;

        public ItmBomMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _ItmBomMainArgs = new ItmBomArgs();
            _itmBomPocket = new ItmBomPocket();
            _itemList = new ItemList(_ItmBomMainArgs, _itmBomPocket);
            _bomHeader = new BomHeaderList(_ItmBomMainArgs, _itmBomPocket);
            _bomDetail = new BomDetailList(_ItmBomMainArgs, _itmBomPocket);

            AddSubForm(this, _itemList, layoutControlGroup2);
            AddSubForm(this, _bomHeader, layoutControlGroup3);
            AddSubForm(this, _bomDetail, layoutControlGroup4);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _ItmBomMainArgs,
                InitlistForm = _itemList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            _itemList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _ItmBomMainArgs.itmBomModelArgs.Select_Comp_Code = ((ItemInfoModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _ItmBomMainArgs.itmBomModelArgs.Select_Plant_Code = ((ItemInfoModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
                _ItmBomMainArgs.itmBomModelArgs.Select_Item_Code = ((ItemInfoModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;

                _bomHeader.DataRefresh(_ItmBomMainArgs);
                _bomDetail.DataClear(_ItmBomMainArgs);
                _bomHeader.SelectModelAndRaiseEvent(0);
                
            };

            _bomHeader.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _ItmBomMainArgs.itmBomModelArgs.Select_Bom_No = ((BomHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).BOM_NO;

                _bomDetail.DataRefresh(_ItmBomMainArgs);
            };
            _bomHeader.ModelDeletedEvent += _bomHeader_ModelDeletedEvent;

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _itemList) { SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false); }
                if (this.SelectedSubForm == _bomHeader) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: true); }
                if (this.SelectedSubForm == _bomDetail) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true,save:true); }
            };
            LookUpEditHelper.SetByQuery(strapLookUpEdit3, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() });
                strapLookUpEdit2.EditValue = strapLookUpEdit2.Properties.GetDataSourceValue("CODE", 0);
            };

            ctl_Copy_date.EditValue = DateTime.Now;
        }

        private void _bomHeader_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _bomHeader.DataRefresh(_ItmBomMainArgs);
            _bomDetail.DataClear(_ItmBomMainArgs);
            _bomHeader.SelectModelAndRaiseEvent(0);

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _ItmBomMainArgs.itmBomModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _ItmBomMainArgs.itmBomModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _ItmBomMainArgs.itmBomModelArgs.Select_Main_Item_Code = strapTextEdit1.EditValue?.ToString();
            _ItmBomMainArgs.itmBomModelArgs.Select_Main_Item_Name = strapTextEdit2.EditValue?.ToString();
            _ItmBomMainArgs.itmBomModelArgs.Select_Main_Main_Model = strapLookUpEdit3.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            //리비전 복사
            _bomHeader.CopyBom((DateTime) ctl_Copy_date.EditValue);

            _bomHeader.DataRefresh(_ItmBomMainArgs);


        }
    }
}
