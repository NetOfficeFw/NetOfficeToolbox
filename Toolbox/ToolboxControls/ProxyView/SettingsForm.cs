﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetOffice.DeveloperToolbox.ToolboxControls.ProxyView
{
    public partial class SettingsForm : Form
    {
        #region Fields

        private bool _isDirty;

        #endregion
        
        #region Ctor

        public SettingsForm()
        {
            InitializeComponent();
            int interval = Settings.RefreshInterval;
            if (interval < 1000)
                interval = 1000;
            if (interval > 90000)
                interval = 90000;
            IntervalTrackBar.Value = interval;
            ShowOfficeAccessibleButton.Checked = !Settings.ShowAllAccessible;
            DetailsCheckBox.Checked = Settings.ShowDetails;
            IntervalTrackBar_ValueChanged(IntervalTrackBar, EventArgs.Empty);
            IsDirty = false;
        }

        #endregion

        #region Properties

        private bool IsDirty
        {
                get
            {
                return _isDirty;
            }
            set
            {
                if(value != _isDirty)
                {
                    _isDirty = value;
                    ApplyButton.Enabled = _isDirty;
                }
            }
        }

        #endregion
        
        #region Methods

        public static DialogResult ShowForm(IWin32Window owner)
        {
            SettingsForm dialog = new SettingsForm();
            return dialog.ShowDialog(owner);
        }

        #endregion

        #region Trigger

        private void AccessibleButton_CheckedChanged(object sender, EventArgs e)
        {
            IsDirty = true;
        }

        private void IntervalTrackBar_ValueChanged(object sender, EventArgs e)
        {
            IsDirty = true;
            IntervalLabel.Text = String.Format("{0} Second(s)", IntervalTrackBar.Value / 1000);
        }

        private void DetailsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsDirty = true;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Settings.RefreshInterval = IntervalTrackBar.Value;
            Settings.ShowDetails = DetailsCheckBox.Checked;
            Settings.ShowAllAccessible = ShowAllAccessibleButton.Checked;
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}

