using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciInspStd_dy;
using BPack.Pocket.App.MD.QciInspStd_dy;
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

namespace BPack.Carrying.App.MD.QciInspStd_dy
{
    public partial class QciInspStdHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciInspStd_dyArgs _qciInspStd_DyArgs;
        private QciInspStd_dyPocket _qciInspStd_DyPocket;

        public QciInspStdHeaderList()
        {
            InitializeComponent();
        }

        public QciInspStdHeaderList(QciInspStd_dyArgs qciInspStd_DyArgs, QciInspStd_dyPocket qciInspStd_DyPocket):this()
        {
            this._qciInspStd_DyArgs = qciInspStd_DyArgs;
            this._qciInspStd_DyPocket = qciInspStd_DyPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = qciLinspStdHeaderModelBindingSource,
                FormArgs = _qciInspStd_DyArgs,
                ModelArgs = _qciInspStd_DyArgs.QciInspStd_dyModelArgs,
                InitModelType = typeof(QciLinspStdHeaderModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<QciInspStd_dyModelArgs, QciLinspStdHeaderModel>
                (_qciInspStd_DyPocket.SelectQciLinspStdHeaderModels
                , _qciInspStd_DyPocket.SaveQciLinspStdHeaderModel
                , _qciInspStd_DyPocket.SaveQciLinspStdHeaderModels);
            IsBestFitStrapGrid = true;
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnByQuery
                (
                    colITEM_GR_1
                    , "ItemGroupDetail"
                    , new 
                        { 
                        COMP_CD=_qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code
                        ,
                        PLANT_CD= _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Plant_Code
                        ,
                        ITEM_GR_CLS = "ITEM_GR_1"
                    }
                    ,"Code","Value"
                );
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType"
                , new { COMP_CD = _qciInspStd_DyArgs.QciInspStd_dyModelArgs.Select_Main_Comp_Code }
                , "품목유형코드", "품목유형명");
            

            LookUpEditHelper.SetGridColumnSysCode(colQCI_TYPE, "QCI_TYPE");
            
        }
    }
}
