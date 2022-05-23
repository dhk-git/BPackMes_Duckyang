using BPack.Common.Pocket;
using BPack.Model.App.MD.OrgPlant;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgPlant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.OrgPlant
{
    public partial class OrgPlantMain : StrapMainForm
    {
        private OrgPlantArgs _orgPlantArgs;
        private OrgPlantPocket _orgPlantPocket;
        private OrgPlantList _orgPlantList;
        private OrgCompList _orgCompList;

        private OrgPlantWktmList _orgPlantWktmList;

        public OrgPlantMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _orgPlantArgs = new OrgPlantArgs();
            _orgPlantPocket = new OrgPlantPocket();
            _orgCompList = new OrgCompList(_orgPlantArgs, _orgPlantPocket);
            _orgPlantList = new OrgPlantList(_orgPlantArgs, _orgPlantPocket);
            _orgPlantWktmList = new OrgPlantWktmList(_orgPlantArgs, _orgPlantPocket);

            _orgCompList.ModelSelectedEvent += ParentCode_SelectedEvent;
            _orgPlantList.ModelSelectedEvent += PlantCode_SelectedEvent;

            this.SelectedSubFormChanged += OrgPlantMain_SelectedSubFormChanged;
            AddSubForm(this, _orgCompList, layoutControlGroup2);
            AddSubForm(this, _orgPlantList, layoutControlGroup3);
            AddSubForm(this, _orgPlantWktmList, layoutControlGroup5);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _orgPlantArgs,
                InitlistForm = _orgCompList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);
        }



        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void OrgPlantMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _orgCompList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: false);
            }
            if (this.SelectedSubForm == _orgPlantList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: false);
            }
            if (this.SelectedSubForm == _orgPlantWktmList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save: true);
            }
        }

        private void ParentCode_SelectedEvent(object sender, ArgsBase e)
        {
            _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code = ((CompModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _orgPlantArgs.OrgPlantModelArgs.Select_Main_Plant_Code = strapTextEdit1.EditValue?.ToString();
            _orgPlantArgs.OrgPlantModelArgs.Select_Main_Plant_Name = strapTextEdit2.EditValue?.ToString();
            _orgPlantList.DataRefresh(_orgPlantArgs);
        }
        private void PlantCode_SelectedEvent(object sender, ArgsBase e)
        {
            _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code = ((PlantModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _orgPlantArgs.OrgPlantModelArgs.Select_Plant_Code = ((PlantModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;

            _orgPlantWktmList.DataRefresh(_orgPlantArgs);
        }

    }
}
