using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirHist;
using BPack.Model.App.MM.GirHist;
using BPack.Strap.EditControls;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MM.GirHist
{
    public partial class GirHistList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirHistArgs _girHistArgs;
        private GirHistPocket _girHistPocket;
        public GirHistList() 
        {
            InitializeComponent();
        }

        public GirHistList(GirHistArgs girHistArgs, GirHistPocket girHistPocket) : this() 
        {
            _girHistArgs = girHistArgs;
            _girHistPocket = girHistPocket;
        }

        public override void InitStrap() 
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() { 
                BindingSource = girHistModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girHistArgs,
                GridView = gridView1,
                InitModelType = typeof(GirHistModel),
                ModelArgs = _girHistArgs.GirHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });

            InitPocketDelegate<GirHistModelArgs, GirHistModel>(_girHistPocket.SelectGirHistModels, null);

            colIsCheck.Visible = false;


        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd, PLANT_CD = _girHistArgs.GirHistModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colGIR_TYPE_CD, "GirType", new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd }, "CODE", "NAME");
            LookUpEditHelper.SetItemType(colITEM_TYPE_CD, _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd);

            base.DataRefresh(args);
            colITEM_NM.Width = 200;
        }

    }

}