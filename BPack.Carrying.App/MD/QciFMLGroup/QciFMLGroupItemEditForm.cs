using BPack.Common.Pocket;
using BPack.Model.App.MD.QciFMLGroup;
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

namespace BPack.Carrying.App.MD.QciFMLGroup
{
    public partial class QciFMLGroupItemEditForm : StrapEditForm
    {
        private QciFMLGroupArgs _qciFMLGroupArgs;
        private QciFMLGroupItemModel _qciFMLGroupItemModel;

        public QciFMLGroupItemEditForm(QciFMLGroupArgs qciFMLGroupArgs)
        {
            InitializeComponent();

            _qciFMLGroupArgs = qciFMLGroupArgs;

            InitBoundFieldName<QciFMLGroupItemModel>(strapDataLayout1);

            ITEM_CDButtonEdit.InitStrap();
            ITEM_CDButtonEdit.SelectedComplate += StrapButtonEdit_ItemMaster1_SelectedComplate;
        }
        private void StrapButtonEdit_ItemMaster1_SelectedComplate(object sender, CommonMes.Controls.ItemMaster.ItemMasterSelectedEventArgs e)
        {
            _qciFMLGroupItemModel.ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
        }

        public void DataRefresh(object datasource)
        {
            _qciFMLGroupItemModel = (QciFMLGroupItemModel)datasource;
            qciFMLGroupItemModelBindingSource.DataSource = _qciFMLGroupItemModel;

            ITEM_CDButtonEdit.InitCompCode(_qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Comp_CD);
            ITEM_CDButtonEdit.InitPlantCode(_qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Plant_CD);
        }

        private void ITEM_CDButtonEdit_EditValueChanged(object sender, EventArgs e)
        {
            var sp = SimplePocket.GetInstance();
            var row = sp.SelectData("ItemInfo", new { 
                COMP_CD = _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Comp_CD,
                PLANT_CD = _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Plant_CD,
                ITEM_CD = ITEM_CDButtonEdit.EditValue.ToString()
            }).Select().FirstOrDefault();

            if (row != null)
            {
                _qciFMLGroupItemModel.ITEM_NM = row["ITEM_NM"].ToString();
                _qciFMLGroupItemModel.ALC_CD = row["ALC_CD"].ToString();
            }
            ITEM_CDButtonEdit.DataBindings[0]?.WriteValue();
        }
    }
}
