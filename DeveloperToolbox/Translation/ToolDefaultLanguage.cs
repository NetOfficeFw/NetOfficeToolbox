﻿using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetOffice.DeveloperToolbox.Translation
{
    /// <summary>
    /// Default Language Kind
    /// </summary>
    internal enum ToolDefaultLanguageName
    {
        /// <summary>
        /// En-us
        /// </summary>
        English = 0,

        /// <summary>
        /// de-de
        /// </summary>
        German = 1
    }

    /// <summary>
    /// Application default language settings(not changeble)
    /// </summary>
    internal class ToolDefaultLanguage : ToolLanguage
    {
        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="parent">parent collection</param>
        /// <param name="name">default kind</param>
       internal ToolDefaultLanguage(ToolLanguages parent, ToolDefaultLanguageName name) : base(parent, "", 1000)
       {
           DefaultLanguageName = name;
       }

       /// <summary>
       /// Default Kind
       /// </summary>
       internal ToolDefaultLanguageName DefaultLanguageName { get; private set; }

       public override string Name
       {
           get
           {
               return DefaultLanguageName == ToolDefaultLanguageName.German ? "Deutsch" : "English";
           }
           set
           {
               throw new NotSupportedException();
           }
       }

       public override string NameGlobal
       {
           get
           {
               return DefaultLanguageName == ToolDefaultLanguageName.German ? "German" : "English";
           }
           set
           {
               throw new NotSupportedException();
           }
       }

       public override string Author
       {
           get
           {
               return DefaultLanguageName == ToolDefaultLanguageName.German ? "Sebastian Lange" : "Matthias Viehweger / Sebastian Lange";
           }
           set
           {
               throw new NotSupportedException();
           }
       }

       public override string AuthorMail
       {
           get
           {
               return DefaultLanguageName == ToolDefaultLanguageName.German ? "public.sebastian@web.de" : "";
           }
           set
           {
               throw new NotSupportedException();
           }
       }

       public override string AuthorSite
       {
           get
           {
               return DefaultLanguageName == ToolDefaultLanguageName.German ? "netoffice.codeplex.com" : "kronn.de / netoffice.codeplex.com";
           }
           set
           {
               throw new NotSupportedException();
           }
       }

       public override int LCID
       {
           get
           {
               return DefaultLanguageName == ToolDefaultLanguageName.German ? 1031 : 1033;
           }
           set
           {
               throw new NotSupportedException();
           }
       }

       internal override ItemCollection GetValues(string componentName)
       {
           // look internal components first
           var component = Application.Components.First(c => c.Value.Equals(componentName, StringComparison.InvariantCultureIgnoreCase));
           if (null != component)
           {
                Dictionary<string, string> values = Translator.GetTranslateRessources(component.Design, component.Attribute.Address, Convert.ToInt32(LCID));
                ItemCollection result = new ItemCollection();
                foreach (var item in values)
                {
                    result.Add(new LocalizableString(item.Key, item.Value));
                }
               return result;
           }
           else
           {
               throw new NotImplementedException();
           }
       }
    }
}
