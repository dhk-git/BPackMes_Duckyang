using BPack.Model.App.PO.PurOrderInp;
using BPack.Pocket.App.PO.PurOrderInp;
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

namespace BPack.Carrying.App.PO.PurOrderInp
{
    public partial class PurOrderInpMain : StrapMainForm
    {
        private PurOrderInpArgs _purOrderInpArgs;
        private PurOrderInpPocket _purOrderInpPocket;
        private PurOrderInpList _purOrderInpList;
        private PurInpDetailList _purInpDetailList;

        public PurOrderInpMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _purOrderInpArgs = new PurOrderInpArgs();
            _purOrderInpPocket = new PurOrderInpPocket();
            _purOrderInpList = new PurOrderInpList(_purOrderInpArgs, _purOrderInpPocket);
            _purInpDetailList = new PurInpDetailList(_purOrderInpArgs, _purOrderInpPocket);
            AddSubForm(this, _purOrderInpList, layoutControlGroup2);
            AddSubForm(this, _purInpDetailList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _purOrderInpArgs,
                InitlistForm = _purOrderInpList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            _purOrderInpList.ModelSelectedEvent += PurOrderInpList_ModelSelectedEvent;
        }

        private void PurOrderInpList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _purOrderInpArgs.PurOrderInpModelArgs.Select_Poh_Dt = ((PurOrderInpModel)e.SelectedModelArgsBase.SelectedModelBase).POH_DT;
            _purOrderInpArgs.PurOrderInpModelArgs.Select_Item_Cd = ((PurOrderInpModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
            _purInpDetailList.DataRefresh(_purOrderInpArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _purOrderInpArgs.PurOrderInpModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _purOrderInpArgs.PurOrderInpModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            base.Refresh_From_ExecuteByRibbonButton();
        }


    }
}
