using BPack.Model.App.PC.WoeRsPivot;
using BPack.Pocket.App.PC.WoeRsPivot;
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

namespace BPack.Carrying.App.PC.WoeRsPivot
{
    public partial class RsPivotList : StrapSubForm_Pivot
    {
        private WoeRsPivotArgs _woeRsPivotArgs;
        private WoeRsPivotPocket _woeRsPivotPocket;

        string trLang;
        private RsPivotList()
        {
            InitializeComponent();
        }
        public RsPivotList(WoeRsPivotArgs woeRsPivotArgs, WoeRsPivotPocket woeRsPivotPocket) : this()
        {
            _woeRsPivotArgs = woeRsPivotArgs;
            _woeRsPivotPocket = woeRsPivotPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();

            InitField(new FieldArgs_StrapSubForm_Pivot()
            {
                BindingSource = rsPivotModelBindingSource,
                FormArgs = _woeRsPivotArgs,
                InitModelType = typeof(RsPivotModel),
                ModelArgs = _woeRsPivotArgs.WoeRsPivotModelArgs,
                PivotGridControl = strapPivotControl1
            });
            InitZipperDelegate<WoeRsPivotModelArgs, RsPivotModel>(_woeRsPivotPocket.SelectRsPivotModels, null);

            //2022.03.17 정수교 언어변환 
            foreach (DevExpress.XtraPivotGrid.PivotGridField item in strapPivotControl1.Fields)
            {
                trLang = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, item.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Caption = trLang;
                }
            }
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            strapPivotControl1.BestFit();
        }
    }
}
