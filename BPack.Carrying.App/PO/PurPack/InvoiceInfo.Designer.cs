
namespace BPack.Carrying.App.PO.PurPack
{
    partial class InvoiceInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lupBpCd = new BPack.Strap.EditControls.StrapLookUpEdit();
            this.dteInvoiceDT = new BPack.Strap.EditControls.StrapDateEdit();
            this.dteEtaDt = new BPack.Strap.EditControls.StrapDateEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lupBpCd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteInvoiceDT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteInvoiceDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEtaDt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEtaDt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lupBpCd
            // 
            this.lupBpCd.Location = new System.Drawing.Point(155, 21);
            this.lupBpCd.Name = "lupBpCd";
            this.lupBpCd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupBpCd.Size = new System.Drawing.Size(188, 20);
            this.lupBpCd.TabIndex = 0;
            // 
            // dteInvoiceDT
            // 
            this.dteInvoiceDT.EditValue = null;
            this.dteInvoiceDT.Location = new System.Drawing.Point(155, 60);
            this.dteInvoiceDT.Name = "dteInvoiceDT";
            this.dteInvoiceDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteInvoiceDT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteInvoiceDT.Size = new System.Drawing.Size(188, 20);
            this.dteInvoiceDT.TabIndex = 1;
            this.dteInvoiceDT.EditValueChanged += new System.EventHandler(this.dteInvoiceDT_EditValueChanged);
            // 
            // dteEtaNo
            // 
            this.dteEtaDt.EditValue = null;
            this.dteEtaDt.Location = new System.Drawing.Point(155, 103);
            this.dteEtaDt.Name = "dteEtaNo";
            this.dteEtaDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEtaDt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEtaDt.Size = new System.Drawing.Size(188, 20);
            this.dteEtaDt.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(35, 149);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(142, 46);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "거래처";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "선적일";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "도착예정일";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(183, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InvoiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(363, 229);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dteEtaDt);
            this.Controls.Add(this.dteInvoiceDT);
            this.Controls.Add(this.lupBpCd);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceInfo";
            this.Text = "InvoiceInfo";
            ((System.ComponentModel.ISupportInitialize)(this.lupBpCd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteInvoiceDT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteInvoiceDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEtaDt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEtaDt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Strap.EditControls.StrapLookUpEdit lupBpCd;
        private Strap.EditControls.StrapDateEdit dteInvoiceDT;
        private Strap.EditControls.StrapDateEdit dteEtaDt;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}