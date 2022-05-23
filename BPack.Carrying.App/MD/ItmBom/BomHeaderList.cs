using BPack.Common.Model;
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
using BPack.CommonMes.Helpers;
using BPack.Common.Config;
using BPack.Common.LoginInfo;

namespace BPack.Carrying.App.MD.ItmBom
{
    public partial class BomHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmBomArgs _ItmBomMainArgs;
        private ItmBomPocket _itmBomPocket;

        public BomHeaderList(ItmBomArgs ItmBomMainArgs, ItmBomPocket itmBomPocket)
        {
            InitializeComponent();

            _ItmBomMainArgs = ItmBomMainArgs;
            _itmBomPocket = itmBomPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bomHeaderModelBindingSource,
                GridView = gridView1,
                InitModelType = typeof(BomHeaderModel),
                FormArgs = _ItmBomMainArgs,
                ModelArgs = _ItmBomMainArgs.itmBomModelArgs
                ,StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ItmBomModelArgs, BomHeaderModel>(_itmBomPocket.SelectBomHeaderModels, _itmBomPocket.SaveBomHeader, _itmBomPocket.SaveBomHeaders);

            LookUpEditHelper.SetGridColumnSysCode(colBOM_TYPE, "BOM_KIND");
            LookUpEditHelper.SetGridColumnSysCode(colIS_PHANTOM, "IS_PHANTOM");

            colITEM_CD.MinWidth = 170;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((BomHeaderModel)model).COMP_CD = _ItmBomMainArgs.itmBomModelArgs.Select_Comp_Code;
            ((BomHeaderModel)model).PLANT_CD = _ItmBomMainArgs.itmBomModelArgs.Select_Plant_Code;
            ((BomHeaderModel)model).ITEM_CD = _ItmBomMainArgs.itmBomModelArgs.Select_Item_Code;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            
            //LookUpEditHelper.SetGridColumnCommonCode(colBOM_TYPE, _ItmBomMainArgs.itmBomModelArgs.Select_Comp_Code, "BOM_KIND");
            LookUpEditHelper.SetGridColumnSysCode(colBOM_TYPE,"BOM_KIND");
        }

        internal BomHeaderModel GetCheckedData()
        {
            int cnt = ((List<BomHeaderModel>)this.SelectedModels).Where(v => v.IsCheck == true).Count();

            if (cnt != 1)
            {
                //1개 행을 선택 후  [BOM 복사]를 사용하십시오
                StrapMessageBox.Show("A001", 95);
                return null;
            }
            else
            {
                return ((List<BomHeaderModel>)this.SelectedModels).Where(v => v.SelectedCheck == 1).Single();
            }
        }

        internal void CopyBom(DateTime copyDate)
        {
            
            BomHeaderModel model=GetCheckedData();
            try
            {
                if (model != null)
                {
                    BomCopyModel copyModel = new BomCopyModel()
                    {
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID
                                ,
                        MODIFY_DTTM = DateTime.Now
                              ,
                        MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
                              ,
                        CREATE_DTTM = DateTime.Now
                             ,
                        LANG_CODE = UserInfo.Sys_Language
                            ,
                        COMP_CD = model.COMP_CD
                            ,
                        PLANT_CD = model.PLANT_CD
                            ,
                        BOM_NO_KEY = model.BOM_NO_KEY
                         ,
                        ITEM_CD = model.ITEM_CD
                         ,
                        VALID_FROM_DT = copyDate
                    };

                    _itmBomPocket.CopyBom(copyModel);
                }
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }

    }
}
