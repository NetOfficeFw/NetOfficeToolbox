﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Xml;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetOffice.DeveloperToolbox.ToolboxControls.OutlookSecurity
{
    public partial class OutlookSecurityControl : UserControl, IToolboxControl
    {
        #region Fields

        private bool _programaticChange;
        private Exception _exception;
        private NetOffice.OutlookSecurity.SecurityDialog _dialog;
        private NetOffice.OutlookSecurity.SecurityDialogCheckBox _targetBox;
        private NetOffice.OutlookSecurity.SecurityDialogLeftButton _targetButton;

        #endregion

        #region Construction

        public OutlookSecurityControl()
        {
            try
            {
                InitializeComponent();
                if (!DesignMode)
                {
                    NetOffice.OutlookSecurity.Supress.OnAction += new NetOffice.OutlookSecurity.Supress.SecurityDialogAction(Supress_OnAction);
                    NetOffice.OutlookSecurity.Supress.OnError += new NetOffice.OutlookSecurity.Supress.ErrorOccuredEventHandler(Supress_OnError);
                }
            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(exception, Forms.ErrorCategory.NonCritical, 1033);
            }
        }

        #endregion

        #region Properties

        private new bool DesignMode
        {
            get
            {
                return (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv");
            }
        }

        #endregion

        #region IToolboxControl Member

        public IToolboxHost Host { get; private set; }

        public new void KeyDown(KeyEventArgs e)
        {

        }

        public string ControlName
        {
            get { return "OutlookSecurity.OutlookSecurityControl"; }
        }

        public string ControlCaption
        {
            get { return "Outlook Security"; }
        }

        public System.ComponentModel.IContainer Components
        {
            get
            {
                return components;
            }
        }

        public Image Icon
        {
            get { return Ressources.RessourceUtils.ReadIconImageFromRessource("ToolboxControls.OutlookSecurity.Icon.ico"); }
        }

        public bool SupportsInfoMessage
        {
            get
            {
                return false;
            }
        }

        public ToolboxControlMessageKind InfoMessageKind
        {
            get
            {
                return ToolboxControlMessageKind.Uncategorized;
            }
        }

        public string InfoMessage
        {
            get
            {
                return String.Empty;
            }
        }

        public bool SupportsHelpContent
        {
            get
            {
                return true;
            }
        }

        public void InitializeControl(IToolboxHost host)
        {
            Host = host;
        }

        public void Activate(bool firstTime)
        {

        }

        public void Deactivated()
        {

        }

        public void LoadComplete()
        {

        }

        public void LoadConfiguration(XmlNode configNode)
        {
            try
            {
                System.Xml.XmlNode node = configNode.SelectSingleNode("SupressEnabled");
                if (null == node)
                {
                    node = configNode.OwnerDocument.CreateElement("SupressEnabled");
                    node.InnerText = "false";
                    configNode.AppendChild(node);
                }
                bool mode = Convert.ToBoolean(node.Value);
                checkBoxSupressEnabled.Checked = mode;
            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(exception, Forms.ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
        }

        public void SaveConfiguration(XmlNode configNode)
        {
            try
            {
                System.Xml.XmlNode node = configNode.SelectSingleNode("SupressEnabled");
                if (null == node)
                {
                    node = configNode.OwnerDocument.CreateElement("SupressEnabled");
                    node.InnerText = BoolToString(checkBoxSupressEnabled.Checked);
                    configNode.AppendChild(node);
                }
                else
                  node.InnerText = BoolToString(checkBoxSupressEnabled.Checked);

            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(exception, Forms.ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
        }

        public void SetLanguage(int id)
        {

        }

        public Stream GetHelpText(int lcid)
        {
            return Ressources.RessourceUtils.ReadStream("ToolboxControls.OutlookSecurity.Info" + lcid.ToString() + ".rtf");
        }

        public void Release()
        {

        }

        #endregion

        #region UI Trigger

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel label = sender as LinkLabel;
                System.Diagnostics.Process.Start(label.Text);
            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(exception, Forms.ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
        }

        private void checkBoxSupressEnabeld_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (_programaticChange)
                    return;
                NetOffice.OutlookSecurity.Supress.Enabled = checkBoxSupressEnabled.Checked;
            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(exception, Forms.ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
        }

        #endregion

        #region Supress Trigger

        private void Supress_OnError()
        {
            try
            {
                _programaticChange = true;
                checkBoxSupressEnabled.Checked = false;
                _programaticChange = false;
                labelMessages.Text = "Error:" + _exception.Message + labelMessages.Text + Environment.NewLine;
            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(exception, Forms.ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
        }

        private  void Supress_OnError(Exception exception)
        {
            _exception= exception;
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Supress_OnError));
            else
                Supress_OnError();
        }

        private void Supress_OnAction()
        {
            try
            {
                labelMessages.Text = "Dialog:" + _dialog.Caption + " CheckBox:" + _targetBox.Caption + " Button:" + _targetButton.Caption + Environment.NewLine;
            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(exception, Forms.ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
       }

        private void Supress_OnAction(NetOffice.OutlookSecurity.SecurityDialog dialog, NetOffice.OutlookSecurity.SecurityDialogCheckBox targetBox, NetOffice.OutlookSecurity.SecurityDialogLeftButton targetButton)
        {
            _dialog = dialog;
            _targetBox = targetBox;
            _targetButton = targetButton;
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Supress_OnAction));
            else
                Supress_OnAction();

        }

        #endregion

        #region Methods

        private static string BoolToString(bool b)
        {
            if (b)
                return "true";
            else
                return "false";
        }

        #endregion
    }
}
