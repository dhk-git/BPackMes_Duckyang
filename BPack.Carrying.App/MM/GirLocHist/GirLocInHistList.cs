using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirLocHist;
using BPack.Pocket.App.MM.GirLocHist;
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

namespace BPack.Carrying.App.MM.GirLocHist
{
    public partial class GirLocInHistList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirLocHistArgs _girLocHistArgs;
        private GirLocHistPocket _girLocHistPocket;

        public GirLocInHistList()
        {
            InitializeComponent();
        }
        public GirLocInHistList(GirLocHistArgs girLocHistArgs, GirLocHistPocket girLocHistPocket) : this()
        {
            _girLocHistArgs = girLocHistArgs;
            _girLocHistPocket = girLocHistPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = girLocInModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girLocHistArgs,
                GridView = gridView1,
                InitModelType = typeof(GirLocInModel),
                ModelArgs = _girLocHistArgs.GirLocHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirLocHistModelArgs, GirLocInModel>(_girLocHistPocket.SelectGirLocInHistModels, null);
        }
        public override void DataRefresh(ArgsBase args)
        {
            //창고
            LookUpEditHelper.SetWareHouse(colWH_CD
                , _girLocHistArgs.GirLocHistModelArgs.Select_Main_Comp_Cd
                , _girLocHistArgs.GirLocHistModelArgs.Select_Main_Plant_Cd);
            //위치
            LookUpEditHelper.SetLocation(colLOC_CD
                , _girLocHistArgs.GirLocHistModelArgs.Select_Main_Comp_Cd
                , _girLocHistArgs.GirLocHistModelArgs.Select_Main_Plant_Cd, "");
            
            //위치입고유형
            LookUpEditHelper.SetGridColumnSysCode(colLOC_IN_TYPE, "LOC_IN_TYPE");

            //참조문서유형
            LookUpEditHelper.SetGridColumnSysCode(colREF_DOC_TYPE, "DOC_TYPE");
            
            base.DataRefresh(args);
            
        }
    }
}
