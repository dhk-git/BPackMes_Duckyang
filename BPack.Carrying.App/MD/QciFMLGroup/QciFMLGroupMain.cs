using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciFMLGroup;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.QciFMLGroup;
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
    public partial class QciFMLGroupMain : StrapMainForm
    {
        private QciFMLGroupArgs _qciFMLGroupArgs;
        private QciFMLGroupPocket _qciFMLGroupPocket;
        private QciFMLGroupList _qciFMLGroupList;
        private QciFMLGroupItemList _qciFMLGroupItemList;

        public QciFMLGroupMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _qciFMLGroupArgs = new QciFMLGroupArgs();
            _qciFMLGroupPocket = new QciFMLGroupPocket();
            _qciFMLGroupList = new QciFMLGroupList(_qciFMLGroupArgs, _qciFMLGroupPocket);
            _qciFMLGroupItemList = new QciFMLGroupItemList(_qciFMLGroupArgs, _qciFMLGroupPocket);

            AddSubForm(this, _qciFMLGroupList, layoutControlGroup2);
            AddSubForm(this, _qciFMLGroupItemList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _qciFMLGroupArgs,
                InitlistForm = _qciFMLGroupList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);

                _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();

                _qciFMLGroupList.DataRefresh(_qciFMLGroupArgs);
                _qciFMLGroupItemList.DataRefresh(_qciFMLGroupArgs);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();

                _qciFMLGroupList.DataRefresh(_qciFMLGroupArgs);
                _qciFMLGroupItemList.DataRefresh(_qciFMLGroupArgs);
            };

            _qciFMLGroupList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Type_Fml_GR = ((QciFMLGroupModel)e.SelectedModelArgsBase.SelectedModelBase).FML_GR;

                _qciFMLGroupItemList.DataRefresh(_qciFMLGroupArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _qciFMLGroupList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
                if (this.SelectedSubForm == _qciFMLGroupItemList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _qciFMLGroupArgs.QciFMLGroupModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }


    }
}
