namespace NetOffice.DeveloperToolbox.ToolboxControls
{
    partial class ControlContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlContainer));
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelToolboxControl = new System.Windows.Forms.Panel();
            this.pictureBoxInformation = new System.Windows.Forms.PictureBox();
            this.labelInfoMessage = new System.Windows.Forms.Label();
            this.pictureBoxWarning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.Location = new System.Drawing.Point(1774, 19);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(56, 54);
            this.buttonInfo.TabIndex = 28;
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Visible = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panelToolboxControl
            // 
            this.panelToolboxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToolboxControl.Location = new System.Drawing.Point(0, 102);
            this.panelToolboxControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolboxControl.Name = "panelToolboxControl";
            this.panelToolboxControl.Size = new System.Drawing.Size(1864, 900);
            this.panelToolboxControl.TabIndex = 29;
            // 
            // pictureBoxInformation
            // 
            this.pictureBoxInformation.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBoxInformation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInformation.Image")));
            this.pictureBoxInformation.Location = new System.Drawing.Point(56, 38);
            this.pictureBoxInformation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxInformation.Name = "pictureBoxInformation";
            this.pictureBoxInformation.Size = new System.Drawing.Size(36, 31);
            this.pictureBoxInformation.TabIndex = 76;
            this.pictureBoxInformation.TabStop = false;
            this.pictureBoxInformation.Visible = false;
            // 
            // labelInfoMessage
            // 
            this.labelInfoMessage.AutoSize = true;
            this.labelInfoMessage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelInfoMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelInfoMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoMessage.ForeColor = System.Drawing.Color.Gray;
            this.labelInfoMessage.Location = new System.Drawing.Point(104, 37);
            this.labelInfoMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInfoMessage.Name = "labelInfoMessage";
            this.labelInfoMessage.Size = new System.Drawing.Size(228, 36);
            this.labelInfoMessage.TabIndex = 75;
            this.labelInfoMessage.Text = "labelInfoMessage";
            this.labelInfoMessage.Visible = false;
            // 
            // pictureBoxWarning
            // 
            this.pictureBoxWarning.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBoxWarning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWarning.Image")));
            this.pictureBoxWarning.Location = new System.Drawing.Point(56, 38);
            this.pictureBoxWarning.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxWarning.Name = "pictureBoxWarning";
            this.pictureBoxWarning.Size = new System.Drawing.Size(36, 31);
            this.pictureBoxWarning.TabIndex = 83;
            this.pictureBoxWarning.TabStop = false;
            this.pictureBoxWarning.Visible = false;
            // 
            // ControlContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.pictureBoxWarning);
            this.Controls.Add(this.pictureBoxInformation);
            this.Controls.Add(this.labelInfoMessage);
            this.Controls.Add(this.panelToolboxControl);
            this.Controls.Add(this.buttonInfo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ControlContainer";
            this.Size = new System.Drawing.Size(1864, 1006);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panelToolboxControl;
        private System.Windows.Forms.PictureBox pictureBoxInformation;
        private System.Windows.Forms.Label labelInfoMessage;
        private System.Windows.Forms.PictureBox pictureBoxWarning;
    }
}
