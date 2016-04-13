﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetOffice.DeveloperToolbox
{
    static class CodeTemplates
    {
        static string _assemblyReference;
        static string _usingCSharp;
        static string _usingVB;
        static string _ribbonReference;

        static string _ribbonImplementCSharp;
        static string _ribbonImplementVB;
        static string _ribbonImplementCodeCSharp;
        static string _ribbonImplementCodeVB;

        static string _registerCodeCSharp;
        static string _registerCodeVB;

        static string _unRegisterCodeCSharp;
        static string _unRegisterCodeVB;

        static string _helperCodeCSharp;
        static string _helperCodeVB;

        static string _classicUIMethodCSharp;
        static string _classicUIMethodVB;

        static string _classicUIMethodCallCSharp;
        static string _classicUIMethodCallVB;


        static string _classicUIRemoveMethodCallCSharp;
        static string _classicUIRemoveMethodCallVB;

        static string _classicUIRemoveMethodCSharp;
        static string _classicUIRemoveMethodVB;

        static string _appFieldCodeCSharp;
        static string _appFieldCodeVB;

        static string _appDestroyCodeCSharp;
        static string _appDestroyCodeVB;

        static string _appCreateCodeCSharp;
        static string _appCreateCodeVB;

        public static string AssemblyReference
        {
            get
            {
                if (null == _assemblyReference)
                    _assemblyReference = Translator.ReadString("ProjectWizard.CodeTemplates.AssemblyReference.txt");
                return _assemblyReference;
            }
        }

        public static string RibbonReference
        {
            get
            {
                if (null == _ribbonReference)
                    _ribbonReference = Translator.ReadString("ProjectWizard.CodeTemplates.RibbonRessourceReference.txt");
                return _ribbonReference;
            }
        }

        public static string AppConstructionCode(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {

                if (null == _appCreateCodeCSharp)
                    _appCreateCodeCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.ApplicationCreateCodeCSharp.txt");
                return _appCreateCodeCSharp;
            }
            else
            {
                if (null == _appCreateCodeVB)
                    _appCreateCodeVB = Translator.ReadString("ProjectWizard.CodeTemplates.ApplicationCreateCodeVB.txt");
                return _appCreateCodeVB;
            }
        }

        public static string AppDestroyCode(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {

                if (null == _appDestroyCodeCSharp)
                    _appDestroyCodeCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.ApplicationDestroyCodeCSharp.txt");
                return _appDestroyCodeCSharp;
            }
            else
            {
                if (null == _appDestroyCodeVB)
                    _appDestroyCodeVB = Translator.ReadString("ProjectWizard.CodeTemplates.ApplicationDestroyCodeVB.txt");
                return _appDestroyCodeVB;
            }
        }

        public static string AppFieldCode(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {

                if (null == _appFieldCodeCSharp)
                    _appFieldCodeCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.ApplicationFieldCodeCSharp.txt");
                return _appFieldCodeCSharp;
            }
            else
            {
                if (null == _appFieldCodeVB)
                    _appFieldCodeVB = Translator.ReadString("ProjectWizard.CodeTemplates.ApplicationFieldCodeVB.txt");
                return _appFieldCodeVB;
            }
        }

        public static string ClassicUIRemoveCall(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {

                if (null == _classicUIRemoveMethodCallCSharp)
                    _classicUIRemoveMethodCallCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.RemoveUICallCodeCSharp.txt");
                return _classicUIRemoveMethodCallCSharp;
            }
            else
            {
                if (null == _classicUIRemoveMethodCallVB)
                    _classicUIRemoveMethodCallVB = Translator.ReadString("ProjectWizard.CodeTemplates.RemoveUICallCodeVB.txt");
                return _classicUIRemoveMethodCallVB;
            }
        }

        public static string ClassicUIRemoveMethod(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {

                if (null == _classicUIRemoveMethodCSharp)
                    _classicUIRemoveMethodCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.RemoveClassicUIMethodCSharp.txt");
                return _classicUIRemoveMethodCSharp;
            }
            else
            {
                if (null == _classicUIRemoveMethodVB)
                    _classicUIRemoveMethodVB = Translator.ReadString("ProjectWizard.CodeTemplates.RemoveClassicUIMethodVB.txt");
                return _classicUIRemoveMethodVB;
            }
        }

        public static string ClassicUIMethod(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {

                if (null == _classicUIMethodCSharp)
                    _classicUIMethodCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.CreateClassicUIMethodCSharp.txt");
                return _classicUIMethodCSharp;
            }
            else
            {
                if (null == _classicUIMethodVB)
                    _classicUIMethodVB = Translator.ReadString("ProjectWizard.CodeTemplates.CreateClassicUIMethodVB.txt");
                return _classicUIMethodVB;
            }
        }

        public static string ClassicUICall(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {

                if (null == _classicUIMethodCallCSharp)
                    _classicUIMethodCallCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.CreateUICallCodeCSharp.txt");
                return _classicUIMethodCallCSharp;
            }
            else
            {
                if (null == _classicUIMethodCallVB)
                    _classicUIMethodCallVB = Translator.ReadString("ProjectWizard.CodeTemplates.CreateUICallCodeVB.txt");
                return _classicUIMethodCallVB;
            }
        }

        public static string HelperCode(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {

                if (null == _helperCodeCSharp)
                    _helperCodeCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.HelperCodeCSharp.txt");
                return _helperCodeCSharp;
            }
            else
            {
                if (null == _helperCodeVB)
                    _helperCodeVB = Translator.ReadString("ProjectWizard.CodeTemplates.HelperCodeVB.txt");
                return _helperCodeVB;
            }
        }

        public static string UnRegisterCode(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {
                if (null == _unRegisterCodeCSharp)
                    _unRegisterCodeCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.UnregisterCodeCSharp.txt");
                return _unRegisterCodeCSharp;
            }
            else
            {
                if (null == _unRegisterCodeVB)
                    _unRegisterCodeVB = Translator.ReadString("ProjectWizard.CodeTemplates.UnregisterCodeVB.txt");
                return _unRegisterCodeVB;
            }
        }

        public static string RegisterCode(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {
                if (null == _registerCodeCSharp)
                    _registerCodeCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.RegisterCodeCSharp.txt");
                return _registerCodeCSharp;
            }
            else
            {
                if (null == _registerCodeVB)
                    _registerCodeVB = Translator.ReadString("ProjectWizard.CodeTemplates.RegisterCodeVB.txt");
                return _registerCodeVB;
            }
        }

        public static string RibbonImplementCode(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {
                if (null == _ribbonImplementCodeCSharp)
                    _ribbonImplementCodeCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.RibbonImplementCodeCSharp.txt");
                return _ribbonImplementCodeCSharp;
            }
            else
            {
                if (null == _ribbonImplementCodeVB)
                    _ribbonImplementCodeVB = Translator.ReadString("ProjectWizard.CodeTemplates.RibbonImplementCodeVB.txt");
                return _ribbonImplementCodeVB;
            }
        }

        public static string RibbonImplement(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {
                if (null == _ribbonImplementCSharp)
                    _ribbonImplementCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.RibbonImplementCSharp.txt");
                return _ribbonImplementCSharp;
            }
            else
            {
                if (null == _ribbonImplementVB)
                    _ribbonImplementVB = Translator.ReadString("ProjectWizard.CodeTemplates.RibbonImplementVB.txt");
                return _ribbonImplementVB;
            }
        }

        public static string Using(ProgrammingLanguage language)
        {
            if (language == ProgrammingLanguage.CSharp)
            {
                if (null == _usingCSharp)
                    _usingCSharp = Translator.ReadString("ProjectWizard.CodeTemplates.UsingCSharp.txt");
                return _usingCSharp;
            }
            else
            {
                if (null == _usingVB)
                    _usingVB = Translator.ReadString("ProjectWizard.CodeTemplates.UsingVB.txt");
                return _usingVB;
            }
        }

    }
}
