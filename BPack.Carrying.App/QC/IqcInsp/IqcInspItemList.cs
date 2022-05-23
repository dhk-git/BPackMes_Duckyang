using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.IqcInsp;
using BPack.Pocket.App.QC.IqcInsp;
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

namespace BPack.Carrying.App.QC.IqcInsp
{
    public partial class IqcInspItemList : StrapSubForm_OnlyOneGrid_V2
    {
        IqcInspArgs _movLocArgs;
        IqcInspPocket _movLocPocket;
        //ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;
        public IqcInspItemList()
        {
            InitializeComponent();
        }
        public IqcInspItemList(IqcInspArgs movLocArgs, IqcInspPocket movLocPocket) : this()
        {
            _movLocArgs = movLocArgs;
            _movLocPocket = movLocPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = IqcInspItemModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _movLocArgs,
                GridView = gridView1,
                InitModelType = typeof(IqcInspItemModel),
                ModelArgs = _movLocArgs.IqcInspModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<IqcInspModelArgs, IqcInspItemModel>(_movLocPocket.SelectDetailModels, _movLocPocket.SaveItemModel,_movLocPocket.SaveItemModels);
          

            LookUpEditHelper.SetGridColumnSysCode(colIQC_INSD_STATUS, "IQC_INSD_STATUS");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode"
            , new
            {
                COMP_CD = _movLocArgs.IqcInspModelArgs.Select_Main_Comp_Cd
                ,
                PLANT_CD = _movLocArgs.IqcInspModelArgs.Select_Main_Plant_Cd
                ,
                ITEM_GR_CLS = "ITEM_GR_1"
            }
            , "Code", "Name");
            
        }
        public override void DataRefresh(ArgsBase args)
        {   
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode"
            , new
            {
                COMP_CD = _movLocArgs.IqcInspModelArgs.Select_Main_Comp_Cd
                ,
                PLANT_CD = _movLocArgs.IqcInspModelArgs.Select_Main_Plant_Cd
                ,
                ITEM_GR_CLS = "ITEM_GR_1"
            }
            , "Code", "Name");

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType"
            , new
            {
                COMP_CD = _movLocArgs.IqcInspModelArgs.Select_Main_Comp_Cd
                ,
                PLANT_CD = _movLocArgs.IqcInspModelArgs.Select_Main_Plant_Cd
                ,
            }
              , "Code", "Name");
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            //((IqcInspItemModel)model).COMP_CD = _movLocArgs.IqcInspModelArgs.Select_Main_Comp_cd;
            //((IqcInspItemModel)model).PLANT_CD = _movLocArgs.IqcInspModelArgs.Select_Main_Plant_cd;
 
            //((IqcInspItemModel)model).IQC_NO = _movLocArgs.IqcInspModelArgs.Select_Main_IQC_NO;
        }

    }
}
