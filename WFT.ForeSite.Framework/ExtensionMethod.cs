using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFT.ForeSite.Framework
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// Serialize to XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="fileName"></param>
        public static void SerializeToXml<T>(T obj, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));//Creating XmlSerializer.
            TextWriter tw = new StreamWriter(fileName);//Creating text writer for xml data
            serializer.Serialize(tw, obj);//Convert the XML to List
            tw.Close();
        }

        /// <summary>
        /// DeSerialize from XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }
    }
}
