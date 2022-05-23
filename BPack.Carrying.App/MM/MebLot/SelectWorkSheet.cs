using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.MebLot
{
    public partial class SelectWorkSheet : XtraForm
    {
        private SelectWorkSheet()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public SelectWorkSheet(string[] workSheetNames) : this()
        {
            listBoxControl1.DataSource = workSheetNames;

        }

        public string SelectedWorkSheetName { get; set; }

        private void listBoxControl1_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedWorkSheetName = listBoxControl1.SelectedValue.ToString();
        }
        //ok 버튼
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
