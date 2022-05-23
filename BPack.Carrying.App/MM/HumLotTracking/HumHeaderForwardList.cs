using BPack.Model.App.MM.HumLotTracking;
using BPack.Pocket.App.MM.HumLotTracking;
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

namespace BPack.Carrying.App.MM.HumLotTracking
{
    public partial class HumHeaderForwardList : StrapSubForm_OnlyOneGrid_V2
    {
        private HumLotTrackingArgs _humLotTrackingArgs;
        private HumLotTrackingPocket _humLotTrackingPocket;

        public HumHeaderForwardList()
        {
            InitializeComponent();
        }

        public HumHeaderForwardList(HumLotTrackingArgs humLotTrackingArgs, HumLotTrackingPocket humLotTrackingPocket) : this()
        {
            this._humLotTrackingArgs = humLotTrackingArgs;
            this._humLotTrackingPocket = humLotTrackingPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = humHeaderForwardModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _humLotTrackingArgs,
                GridView = gridView1,
                InitModelType = typeof(HumHeaderForwardModel),
                ModelArgs = _humLotTrackingArgs.HumLotTrackingModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<HumLotTrackingModelArgs, HumHeaderForwardModel>(_humLotTrackingPocket.SelectHumHeaderForwardModels, null, null);
         
        }

        internal void SetCheckedSemi(CheckState checkState)
        {
            if (checkState == CheckState.Checked)
            {
                colPRCP_NO.Visible = false;
                colIN_DTTM.Visible = false;
                colDO_NO.Visible = false;
            }
            else
            {
                colPRCP_NO.Visible = true;
                colIN_DTTM.Visible = true;
                colDO_NO.Visible = true;
            }
        }
    }
}
