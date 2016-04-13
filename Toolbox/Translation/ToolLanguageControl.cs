﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetOffice.DeveloperToolbox.Translation
{
    public partial class ToolLanguageControl : UserControl
    {
        private ToolLanguage _selectedLanguage;

        public ToolLanguageControl()
        {
            InitializeComponent();
        }

        public event EventHandler SelectedTabChanged;

        private void RaiseSelectedTabChanged()
        {
            if (null != SelectedTabChanged)
                SelectedTabChanged(this, EventArgs.Empty);
        }

        public int SelectedTabIndex
        {
            get
            {
                return tabControl1.SelectedIndex;
            }
        }

        internal ToolLanguage SelectedLanguage
        {
            get
            {
                return _selectedLanguage;
            }
            set
            {
                _selectedLanguage = value;
                languageSummaryControl1.SelectedLanguage = value;
                languageApplicationControl1.SelectedLanguage = value;
                languageComponentsControl1.SelectedLanguage = value;
            }
        }

        internal void HandleKeyDown()
        {
            languageApplicationControl1.HandleKeyDown();
            languageComponentsControl1.HandleKeyDown();
        }

        internal void HandleKeyUp()
        {
            languageApplicationControl1.HandleKeyUp();
            languageComponentsControl1.HandleKeyUp();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            languageApplicationControl1.DisableComponents();
            languageComponentsControl1.DisableComponents();
            RaiseSelectedTabChanged();
        }
    }
}
