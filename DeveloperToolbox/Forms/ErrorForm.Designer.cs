﻿namespace NetOffice.DeveloperToolbox.Forms
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
            this.errorControl1 = new NetOffice.DeveloperToolbox.Controls.Error.ErrorControl();
            this.SuspendLayout();
            // 
            // errorControl1
            // 
            this.errorControl1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.errorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorControl1.Location = new System.Drawing.Point(9, 9);
            this.errorControl1.Name = "errorControl1";
            this.errorControl1.Size = new System.Drawing.Size(606, 458);
            this.errorControl1.TabIndex = 0;
            this.errorControl1.UserClose += new System.EventHandler(this.errorControl1_UserClose);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(624, 476);
            this.Controls.Add(this.errorControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 514);
            this.Name = "ErrorForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Error.ErrorControl errorControl1;


    }
}
