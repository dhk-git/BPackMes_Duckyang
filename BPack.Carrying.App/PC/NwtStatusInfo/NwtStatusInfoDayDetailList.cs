using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.NwtStatusInfo;
using BPack.Pocket.App.PC.NwtStatusInfo;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class NwtStatusInfoDayDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private NwtStatusInfoArgs _nwtStatusInfoArgs;
        private NwtStatusInfoPocket _nwtStatusInfoPocket;

        public NwtStatusInfoDayDetailList(NwtStatusInfoArgs nwtStatusInfoArgs, NwtStatusInfoPocket nwtStatusInfoPocket)
        {
            InitializeComponent();
            _nwtStatusInfoArgs = nwtStatusInfoArgs;
            _nwtStatusInfoPocket = nwtStatusInfoPocket;
        }

        public override void InitStrap()
        {
            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = nwtStatusInfoListModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _nwtStatusInfoArgs,
                GridView = gridView1,
                InitModelType = typeof(NwtStatusInfoListModel),
                ModelArgs = _nwtStatusInfoArgs.NwtStatusInfoModelArgs,
                
                //수정 모드 , Default :popup , Batch :그리드 바로 수정
                StrapEditMode = StrapEditMode.Default
            });

            InitPocketDelegate<NwtStatusInfoModelArgs, NwtStatusInfoListModel>(
                _nwtStatusInfoPocket.SelectNwtStatusInfoListModels, 
                _nwtStatusInfoPocket.SaveNwtStatusModel
                );

          
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetNowk(colNOWK_CD

               , _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Comp_CD
               , _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Plant_CD
               , _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Wc_CD
               , "");

            base.DataRefresh(args);
        }

    }
}
