﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace NetOffice.DeveloperToolbox.Translation
{
    public class Translator
    {
        public static void TranslateControls(Control control, string ressourceFile, int languageId)
        {
            string ressourceContent = ReadString(ressourceFile);
            string[] splitArray = ressourceContent.Split(new string[] { "[End]" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> translateTable = GetTranslateRessources(splitArray, languageId);

            IToolboxControl toolBoxControl = control as IToolboxControl;
            if ((null != toolBoxControl) && (null != toolBoxControl.Components))
            {
                foreach (System.ComponentModel.IComponent controlComponent in toolBoxControl.Components.Components)
                {
                    ContextMenuStrip menuStrip = controlComponent as ContextMenuStrip;
                    if (null != menuStrip)
                    {
                        string message = "";
                        translateTable.TryGetValue(menuStrip.Name, out message);
                        if (!string.IsNullOrEmpty(message))
                            menuStrip.Text = message;

                        foreach (ToolStripItem unkownItem in menuStrip.Items)
                        {
                            ToolStripMenuItem menuItem = unkownItem as ToolStripMenuItem;
                            if (null != menuItem)
                            {
                                message = "";
                                translateTable.TryGetValue(menuItem.Name, out message);
                                if (!string.IsNullOrEmpty(message))
                                    menuItem.Text = message;
                                ForEachItems(menuItem, translateTable);
                            }
                        }
                    }
                }
            }

            string caption = "";
            translateTable.TryGetValue("this", out caption);
            if (!string.IsNullOrEmpty(caption))
                control.Text = caption;

            foreach (Control item in control.Controls)
            {
                string message = "";
                translateTable.TryGetValue(item.Name, out message);
                if (!string.IsNullOrEmpty(message))
                    item.Text = message;
                ForEachSubControls(item, translateTable);
            }

        }

        private static void ForEachItems(ToolStripMenuItem item, Dictionary<string, string> translateTable)
        {
            foreach (ToolStripMenuItem subItem in item.DropDownItems)
            {
                string message = "";
                translateTable.TryGetValue(subItem.Name, out message);
                if (!string.IsNullOrEmpty(message))
                    subItem.Text = message;
                ForEachItems(subItem, translateTable);
            }
        }

        private static void ForEachSubControls(Control item, Dictionary<string, string> translateTable)
        {
            foreach (Control subItem in item.Controls)
            {
                string message = "";
                translateTable.TryGetValue(subItem.Name, out message);
                if (!string.IsNullOrEmpty(message))
                    subItem.Text = message;
                ForEachSubControls(subItem, translateTable);
            }
        }

        private static Dictionary<string, string> GetTranslateRessources(string[] splitArray, int languageId)
        {
            Dictionary<string, string> resultDictionary = new Dictionary<string, string>();

            foreach (string item in splitArray)
            {
                string[] lines = item.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    if ("[" + languageId.ToString() + "]" == line.Trim())
                    {
                        AddToDictionary(resultDictionary, lines);
                        return resultDictionary;
                    }
                }
            }

            throw new IndexOutOfRangeException(languageId.ToString() + " not found.");
        }

        private static void AddToDictionary(Dictionary<string, string> resultDictionary, string[] lines)
        {
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                if (!string.IsNullOrEmpty(line.Trim()))
                {
                    int position = line.IndexOf("=", StringComparison.InvariantCultureIgnoreCase);
                    string name = line.Substring(0, position - 1).Trim();
                    string value = line.Substring(position + 1).Trim();
                    resultDictionary.Add(name, value);
                }
            }
        }

        public static string ReadString(string ressourcePath)
        {
            System.IO.Stream ressourceStream = null;
            System.IO.StreamReader textStreamReader = null;
            try
            {
                string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                ressourcePath = assemblyName + "." + ressourcePath;
                ressourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(ressourcePath);
                if (ressourceStream == null)
                    throw (new System.IO.IOException("Error accessing resource Stream."));

                textStreamReader = new System.IO.StreamReader(ressourceStream);
                if (textStreamReader == null)
                    throw (new System.IO.IOException("Error accessing resource File."));

                string text = textStreamReader.ReadToEnd();
                return text;
            }
            catch (Exception exception)
            {
                throw (exception);
            }
            finally
            {
                if (null != textStreamReader)
                    textStreamReader.Close();
                if (null != ressourceStream)
                    ressourceStream.Close();
            }
        }
    }
}
