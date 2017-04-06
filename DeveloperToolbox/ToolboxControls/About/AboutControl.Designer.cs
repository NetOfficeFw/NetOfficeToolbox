namespace NetOffice.DeveloperToolbox.ToolboxControls.About
{
    partial class AboutControl
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutControl));
            this.panelAboutDetails = new System.Windows.Forms.Panel();
            this.labelLicense = new System.Windows.Forms.Label();
            this.linkLabelLicenceLink = new System.Windows.Forms.LinkLabel();
            this.labelVersionText = new System.Windows.Forms.Label();
            this.labelTechnicalDetails = new System.Windows.Forms.Label();
            this.pictureBoxInfo4 = new System.Windows.Forms.PictureBox();
            this.panelAboutWarranty = new System.Windows.Forms.Panel();
            this.labelAboutWarranty = new System.Windows.Forms.Label();
            this.pictureBoxInfo3 = new System.Windows.Forms.PictureBox();
            this.panelAboutTop = new System.Windows.Forms.Panel();
            this.pictureBoxInfo1 = new System.Windows.Forms.PictureBox();
            this.labelAboutNetOffice = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAboutDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo4)).BeginInit();
            this.panelAboutWarranty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo3)).BeginInit();
            this.panelAboutTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAboutDetails
            // 
            this.panelAboutDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAboutDetails.Controls.Add(this.flowLayoutPanel2);
            this.panelAboutDetails.Controls.Add(this.labelTechnicalDetails);
            this.panelAboutDetails.Controls.Add(this.pictureBoxInfo4);
            this.panelAboutDetails.Location = new System.Drawing.Point(9, 228);
            this.panelAboutDetails.Name = "panelAboutDetails";
            this.panelAboutDetails.Size = new System.Drawing.Size(1012, 283);
            this.panelAboutDetails.TabIndex = 91;
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicense.ForeColor = System.Drawing.Color.Black;
            this.labelLicense.Location = new System.Drawing.Point(3, 36);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(726, 36);
            this.labelLicense.TabIndex = 95;
            this.labelLicense.Text = "The developer toolbox is licensed under the MIT License (MIT)";
            // 
            // linkLabelLicenceLink
            // 
            this.linkLabelLicenceLink.AutoSize = true;
            this.linkLabelLicenceLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLicenceLink.Location = new System.Drawing.Point(3, 72);
            this.linkLabelLicenceLink.Name = "linkLabelLicenceLink";
            this.linkLabelLicenceLink.Size = new System.Drawing.Size(417, 30);
            this.linkLabelLicenceLink.TabIndex = 94;
            this.linkLabelLicenceLink.TabStop = true;
            this.linkLabelLicenceLink.Text = "https://opensource.org/licenses/MIT";
            this.linkLabelLicenceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCompany_LinkClicked);
            // 
            // labelVersionText
            // 
            this.labelVersionText.AutoSize = true;
            this.labelVersionText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersionText.ForeColor = System.Drawing.Color.Black;
            this.labelVersionText.Location = new System.Drawing.Point(3, 0);
            this.labelVersionText.Name = "labelVersionText";
            this.labelVersionText.Size = new System.Drawing.Size(199, 36);
            this.labelVersionText.TabIndex = 90;
            this.labelVersionText.Text = "labelVersionText";
            // 
            // labelTechnicalDetails
            // 
            this.labelTechnicalDetails.AutoSize = true;
            this.labelTechnicalDetails.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTechnicalDetails.ForeColor = System.Drawing.Color.White;
            this.labelTechnicalDetails.Location = new System.Drawing.Point(28, 1);
            this.labelTechnicalDetails.Name = "labelTechnicalDetails";
            this.labelTechnicalDetails.Size = new System.Drawing.Size(267, 45);
            this.labelTechnicalDetails.TabIndex = 83;
            this.labelTechnicalDetails.Text = "Technical Details";
            // 
            // pictureBoxInfo4
            // 
            this.pictureBoxInfo4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo4.Image")));
            this.pictureBoxInfo4.Location = new System.Drawing.Point(1, 4);
            this.pictureBoxInfo4.Name = "pictureBoxInfo4";
            this.pictureBoxInfo4.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxInfo4.TabIndex = 80;
            this.pictureBoxInfo4.TabStop = false;
            // 
            // panelAboutWarranty
            // 
            this.panelAboutWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAboutWarranty.Controls.Add(this.labelAboutWarranty);
            this.panelAboutWarranty.Controls.Add(this.pictureBoxInfo3);
            this.panelAboutWarranty.Location = new System.Drawing.Point(3, 3);
            this.panelAboutWarranty.Name = "panelAboutWarranty";
            this.panelAboutWarranty.Size = new System.Drawing.Size(1201, 45);
            this.panelAboutWarranty.TabIndex = 90;
            // 
            // labelAboutWarranty
            // 
            this.labelAboutWarranty.AutoSize = true;
            this.labelAboutWarranty.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutWarranty.ForeColor = System.Drawing.Color.White;
            this.labelAboutWarranty.Location = new System.Drawing.Point(29, 1);
            this.labelAboutWarranty.Name = "labelAboutWarranty";
            this.labelAboutWarranty.Size = new System.Drawing.Size(226, 45);
            this.labelAboutWarranty.TabIndex = 83;
            this.labelAboutWarranty.Text = "Privacy Policy";
            // 
            // pictureBoxInfo3
            // 
            this.pictureBoxInfo3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo3.Image")));
            this.pictureBoxInfo3.Location = new System.Drawing.Point(1, 4);
            this.pictureBoxInfo3.Name = "pictureBoxInfo3";
            this.pictureBoxInfo3.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxInfo3.TabIndex = 80;
            this.pictureBoxInfo3.TabStop = false;
            // 
            // panelAboutTop
            // 
            this.panelAboutTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAboutTop.Controls.Add(this.pictureBoxInfo1);
            this.panelAboutTop.Controls.Add(this.labelAboutNetOffice);
            this.panelAboutTop.Location = new System.Drawing.Point(10, 14);
            this.panelAboutTop.Name = "panelAboutTop";
            this.panelAboutTop.Size = new System.Drawing.Size(1011, 59);
            this.panelAboutTop.TabIndex = 89;
            // 
            // pictureBoxInfo1
            // 
            this.pictureBoxInfo1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo1.Image")));
            this.pictureBoxInfo1.Location = new System.Drawing.Point(1, 4);
            this.pictureBoxInfo1.Name = "pictureBoxInfo1";
            this.pictureBoxInfo1.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxInfo1.TabIndex = 86;
            this.pictureBoxInfo1.TabStop = false;
            // 
            // labelAboutNetOffice
            // 
            this.labelAboutNetOffice.AutoSize = true;
            this.labelAboutNetOffice.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutNetOffice.ForeColor = System.Drawing.Color.White;
            this.labelAboutNetOffice.Location = new System.Drawing.Point(29, 1);
            this.labelAboutNetOffice.Name = "labelAboutNetOffice";
            this.labelAboutNetOffice.Size = new System.Drawing.Size(560, 45);
            this.labelAboutNetOffice.TabIndex = 85;
            this.labelAboutNetOffice.Text = "About NetOffice Developer Toolbox";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Controls.Add(this.panelAboutDetails);
            this.panelMain.Controls.Add(this.panelAboutTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1024, 661);
            this.panelMain.TabIndex = 93;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panelAboutWarranty);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1011, 143);
            this.flowLayoutPanel1.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(984, 60);
            this.label1.TabIndex = 91;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.labelVersionText);
            this.flowLayoutPanel2.Controls.Add(this.labelLicense);
            this.flowLayoutPanel2.Controls.Add(this.linkLabelLicenceLink);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(36, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(973, 230);
            this.flowLayoutPanel2.TabIndex = 96;
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(1024, 661);
            this.Resize += new System.EventHandler(this.AboutControl_Resize);
            this.panelAboutDetails.ResumeLayout(false);
            this.panelAboutDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo4)).EndInit();
            this.panelAboutWarranty.ResumeLayout(false);
            this.panelAboutWarranty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo3)).EndInit();
            this.panelAboutTop.ResumeLayout(false);
            this.panelAboutTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAboutDetails;
        private System.Windows.Forms.LinkLabel linkLabelLicenceLink;
        private System.Windows.Forms.Label labelVersionText;
        private System.Windows.Forms.Label labelTechnicalDetails;
        private System.Windows.Forms.PictureBox pictureBoxInfo4;
        private System.Windows.Forms.Label labelAboutWarranty;
        private System.Windows.Forms.PictureBox pictureBoxInfo3;
        private System.Windows.Forms.Panel panelAboutTop;
        private System.Windows.Forms.PictureBox pictureBoxInfo1;
        private System.Windows.Forms.Label labelAboutNetOffice;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Panel panelAboutWarranty;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
