using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.HumMebBarcode;
using BPack.Pocket.App.MM.HumMebBarcode;
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

namespace BPack.Carrying.App.MM.HumMebBarcode
{
    public partial class HumMebBarcodeList : StrapSubForm_OnlyOneGrid_V2
    {
        private HumMebBarcodeArgs _humMebBarcodeArgs;
        private HumMebBarcodePocket _humMebBarcodePocket;

        public HumMebBarcodeList()
        {
            InitializeComponent();
        }

        public HumMebBarcodeList(HumMebBarcodeArgs humMebBarcodeArgs, HumMebBarcodePocket humMebBarcodePocket):this()
        {
            this._humMebBarcodeArgs = humMebBarcodeArgs;
            this._humMebBarcodePocket = humMebBarcodePocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = humMebBarcodeModelBindingSource,
                FormArgs = _humMebBarcodeArgs,
                ModelArgs = _humMebBarcodeArgs.HumMebBarcodeModelArgs,
                InitModelType = typeof(HumMebBarcodeModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<HumMebBarcodeModelArgs, HumMebBarcodeModel>(_humMebBarcodePocket.SelectHumMebBarcodeModels,null,null);

            LookUpEditHelper.SetGridColumnSysCode(colHU_MEB_TYPE, "BARCODE_TYPE");
        }
        public List<string> SaveNewMebLot(NewHumMebBarcodeArgs args)
        {
            try
            {
               return _humMebBarcodePocket.SaveHumMebBarcodeModel(args);
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
                return null;
            }

        }
    }
}
