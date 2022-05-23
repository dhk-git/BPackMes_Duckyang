using BPack.Model.App.SD.DlvHist;
using BPack.Pocket.App.SD.DlvHist;
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

namespace BPack.Carrying.App.SD.DlvHist
{
    public partial class DlvHistDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvHistArgs _dlvHistArgs;
        private DlvHistPocket _dlvHistPocket;

        public DlvHistDetailList()
        {
            InitializeComponent();
        }

        public DlvHistDetailList(DlvHistArgs dlvHistArgs, DlvHistPocket dlvHistPocket) : this()
        {
            this._dlvHistArgs = dlvHistArgs;
            this._dlvHistPocket = dlvHistPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvHistDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvHistArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvHistDetailModel),
                ModelArgs = _dlvHistArgs.DlvHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvHistModelArgs, DlvHistDetailModel>(_dlvHistPocket.SelectDlvHistDetailModels, null, null);
        }
        public override void DataRefresh(ArgsBase args)
        {
            if (_dlvHistArgs.DlvHistModelArgs.Select_Dlv_Type == "JIS")
            {
                colPROD_DT.Visible = true;
                colHU_INIT_QTY.Visible = false;
                colBODY_NO.Visible = true;
                colPBS_SEQ.Visible = true;
                colDO_QTY.Visible = true;
                colDR_QTY.Visible = true;
                colCREATE_DTTM.Visible = true;
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                {
                    if (col.Visible == true)
                    {
                        col.VisibleIndex = col.AbsoluteIndex;
                    }
                }
            }
            else
            {
                colPROD_DT.Visible = false;
                colHU_INIT_QTY.Visible = true;
                colBODY_NO.Visible = false;
                colPBS_SEQ.Visible = false;
                colDO_QTY.Visible = false;
                colDR_QTY.Visible = false;
                colCREATE_DTTM.Visible = false;
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                {
                    if (col.Visible == true)
                    {
                        col.VisibleIndex = col.AbsoluteIndex;
                    }
                }
            }
            base.DataRefresh(args);
        }
    }
}
