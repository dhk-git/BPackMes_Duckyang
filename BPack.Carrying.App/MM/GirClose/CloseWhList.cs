using BPack.Model.App.MM.GirClose;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirClose;
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

namespace BPack.Carrying.App.MM.GirClose
{
    public partial class CloseWhList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirCloseArgs _girCloseArgs;
        private GirClosePocket _girClosePocket;

        public CloseWhList()
        {
            InitializeComponent();
        }

        public CloseWhList(GirCloseArgs girCloseArgs, GirClosePocket girClosePocket) : this()
        {
            _girCloseArgs = girCloseArgs;
            _girClosePocket = girClosePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = closeWhModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girCloseArgs,
                GridView = gridView1,
                InitModelType = typeof(CloseWhModel),
                ModelArgs = _girCloseArgs.GirCloseModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirCloseModelArgs, CloseWhModel>(_girClosePocket.SelectCloseWhModels, null);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetWareHouse(colWH_CD, _girCloseArgs.GirCloseModelArgs.Select_Comp_Cd, _girCloseArgs.GirCloseModelArgs.Select_Main_Plant_Cd);

            gridView1.BestFitColumns();
        }
    }
}
