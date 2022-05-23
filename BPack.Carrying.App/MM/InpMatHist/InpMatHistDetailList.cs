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
    public partial class InpMatHistDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private InpMatHistArgs _inpMatHistArgs;
        private InpMatHistPocket _inpMatHistPocket;

        public InpMatHistDetailList()
        {
            InitializeComponent();
        }

        public InpMatHistDetailList(InpMatHistArgs inpMatHistArgs, InpMatHistPocket inpMatHistPocket) : this()
        {
            this._inpMatHistArgs = inpMatHistArgs;
            this._inpMatHistPocket = inpMatHistPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = inpMatHistDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _inpMatHistArgs,
                GridView = gridView1,
                InitModelType = typeof(InpMatHistDetailModel),
                ModelArgs = _inpMatHistArgs.InpMatHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InpMatHistModelArgs, InpMatHistDetailModel>(_inpMatHistPocket.SelectInpMatHistDetailModels, null, null);
            //colCREATE_DTTM.Caption = "입고일시";
            colMODIFY_DTTM.Visible = false;
            colMODIFY_USER_ID.Visible = false;
            colCREATE_DTTM.Visible = false;
            colCREATE_USER_ID.Visible = true;
            if (!this.AuthModel.DUMMY1_AUTH)
            {
                colPRICE.Visible = false;
                colPRICE.OptionsColumn.ShowInCustomizationForm = false;
                colAMOUNT.Visible = false;
                colAMOUNT.OptionsColumn.ShowInCustomizationForm = false;
                colCURRENCY_TYPE.Visible = false;
                colCURRENCY_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            }
        }
    }
}
