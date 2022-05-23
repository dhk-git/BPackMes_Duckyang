﻿using BPack.Model.App.SD.DlvConfirm2;
using BPack.Pocket.App.SD.DlvConfirm2;
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

namespace BPack.Carrying.App.SD.DlvConfirm2
{
    public partial class DlvResultDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvConfirm2Args _dlvConfirm2Args;
        private DlvConfirm2Pocket _dlvConfirm2Pocket;

        public DlvResultDetailList()
        {
            InitializeComponent();
        }

        public DlvResultDetailList(DlvConfirm2Args dlvConfirm2Args, DlvConfirm2Pocket dlvConfirm2Pocket) : this()
        {
            this._dlvConfirm2Args = dlvConfirm2Args;
            this._dlvConfirm2Pocket = dlvConfirm2Pocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvResultDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvConfirm2Args,
                GridView = gridView1,
                InitModelType = typeof(DlvResultDetailModel),
                ModelArgs = _dlvConfirm2Args.DlvConfirm2ModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvConfirm2ModelArgs, DlvResultDetailModel>(_dlvConfirm2Pocket.SelectDlvResultDetailModels, null);
        }
    }
}
