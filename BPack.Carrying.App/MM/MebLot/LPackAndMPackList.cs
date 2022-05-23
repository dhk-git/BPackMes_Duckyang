using BPack.Model.App.MM.MebLot;
using BPack.Pocket.App.MM.MebLot;
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

namespace BPack.Carrying.App.MM.MebLot
{
    public partial class LPackAndMPackList : StrapSubForm_OnlyOneGrid_V2
    {
        private MebLotArgs _mebLotArgs;
        private MebLotPocket _mebLotPocket;

        public LPackAndMPackList()
        {
            InitializeComponent();
        }

        public LPackAndMPackList(MebLotArgs mebLotArgs, MebLotPocket mebLotPocket) : this()
        {
            this._mebLotArgs = mebLotArgs;
            this._mebLotPocket = mebLotPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _mebLotArgs,
                GridView = gridView1,
                InitModelType = typeof(LPackAndMPackModel),
                ModelArgs = _mebLotArgs.MebLotModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<MebLotModelArgs, LPackAndMPackModel>(_mebLotPocket.SelectLPackAndMPackModels, null);
            colSEND_YN.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            colUSE_YN.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            colSAVE_DTTM.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            colSAVE_BY.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            colCREATE_DTTM.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            colCREATE_BY.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;

        }

        public override void ExcelExport(ArgsBase args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                dic.Add(col.FieldName, col.Caption);
                col.Caption = col.FieldName;
            }
            base.ExcelExport(args);
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                col.Caption = dic[col.FieldName];
            }
        }
    }
}
