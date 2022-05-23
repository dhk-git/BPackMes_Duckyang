using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvJisInfo;
using BPack.Strap.FormControls;
using BPack.Strap.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvJisInfo
{
    public partial class JISListEditForm : StrapEditForm
    {
        private DlvJisInfoArgs _dlvJisInfoArgs;
        private DlvJisInfoJISModel _dlvJisInfoJISModel;

        public JISListEditForm(DlvJisInfoArgs dlvJisInfoArgs)
        {
            InitializeComponent();

            _dlvJisInfoArgs = dlvJisInfoArgs;

            InitBoundFieldName<DlvJisInfoJISModel>(strapDataLayout1);

            LookUpEditHelper.SetSysCode(PRINT_WAYLookUpEdit, "PRINT_WAY", total: false);

        }

        public void DataRefresh(object datasource)
        {
            _dlvJisInfoJISModel = (DlvJisInfoJISModel)datasource;
            dlvJisInfoJISModelBindingSource.DataSource = _dlvJisInfoJISModel;

            LookUpEditHelper.SetByQuery(ALC_TYPELookUpEdit, "ItemGroup",
                 new
                 {
                     COMP_CD = _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Main_Comp_CD,
                     PLANT_CD = _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Main_Plant_CD,
                     ITEM_GR_CLS = "ITEM_GR_3"
                 }, "서열유형", "서열유형명");
            ALC_TYPELookUpEdit.Properties.DisplayMember = "CODE";
        }

        private void ALC_TYPELookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var row = ALC_TYPELookUpEdit.GetSelectedDataRow() as BPack.Strap.EditControls.LookUpEditDefaultModel;
            if (row != null)
            {
                _dlvJisInfoJISModel.ALC_TYPE_NM = row.NAME;
                ALC_TYPELookUpEdit.DataBindings[0]?.WriteValue();
            }
        }
    }
}
