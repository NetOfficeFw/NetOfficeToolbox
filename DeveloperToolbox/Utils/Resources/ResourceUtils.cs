using System;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetOffice.DeveloperToolbox.Resources
{
    /// <summary>
    /// Resource helper
    /// </summary>
    internal static class ResourceUtils
    {
        private static Dictionary<string, string> _cache = new Dictionary<string, string>();

        /// <summary>
        /// Read resource image
        /// </summary>
        /// <param name="resourcePath">resource path</param>
        /// <returns>image instance from resource</returns>
        internal static Image ReadImageFromResource(string resourcePath)
        {
            System.IO.Stream resourceStream = null;
            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            resourcePath = assemblyName + "." + resourcePath;
            resourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
            if (resourceStream == null)
            {
                throw (new System.IO.IOException("Error accessing resource Stream."));
            }
            Bitmap newIcon = new Bitmap(resourceStream);
            return newIcon;
        }

        /// <summary>
        /// Read resource icon
        /// </summary>
        /// <param name="resourcePath">resource path</param>
        /// <returns>icon instance from resource</returns>
        internal static Image ReadIconImageFromResource(string resourcePath)
        {
            System.IO.Stream resourceStream = null;
            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            resourcePath = assemblyName + "." + resourcePath;
            resourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
            if (resourceStream == null)
            {
                throw (new System.IO.IOException("Error accessing resource Stream."));
            }
            Bitmap newIcon = new Icon(resourceStream).ToBitmap();
            return newIcon;
        }

        /// <summary>
        /// Read resource stream
        /// </summary>
        /// <param name="resourcePath">resource path</param>
        /// <returns>stream from resource</returns>
        internal static Stream ReadStream(string resourcePath)
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            System.IO.Stream resourceStream = ass.GetManifestResourceStream(assemblyName + "." + resourcePath);
            if (resourceStream == null)
            {
                throw (new System.IO.IOException("Error accessing resource Stream."));
            }
            resourceStream.Seek(0, SeekOrigin.Begin);
            return resourceStream;
        }

        /// <summary>
        /// Converts a string to a memory stream
        /// </summary>
        /// <param name="stringValue">stream to convert</param>
        /// <returns>memory stream instance</returns>
        internal static Stream CreateStreamFromString(string stringValue)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(stringValue);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// Read resource file string content
        /// </summary>
        /// <param name="resourcePath">resource path</param>
        /// <param name="autoPrevRootNameSpace">use application root namespace before resource path</param>
        /// <param name="throwExceptionIfNotFound">throw exception if not found, otherwise return null</param>
        /// <returns>System.String or null</returns>
        internal static string ReadString(string resourcePath, bool autoPrevRootNameSpace = true, bool throwExceptionIfNotFound = true)
        {
            string s = null;
            if (_cache.TryGetValue(resourcePath, out s))
            {
                return s;
            }

            System.IO.Stream resourceStream = null;
            System.IO.StreamReader textStreamReader = null;
            try
            {
                string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                if(true == autoPrevRootNameSpace)
                {
                    resourcePath = assemblyName + "." + resourcePath;
                }
                resourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
                if (resourceStream == null)
                {
                    if (throwExceptionIfNotFound)
                    {
                        throw (new System.IO.IOException("Error accessing resource Stream."));
                    }
                    else
                    {
                        Console.WriteLine("Error accessin resource Stream {0}", resourcePath);
                        return null;
                    }
                }

                textStreamReader = new System.IO.StreamReader(resourceStream);
                if (textStreamReader == null)
                {
                    throw (new System.IO.IOException("Error accessing resource File."));
                }

                string text = textStreamReader.ReadToEnd();
                if(!_cache.ContainsKey(resourcePath))
                {
                    _cache.Add(resourcePath, text);
                }
                return text;
            }
            catch (Exception exception)
            {
                throw (exception);
            }
            finally
            {
                if (null != textStreamReader)
                {
                    textStreamReader.Close();
                }
                if (null != resourceStream)
                {
                    resourceStream.Close();
                }
            }
        }
    }
}
