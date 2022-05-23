using BPack.Model.App.MM.InpMatHist;
using BPack.Pocket.App.MM.InpMatHist;
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

namespace BPack.Carrying.App.MM.InpMatHist
{
    public partial class InpMatHistHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private InpMatHistArgs _inpMatHistArgs;
        private InpMatHistPocket _inpMatHistPocket;

        public InpMatHistHeaderList()
        {
            InitializeComponent();
        }

        public InpMatHistHeaderList(InpMatHistArgs inpMatHistArgs, InpMatHistPocket inpMatHistPocket) : this()
        {
            this._inpMatHistArgs = inpMatHistArgs;
            this._inpMatHistPocket = inpMatHistPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = inpMatHistHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _inpMatHistArgs,
                GridView = gridView1,
                InitModelType = typeof(InpMatHistHeaderModel),
                ModelArgs = _inpMatHistArgs.InpMatHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InpMatHistModelArgs, InpMatHistHeaderModel>(_inpMatHistPocket.SelectInpMatHistHeaderModels, null, null);
            //gridView1.Columns["BP_NM"].Group();
            ////gridView1.GroupSummary.Add(summaryType: DevExpress.Data.SummaryItemType.Count, "SUM_PURIN_QTY");
            //gridView1.GroupSummary.Add(new DevExpress.XtraGrid.GridGroupSummaryItem() { 
            //    FieldName = "SUM_GR_QTY",
            //    SummaryType = DevExpress.Data.SummaryItemType.Sum,
            //    DisplayFormat = "Sum : {0:#,##0.#}",
            //    ShowInGroupColumnFooter = gridView1.Columns["SUM_GR_QTY"]
            //});
            if (!this.AuthModel.DUMMY1_AUTH)
            {
                colSUM_AMOUNT.Visible = false;
                colSUM_AMOUNT.OptionsColumn.ShowInCustomizationForm = false;
                colCURRENCY_TYPE.Visible = false;
                colCURRENCY_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            }
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            //gridView1.ExpandAllGroups();
        }
    }
}
