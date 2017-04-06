using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetOffice.DeveloperToolbox.Translation;

namespace NetOffice.DeveloperToolbox.ToolboxControls.ProjectWizard
{
    internal class LocalizedContent
    {
        public string StepProgress
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["StepProgress"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "StepProgress");
                }
            }
        }

        public string Completed
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["Completed"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "Completed");
                }
            }
        }

        public string Yes
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["Yes"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "Yes");
                }
            }
        }

        public string No
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["No"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "No");
                }
            }
        }

        public string AddinStartup
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["AddinOption1"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "AddinOption1");
                }
            }
        }

        public string AddinOnDemand
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["AddinOption2"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "AddinOption2");
                }
            }
        }

        public string AddinNotAutomaticaly
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["AddinOption3"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "AddinOption3");
                }
            }
        }

        public string AddinFirstTime
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["AddinOption4"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "AddinOption4");
                }
            }
        }

        public string Registry
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["Registry"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "Registry");
                }
            }
        }

        public string RegistryCurrentUser
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["CurrentUser"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "CurrentUser");
                }
            }
        }

        public string RegistryLocalMachine
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["LocalMachine"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "LocalMachine");
                }
            }
        }

        public string LoadBehavior
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["LoadBehavior"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "LoadBehavior");
                }
            }
        }

        public string Language
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["Language"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "Language");
                }
            }
        }

        public string Runtime
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["Runtime"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "Runtime");
                }
            }
        }

        public string Applications
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["Applications"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "Applications");
                }
            }
        }

        public string ProjectType
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["ProjectType"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "ProjectType");
                }
            }
        }

        public string ProjectFolder
        {
            get
            {
                Translation.ToolLanguage language = Forms.MainForm.Singleton.Languages.Where(l => l.LCID == Forms.MainForm.Singleton.CurrentLanguageID).FirstOrDefault();
                if (null != language)
                {
                    var component = language.Components["Project Wizard - Messages"];
                    return component.ControlResources["ProjectFolder"].Value2;
                }
                else
                {
                    return Translator.GetResourceValue("ToolboxControls.ProjectWizard.LocalizationStrings.txt", Forms.MainForm.Singleton.CurrentLanguageID, "ProjectFolder");
                }
            }
        }
    }
}
