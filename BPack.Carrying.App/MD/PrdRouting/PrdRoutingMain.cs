using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdRouting;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdRouting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Common.LoginInfo;
using DevExpress.XtraRichEdit.Model;

namespace BPack.Carrying.App.MD.PrdRouting
{
    public partial class PrdRoutingMain : StrapMainForm
    {
        private PrdRoutingArgs _prdRoutingArgs;
        private PrdRoutingPocket _prdRoutingPocket;

        private RoutingList _routingList;
        private OperationList _operationList;
        private MaterialList _materialList;

        private BomItemSelector _bomItemSelector;

        public PrdRoutingMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            _prdRoutingArgs = new PrdRoutingArgs();
            _prdRoutingPocket = new PrdRoutingPocket();
            _routingList = new RoutingList(_prdRoutingArgs, _prdRoutingPocket);
            _operationList = new OperationList(_prdRoutingArgs, _prdRoutingPocket);
            _materialList = new MaterialList(_prdRoutingArgs, _prdRoutingPocket);

            AddSubForm(this, _routingList, layoutControlGroup2);
            AddSubForm(this, _operationList, layoutControlGroup3);
            AddSubForm(this, _materialList, layoutControlGroup4);

            _routingList.AddRefreshTargetSubForm(_operationList);
            _routingList.AddRefreshTargetSubForm(_materialList);
            _operationList.AddRefreshTargetSubForm(_materialList);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdRoutingArgs,
                InitlistForm = _routingList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                //strapLookUpEdit2.EditValue = strapLookUpEdit2.Properties.GetDataSourceValue("CODE", 0);
            };
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _routingList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, save: true, delete: true); }
                if (this.SelectedSubForm == _operationList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: true, delete: true); }
                if (this.SelectedSubForm == _materialList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: true, delete: true); }
            };

            _routingList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Route_No = ((RoutingModel)e.SelectedModelArgsBase.SelectedModelBase).ROUTE_NO;
                _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Item_Code = ((RoutingModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
                _prdRoutingArgs.PrdRoutingModelArgs.Select_OperationList_Oper = 0;

                _operationList.DataRefresh(_prdRoutingArgs);
                _materialList.DataClear(_prdRoutingArgs);
            };

            _operationList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _prdRoutingArgs.PrdRoutingModelArgs.Select_OperationList_Oper = ((OperationModel)e.SelectedModelArgsBase.SelectedModelBase).OPER;

                _materialList.DataRefresh(_prdRoutingArgs);
            };
            splitterItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlGroup4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Item_Code = strapButtonEdit_ItemMaster1.EditValue?.ToString();
            _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Route_No = strapTextEdit1.EditValue?.ToString();

            _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Route_No = null;
            _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Item_Code = null;
            _prdRoutingArgs.PrdRoutingModelArgs.Select_OperationList_Oper = null;

            _operationList.LookupEditDataRefresh();

            base.Refresh_From_ExecuteByRibbonButton();
        }


        private void strapButton1_Click(object sender, EventArgs e)
        {

            _routingList.CopyRouting();
            _routingList.DataRefresh(_prdRoutingArgs);

        }

        private void strapButton2_Click(object sender, EventArgs e)
        {
            if (_prdRoutingArgs.SelectedModelArgsBase.SelectedModelBase == null ||
                _operationList.GetSelectedUserModel() == null ||
                _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Route_No == null ||
                _prdRoutingArgs.PrdRoutingModelArgs.Select_OperationList_Oper == null || _prdRoutingArgs.PrdRoutingModelArgs.Select_OperationList_Oper == 0)
            {
                StrapMessageBox.Show("A001", 9);
                return;
            }

            _bomItemSelector = new BomItemSelector(_prdRoutingArgs);
            _bomItemSelector.SelectedComplate += _bomItemSelector_SelectedComplate;
            _bomItemSelector.ShowDialog();

        }

        private void _bomItemSelector_SelectedComplate(object sender, PrdRoutingSelectedEventArgs e)
        {
            var models = e.SeletedBomDetailModels;
            var materialModels = ((List<MaterialModel>)_materialList.materialModelBindingSource.DataSource);

            foreach (var model in models)
            {
                if (!materialModels.Select(r => r.ITEM_CD).Contains(model.ITEM_CD))
                {
                    _materialList.gridView1.PostEditor();
                    var materialModel = new MaterialModel();

                    materialModel.IsCheck = true;
                    materialModel.RowState = Common.Model.RowState.Added;
                    materialModel.LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language;
                    materialModel.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                    materialModel.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;

                    materialModel.COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code;
                    materialModel.PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code;
                    materialModel.ROUTE_NO = _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Route_No;
                    materialModel.OPER = _prdRoutingArgs.PrdRoutingModelArgs.Select_OperationList_Oper;
                    materialModel.OPER_QTY = model.BOM_QTY;
                    materialModel.OPER_UNIT = model.BOM_UNIT;
                    materialModel.ITEM_CD = model.ITEM_CD;
                    materialModel.ITEM_NM = model.ITEM_NM;
                    materialModel.ITEM_SPEC = model.ITEM_SPEC;
                    materialModel.ITEM_GR_1 = model.ITEM_GR_1;
                    materialModel.ALC_CD = model.ALC_CD;
                    materialModel.MAT_INPUT_TYPE = "A";

                    materialModels.Add(materialModel);

                    _materialList.gridView1.UpdateCurrentRow();
                    _materialList.gridView1.BestFitColumns();

                }
            }
            _materialList.materialModelBindingSource.ResetBindings(false);
        }
    }
}

