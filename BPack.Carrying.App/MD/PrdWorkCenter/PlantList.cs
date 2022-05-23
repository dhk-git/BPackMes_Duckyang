using BPack.Model.App.MD.PrdWorkCenter;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdWorkCenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdWorkCenter
{
    public partial class PlantList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdWorkCenterArgs _prdWorkCenterArgs;
        private PrdWorkCenterPocket _prdWorkCenterPocket;

        public PlantList()
        {
            InitializeComponent();
        }

        public PlantList(PrdWorkCenterArgs prdWorkCenterArgs, PrdWorkCenterPocket prdWorkCenterPocket) : this()
        {
            _prdWorkCenterArgs = prdWorkCenterArgs;
            _prdWorkCenterPocket = prdWorkCenterPocket;

        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = plantModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _prdWorkCenterArgs,
                GridView = gridView1,
                InitModelType = typeof(PlantModel),
                ModelArgs = _prdWorkCenterArgs.PrdWorkCenterModelArgs
            });
            InitPocketDelegate<PrdWorkCenterModelArgs, PlantModel>(_prdWorkCenterPocket.SelectPlantModels, null);
            colMODIFY_DTTM.Visible = false;
            colMODIFY_USER_ID.Visible = false;

            IsBestFitStrapGrid = false;
            //gridView1.OptionsView.ColumnAutoWidth = true;
        }
    }
}
