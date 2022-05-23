using BPack.Common.Model;
using BPack.Model.App.MM.InvAdjust;
using BPack.Pocket.App.MM.InvAdjust;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.InvAdjust
{
    public partial class InvAdjHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvAdjustArgs _invAdjustArgs;
        private InvAdjustPocket _invAdjustPocket;
        private LookUpEditPocket _lep;
        
        public event EventHandler AdjHuSaved;

        public InvAdjHuList()
        {
            InitializeComponent();
        }

        public InvAdjHuList(InvAdjustArgs invAdjustArgs, InvAdjustPocket invAdjustPocket) : this()
        {
            this._invAdjustArgs = invAdjustArgs;
            this._invAdjustPocket = invAdjustPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = invAdjHuModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _invAdjustArgs,
                GridView = gridView1,
                InitModelType = typeof(InvAdjHuModel),
                ModelArgs = _invAdjustArgs.InvAdjustModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<InvAdjustModelArgs, InvAdjHuModel>(_invAdjustPocket.SelectInvAdjHuModels, null, _invAdjustPocket.SaveInvAdjHuModels);
            _lep = LookUpEditPocket.GetInstance();
            _lep.SetGridColumnSysCode(colINV_RSLT_HU_STATUS, "INV_RSLT_HU_STATUS");
            gridView1.ValidatingEditor += GridView1_ValidatingEditor;
        }

        private void GridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if ((sender as GridView).FocusedColumn.Name == "colPHYSI_STOCK")
            {
                var huType = ((InvAdjHuModel)invAdjHuModelBindingSource.Current).HU_NO.Substring(0, 3);
                if (huType.Equals("PRS") || huType.Equals("PRG"))
                {
                    if (Convert.ToDecimal(e.Value) > 1)
                    {
                        e.Valid = false;
                        e.ErrorText = "개별식별표는 수량 '0' 혹은 '1' 만 등록가능합니다.";
                        return;
                    }
                }

            }
        }

        protected override void SetUpdateDefaultValue(ModelBase model)
        {
            ((InvAdjHuModel)model).DIFF_STOCK = ((InvAdjHuModel)model).PHYSI_STOCK - ((InvAdjHuModel)model).LOGI_STOCK;
            base.SetUpdateDefaultValue(model);
        }
        
        public List<InvAdjHuModel> GetSelectedInvAdjHuModels()
        {
            return ((List<InvAdjHuModel>)invAdjHuModelBindingSource.DataSource).Where(a => a.IsCheck == true).ToList();
        }

        //대상식별표를 결과에 등록
        public void AddInvResultLikeLogi(List<InvAdjHuModel> selectedInvAdjHuModels)
        {
            List<InvAdjAddResultLikeLogiModel> invAdjAddResultLikeLogiModels = new List<InvAdjAddResultLikeLogiModel>();
            foreach (var model in selectedInvAdjHuModels)
            {
                invAdjAddResultLikeLogiModels.Add(new InvAdjAddResultLikeLogiModel 
                {
                    COMP_CD = model.COMP_CD,
                    PLANT_CD = model.PLANT_CD,
                    ITEM_CD = model.ITEM_CD,
                    HU_NO = model.HU_NO,
                    INVD_NO = model.INVD_NO,
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                    LOGI_STOCK = model.LOGI_STOCK,
                    LOGI_PARENT_HU_NO = model.LOGI_PARENT_HU_NO
                });
            }
            _invAdjustPocket.BpAddInvResultLikeLogi(invAdjAddResultLikeLogiModels);
        }

        protected override void SaveSuccess(ModelBase model)
        {
            base.SaveSuccess(model);
            AdjHuSaved?.Invoke(null, null);
        }

    }
}
