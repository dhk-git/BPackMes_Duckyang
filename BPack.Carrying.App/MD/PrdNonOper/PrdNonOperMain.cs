using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdNonOper;
using BPack.Pocket.App.MD.PrdNonOper;
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

namespace BPack.Carrying.App.MD.PrdNonOper
{
    public partial class PrdNonOperMain : StrapMainForm
    {
        private PrdNonOperArgs _prdNonOperArgs;
        private PrdNonOperPocket _prdNonOperPocket;

        private NonOperGroup _nonOperGroup;
        private NonOperList _nonOperList;
        public PrdNonOperMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _prdNonOperArgs = new PrdNonOperArgs();
            _prdNonOperPocket = new PrdNonOperPocket();
            _nonOperGroup = new NonOperGroup(_prdNonOperArgs, _prdNonOperPocket);
          
            _nonOperList = new NonOperList(_prdNonOperArgs, _prdNonOperPocket);

            AddSubForm(this, _nonOperGroup, layoutControlGroup2);
            AddSubForm(this, _nonOperList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdNonOperArgs,
                InitlistForm = _nonOperGroup,
                StrapLayout = strapLayout1
            });

            InitRibbonButtons(refresh: true, add: true, delete: true, save: true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();

            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _nonOperGroup) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: true, delete: true, save: true); }
            };

            //좌측 변경시 우측 이벤트 발생
            _nonOperGroup.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                
                _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Comp_Code = ((NonOperGroupModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD_KEY;
                _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Plant_Code = ((NonOperGroupModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD_KEY;
                _prdNonOperArgs.PrdNonOperModelArgs.NOTWORK_GROUP_CD = ((NonOperGroupModel)e.SelectedModelArgsBase.SelectedModelBase).NOTWORK_GROUP_CD_KEY;
                _nonOperList.DataRefresh(_prdNonOperArgs);

            };

            //좌측 데이터 갱신시 우측 데이터 갱신
            _nonOperGroup.DataCRUD_Refersh += (object sender, EventArgs e) =>
            {
                _nonOperList.DataRefresh(_prdNonOperArgs);
            };
            



        }

        private void _nonOperGroup_Refersh(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdNonOperArgs.PrdNonOperModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}
