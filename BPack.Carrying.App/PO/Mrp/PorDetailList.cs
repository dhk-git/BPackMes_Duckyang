using BPack.Common.Model;
using BPack.Model.App.PO.Mrp;
using BPack.Pocket.App.PO.Mrp;
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

namespace BPack.Carrying.App.PO.Mrp
{
    public partial class PorDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private MrpArgs _mrpArgs;
        private MrpPocket _mrpPocket;

        public PorDetailList()
        {
            InitializeComponent();
        }

        public PorDetailList(MrpArgs mrpArgs, MrpPocket mrpPocket) : this()
        {
            this._mrpArgs = mrpArgs;
            this._mrpPocket = mrpPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _mrpArgs,
                GridView = gridView1,
                InitModelType = typeof(PorDetailModel),
                ModelArgs = _mrpArgs.MrpModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<MrpModelArgs, PorDetailModel>(_mrpPocket.SelectPorDetailModels, null,_mrpPocket.SavePorDetailModels);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }

        public void AddPorData(List<PorDetailModel> porDetailModels)
        {
            //this.SelectedModels = porDetailModels;
            //foreach (var model in porDetailModels)
            //{
            //    ((List<PorDetailModel>)this.SelectedModels).Add(model);
            //}
            try
            {
                _mrpPocket.SavePorDetailModels(porDetailModels);
                this.DataRefresh(_mrpArgs);
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
            
            //bindingSource1.ResetBindings(false);
            //gridView1.BestFitColumns();
        }

    }
}
