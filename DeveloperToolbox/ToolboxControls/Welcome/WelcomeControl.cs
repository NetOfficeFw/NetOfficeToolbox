using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NetOffice.DeveloperToolbox.ToolboxControls.Welcome
{
    /// <summary>
    /// The first title page of the application
    /// </summary>
    [ResourceTable("ToolboxControls.Welcome.Strings.txt")]
    public partial class WelcomeControl : UserControl, IToolboxControl
    {
        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        public WelcomeControl()
        {
            InitializeComponent();
            labelVersionHint.Text = String.Format("Version {0}", AssemblyInfo.AssemblyVersion);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Corresponding tray icon in the bottom right area
        /// </summary>
        private NotifyIcon TrayIcon { get; set; }

        #endregion

        #region IToolboxControl

        public IToolboxHost Host { get; private set; }

        public string ControlName
        {
            get { return "Welcome.WelcomeControl"; }
        }

        public string ControlCaption
        {
            get { return "Hallo"; }
        }

        public Image Icon
        {
            get { return Resources.ResourceUtils.ReadImageFromResource("ToolboxControls.Welcome.welcome.png"); }
        }

        public bool SupportsHelpContent
        {
            get
            {
                return false;
            }
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

        public void LoadConfiguration(System.Xml.XmlNode configNode)
        {
        }

        public void SaveConfiguration(System.Xml.XmlNode configNode)
        {
        }

        public void SetLanguage(int id)
        {

        }

        public Stream GetHelpText(int lcid)
        {
            throw new NotImplementedException();
        }

        public new void KeyDown(KeyEventArgs e)
        {

        }

        public void Release()
        {
        }

        public IContainer Components
        {
            get { return components; }
        }

        #endregion

        #region ILocalizationDesign

        public void EnableDesignView(int lcid, string parentComponentName)
        {
        }

        public void Localize(Translation.ItemCollection strings)
        {
            Translation.Translator.TranslateControls(this, strings);
        }

        public void Localize(string name, string text)
        {
            Translation.Translator.TranslateControl(this, name, text);
        }

        public string GetCurrentText(string name)
        {
            return Translation.Translator.TryGetControlText(this, name);
        }

        public string NameLocalization
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ILocalizationChildInfo> Childs
        {
            get
            {
                return new ILocalizationChildInfo[0];
            }
        }

        #endregion

        #region Methods
        
        private void ResizeControls()
        {
            pictureBoxHeader.Location = new Point((this.Width / 2) - (pictureBoxHeader.Width / 2), 13);
            labelVersionHint.Location = new Point((this.Width / 2) - (labelVersionHint.Width / 2)-5, pictureBoxLogo.Top + pictureBoxLogo.Height-40);
        }

        #endregion

        #region Trigger

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel label = sender as LinkLabel;
                System.Diagnostics.Process.Start(label.Text);
            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(this, exception,ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
        }

        private void WelcomeControl_Resize(object sender, EventArgs e)
        {
            try
            {
                ResizeControls();
            }
            catch (Exception exception)
            {
                 Forms.ErrorForm.ShowError(this, exception,ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            try
            {
                Host.SwitchTo("ProjectWizard.ProjectWizardControl");
            }
            catch (Exception exception)
            {
                Forms.ErrorForm.ShowError(this, exception,ErrorCategory.NonCritical, Host.CurrentLanguageID);
            }
        }
        #endregion
    }
}
