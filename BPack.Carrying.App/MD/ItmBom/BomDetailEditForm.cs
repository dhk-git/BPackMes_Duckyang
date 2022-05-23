using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Strap.FormControls;
using BPack.Model.App.MD.ItmBom;
using BPack.Strap.EditControls;
using BPack.Pocket.App.MD.ItmBom;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.ItmBom
{
    public partial class BomDetailEditForm : StrapEditForm
    {
        private BomDetailModel _bomDetailModel;
        private ItmBomArgs _itmBomArgs;
        private ItmBomPocket _itmBomPocket;

        public BomDetailEditForm(ItmBomArgs itmBomArgs, ItmBomPocket itmBomPocket)
        {
            InitializeComponent();

            _itmBomArgs = itmBomArgs;
            _itmBomPocket = itmBomPocket;

            InitBoundFieldName<BomDetailModel>(strapDataLayout1);
            itemMasterButtonEdit1.InitStrap();
            //MAT_BOM_NOLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            itemMasterButtonEdit1.ButtonClick += (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) =>
            {
                itemMasterButtonEdit1.InitCompCode(_itmBomArgs.itmBomModelArgs.Select_Comp_Code);
                itemMasterButtonEdit1.InitPlantCode(_itmBomArgs.itmBomModelArgs.Select_Plant_Code);
                itemMasterButtonEdit1.DataClear();
            };


        }

        public void DataRefresh(object datasource)
        {
            _bomDetailModel = (BomDetailModel)datasource;
            bomDetailModelBindingSource.DataSource = _bomDetailModel;

            LookUpEditHelper.SetCommonCode(BOM_UNITLookUpEdit, _itmBomArgs.itmBomModelArgs.Select_Comp_Code, "UNIT");
            //GetLookUpEditValues();

        }

        private void ITEM_CDTextEdit_Validating(object sender, CancelEventArgs e)
        {
            _itmBomArgs.itmBomModelArgs.Select_EditForm_Item_Code = itemMasterButtonEdit1.EditValue?.ToString();
            var source = _itmBomPocket.SelectitemInfoModel(_itmBomArgs.itmBomModelArgs);
            
            if (source == null)
            {
                itemMasterButtonEdit1.ErrorText = "품목 정보가 없습니다.";
                e.Cancel = true;
            }
            else
            {
                _bomDetailModel.ITEM_CD = source.ITEM_CD;
                _bomDetailModel.ITEM_NM = source.ITEM_NM;
                GetLookUpEditValues();
            }
        }

        private void GetLookUpEditValues()
        {
            Dictionary<string, string> cols = new Dictionary<string, string>();
            cols.Add("BOM_NO", "BOM번호");
            cols.Add("BOM_REV", "Rev.");
            cols.Add("BOM_KIND", "BOM종류");
            //LookUpEditHelper.SetByQuery(MAT_BOM_NOLookUpEdit, "ItemBom.MatBomNo",
            //    new
            //    {
            //        COMP_CD = _itmBomArgs.itmBomModelArgs.Select_Comp_Code,
            //        PLANT_CD = _itmBomArgs.itmBomModelArgs.Select_Plant_Code,
            //        ITEM_CD = _itmBomArgs.itmBomModelArgs.Select_EditForm_Item_Code
            //    }, cols, "BOM_NO", "BOM_NO");
            //MAT_BOM_NOLookUpEdit.Properties.BestFit();
        }
    }
}
