﻿namespace NetOffice.DeveloperToolbox
{
    partial class ErrorForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.labelErrorCaption = new System.Windows.Forms.Label();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelExitMessage = new System.Windows.Forms.Label();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.listViewTrace = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // pictureBox1
            //
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //
            // buttonOK
            //
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(327, 82);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(74, 22);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            //
            // buttonDetails
            //
            this.buttonDetails.Location = new System.Drawing.Point(26, 82);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(74, 22);
            this.buttonDetails.TabIndex = 7;
            this.buttonDetails.Text = "<< Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            //
            // labelErrorCaption
            //
            this.labelErrorCaption.AutoSize = true;
            this.labelErrorCaption.Location = new System.Drawing.Point(83, 21);
            this.labelErrorCaption.Name = "labelErrorCaption";
            this.labelErrorCaption.Size = new System.Drawing.Size(158, 13);
            this.labelErrorCaption.TabIndex = 18;
            this.labelErrorCaption.Text = "Leider ist ein Fehler aufgetreten.";
            //
            // labelErrorMessage
            //
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(83, 41);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(40, 13);
            this.labelErrorMessage.TabIndex = 19;
            this.labelErrorMessage.Text = "<Leer>";
            this.labelErrorMessage.Visible = false;
            //
            // labelExitMessage
            //
            this.labelExitMessage.AutoSize = true;
            this.labelExitMessage.Location = new System.Drawing.Point(83, 60);
            this.labelExitMessage.Name = "labelExitMessage";
            this.labelExitMessage.Size = new System.Drawing.Size(143, 13);
            this.labelExitMessage.TabIndex = 20;
            this.labelExitMessage.Text = "Das Programm wird beendet.";
            this.labelExitMessage.Visible = false;
            //
            // buttonCopyToClipboard
            //
            this.buttonCopyToClipboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(24, 302);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(374, 22);
            this.buttonCopyToClipboard.TabIndex = 22;
            this.buttonCopyToClipboard.Text = "In die Zwischenablage kopieren";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            //
            // listViewTrace
            //
            this.listViewTrace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewTrace.FullRowSelect = true;
            this.listViewTrace.GridLines = true;
            this.listViewTrace.Location = new System.Drawing.Point(26, 130);
            this.listViewTrace.Name = "listViewTrace";
            this.listViewTrace.Size = new System.Drawing.Size(374, 164);
            this.listViewTrace.TabIndex = 23;
            this.listViewTrace.UseCompatibleStateImageBehavior = false;
            this.listViewTrace.View = System.Windows.Forms.View.Details;
            //
            // columnHeader5
            //
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 25;
            //
            // columnHeader6
            //
            this.columnHeader6.Text = "Message";
            this.columnHeader6.Width = 120;
            //
            // columnHeader7
            //
            this.columnHeader7.Text = "Type";
            this.columnHeader7.Width = 80;
            //
            // columnHeader8
            //
            this.columnHeader8.Text = "Source";
            this.columnHeader8.Width = 120;
            //
            // ErrorForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 335);
            this.Controls.Add(this.listViewTrace);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.labelExitMessage);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.labelErrorCaption);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fehler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Label labelErrorCaption;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label labelExitMessage;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.ListView listViewTrace;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;

    }
}
