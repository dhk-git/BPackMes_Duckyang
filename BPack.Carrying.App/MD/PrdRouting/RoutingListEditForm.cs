using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Strap.FormControls;
using BPack.Model.App.MD.PrdRouting;
using BPack.Pocket.App.MD.PrdRouting;
using BPack.Strap.EditControls;

namespace BPack.Carrying.App.MD.PrdRouting
{
    public partial class RoutingListEditForm : StrapEditForm 
    {
        private PrdRoutingArgs _prdRoutingArgs;
        private PrdRoutingPocket _prdRoutingPocket;
        private RoutingModel _routingModel;

        public RoutingListEditForm(PrdRoutingArgs prdRoutingArgs, PrdRoutingPocket prdRoutingPocket)
        {
            InitializeComponent();

            _prdRoutingArgs = prdRoutingArgs;
            _prdRoutingPocket = prdRoutingPocket;

            InitBoundFieldName<RoutingModel>(strapDataLayout1);

            itemMasterButtonEdit1.InitStrap();
        }

        public void DataRefresh(object datasource)
        {
            _routingModel = (RoutingModel)datasource;
            routingModelBindingSource.DataSource = _routingModel;

            itemMasterButtonEdit1.InitCompCode(_prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code);
            itemMasterButtonEdit1.InitPlantCode(_prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code);
        }
    }
}
