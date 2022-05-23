
namespace BPack.Carrying.App.SD.DlvConfirm2
{
    partial class CancelPopup
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
            this.lueWarehouse = new BPack.Strap.EditControls.StrapLookUpEdit();
            this.lueLoc = new BPack.Strap.EditControls.StrapLookUpEdit();
            this.txtReason = new BPack.Strap.EditControls.StrapTextEdit();
            this.lblWarehouse = new DevExpress.XtraEditors.LabelControl();
            this.lblLoc = new DevExpress.XtraEditors.LabelControl();
            this.lblReason = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lueWarehouse
            // 
            this.lueWarehouse.Location = new System.Drawing.Point(87, 64);
            this.lueWarehouse.Name = "lueWarehouse";
            this.lueWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueWarehouse.Size = new System.Drawing.Size(166, 20);
            this.lueWarehouse.TabIndex = 0;
            // 
            // lueLoc
            // 
            this.lueLoc.Location = new System.Drawing.Point(87, 107);
            this.lueLoc.Name = "lueLoc";
            this.lueLoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoc.Size = new System.Drawing.Size(166, 20);
            this.lueLoc.TabIndex = 1;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(87, 153);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(258, 20);
            this.txtReason.TabIndex = 2;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.Location = new System.Drawing.Point(13, 68);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(20, 14);
            this.lblWarehouse.TabIndex = 3;
            this.lblWarehouse.Text = "창고";
            // 
            // lblLoc
            // 
            this.lblLoc.Location = new System.Drawing.Point(13, 111);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(20, 14);
            this.lblLoc.TabIndex = 4;
            this.lblLoc.Text = "위치";
            // 
            // lblReason
            // 
            this.lblReason.Location = new System.Drawing.Point(13, 156);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(40, 14);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "취소사유";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(13, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 14);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "labelControl4";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 199);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 56);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(229, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 56);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            // 
            // CancelPopup
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(375, 287);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lueLoc);
            this.Controls.Add(this.lueWarehouse);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelPopup";
            this.Text = "Cancel delivary";
            ((System.ComponentModel.ISupportInitialize)(this.lueWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Strap.EditControls.StrapLookUpEdit lueWarehouse;
        private Strap.EditControls.StrapLookUpEdit lueLoc;
        private Strap.EditControls.StrapTextEdit txtReason;
        private DevExpress.XtraEditors.LabelControl lblWarehouse;
        private DevExpress.XtraEditors.LabelControl lblLoc;
        private DevExpress.XtraEditors.LabelControl lblReason;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}