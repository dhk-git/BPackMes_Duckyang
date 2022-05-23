using BPack.Model.App.PC.NwtStatusInfo;
using BPack.Pocket.App.PC.NwtStatusInfo;
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

namespace BPack.Carrying.App.PC.NwtStatusInfo
{
    public partial class NwtStatusInfoDayList : StrapSubForm_OnlyOneGrid_V2
    {
        private NwtStatusInfoArgs _nwtStatusInfoArgs;
        private NwtStatusInfoPocket _nwtStatusInfoPocket;
        

        public NwtStatusInfoDayList(NwtStatusInfoArgs nwtStatusInfoArgs, NwtStatusInfoPocket nwtStatusInfoPocket)
        {
            InitializeComponent();
            _nwtStatusInfoArgs = nwtStatusInfoArgs;
            _nwtStatusInfoPocket = nwtStatusInfoPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = true;
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                
                BindingSource = nwtStatusInfoModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _nwtStatusInfoArgs,
                GridView = gridView1,
                InitModelType = typeof(NwtStatusInfoModel),
                ModelArgs = _nwtStatusInfoArgs.NwtStatusInfoModelArgs
                
            });
            InitPocketDelegate<NwtStatusInfoModelArgs, NwtStatusInfoModel>(_nwtStatusInfoPocket.SelectNwtStatusInfoModels, null);
            gridView1.OptionsView.ColumnAutoWidth = true;

        }

    }
}
