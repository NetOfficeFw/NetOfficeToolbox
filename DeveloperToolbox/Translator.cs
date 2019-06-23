using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetOffice.DeveloperToolbox
{
    class Translator
    {
        public static string GetResourceValue(string resourceFile, string resourceName)
        {
            return GetResourceValue(resourceFile, 1033, resourceName);
        }

        public static string GetResourceValue(string resourceFile, int languageId, string resourceName)
        {
            string resourceContent = ReadString(resourceFile);
            string[] splitArray = resourceContent.Split(new string[] { "[End]" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> translateTable = GetTranslateResources(splitArray, languageId);
            var res = translateTable.Where(n => n.Key == resourceName).FirstOrDefault();
            if (null != res.Key)
                return res.Value;
            else
                return null;
        }

        private static Dictionary<string, string> GetTranslateResources(string[] splitArray, int languageId)
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

            return resultDictionary;
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

        /// <summary>
        /// Read content as string from resource file
        /// </summary>
        /// <param name="resourcePath">path to resource file</param>
        /// <returns>content of resource file</returns>
        public static string ReadString(string resourcePath)
        {
            System.IO.Stream resourceStream = null;
            System.IO.StreamReader textStreamReader = null;
            try
            {
                string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                resourcePath = assemblyName + "." + resourcePath;
                resourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
                if (resourceStream == null)
                    throw (new System.IO.IOException("Error accessing resource Stream."));

                textStreamReader = new System.IO.StreamReader(resourceStream);
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
                if (null != resourceStream)
                    resourceStream.Close();
            }
        }
    }
}