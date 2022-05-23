using BPack.Common.Config;
using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.IqcInsp;
using BPack.Pocket.App.QC.IqcInsp;
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

namespace BPack.Carrying.App.QC.IqcInsp
{
    public partial class IqcInspList : StrapSubForm_OnlyOneGrid_V2
    {
        IqcInspArgs _movLocArgs;
        IqcInspPocket _movLocPocket;

        public IqcInspList()
        {
            InitializeComponent();
        }
        public IqcInspList(IqcInspArgs movLocArgs, IqcInspPocket movLocPocket) : this()
        {
            _movLocArgs = movLocArgs;
            _movLocPocket = movLocPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = IqcInspModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _movLocArgs,
                GridView = gridView1,
                InitModelType = typeof(IqcInspModel),
                ModelArgs = _movLocArgs.IqcInspModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<IqcInspModelArgs, IqcInspModel>(_movLocPocket.SelectHeaderModels
                , null);
            //  colIsCheck.Visible = false;

            LookUpEditHelper.SetGridColumnSysCode(colIQC_STATUS, "IQC_STATUS"); 
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }

        internal void EtcInList()
        {
           
                gridView1.PostEditor();
                gridView1.UpdateCurrentRow();
                List<IqcInspModel> checkedModels = ((List<IqcInspModel>)SelectedModels).Where(a => a.IsCheck == true).ToList();

                if (checkedModels.Count == 0)
                {
                    //선택된 행이 없습니다.
                    StrapMessageBox.Show("A001",61);
                    return;
                }

            if (checkedModels.Where(v => v.IQC_STATUS == "CLOSE").Count() > 0)
            {
                //이미 검사완료된 항목이 있습니다.
                //처리할수 없습니다.
                StrapMessageBox.Show("A001", 99);
                return;

            }
            //선택된 항목을 검사완료처리 하시겠습니까?
            if (StrapMessageBox.Show("A001", 98, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SystemConfig.RefreshServerDateTime();

                try
                {
                    _movLocPocket.SaveInOutModels(checkedModels);
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }
               
            
        }
    }
}
