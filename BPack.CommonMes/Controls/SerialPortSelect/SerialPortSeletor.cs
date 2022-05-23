using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Strap.MasterDataControls.MD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.CommonMes.Controls.SerialPortSelect
{
    public partial class SerialPortSeletor : DevExpress.XtraEditors.XtraForm
    {
        private SerialPortSelectedEventArgs _serialPortSelectedEventArgs;
        public event EventHandler<SerialPortSelectedEventArgs> SelectedComplate;

        public SerialPortSeletor()
        {
            InitializeComponent();

            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            _serialPortSelectedEventArgs = new SerialPortSelectedEventArgs();

            lookUpEdit1.Properties.DataSource = SerialPort.GetPortNames();
            lookUpEdit2.Properties.DataSource = Enum.GetValues(typeof(StopBits));
            lookUpEdit3.Properties.DataSource = Enum.GetValues(typeof(Parity));

        }

        private void SerialPortSeletor_Load(object sender, EventArgs e)
        {
            lookUpEdit1.EditValue = SerialPort.GetPortNames().FirstOrDefault();
            textEdit1.EditValue = 9600;
            textEdit2.EditValue = 8;
            lookUpEdit2.EditValue = StopBits.One;
            lookUpEdit3.EditValue = Parity.None;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //base.OnClosing(e);
            e.Cancel = true;
            this.Hide();
        }

        //ESC로 닫히도록
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void SelectComplate()
        {
            this.Hide();
        }


        private void ItemMasterSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                //DataRefresh();
            }
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                SelectComplate();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SerialPortSelctorModel serialPortSelctorModel = new SerialPortSelctorModel();

            var baudRate = Convert.ToInt32(textEdit1.EditValue?.ToString());
            var dataBits = Convert.ToInt32(textEdit2.EditValue?.ToString());

            var valStopBits = lookUpEdit2.EditValue?.ToString() ?? (lookUpEdit2.Properties.DataSource as System.IO.Ports.StopBits[])[0].ToString();
            var valParity = lookUpEdit3.EditValue?.ToString() ?? (lookUpEdit3.Properties.DataSource as System.IO.Ports.Parity[])[0].ToString();
            var stopBits = (StopBits)Enum.Parse(typeof(StopBits), valStopBits);
            var parity = (Parity)Enum.Parse(typeof(Parity), valParity);

            serialPortSelctorModel.ComPort = lookUpEdit1.EditValue?.ToString();
            serialPortSelctorModel.BaudRate = baudRate;
            serialPortSelctorModel.DataBits = dataBits;
            serialPortSelctorModel.StopBits = stopBits;
            serialPortSelctorModel.Parity = parity;

            _serialPortSelectedEventArgs.serialPortSelctorModel = serialPortSelctorModel;
            SelectedComplate?.Invoke(this, _serialPortSelectedEventArgs);
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
