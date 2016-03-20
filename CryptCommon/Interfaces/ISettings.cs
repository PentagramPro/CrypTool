using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CryptCommon.Interfaces
{
    [DataContract]
    public abstract class Settings
    {
        public static T Deserialize<T>(string path) where T: new()
        {
            T res;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (XmlDictionaryReader reader =
                      XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas()))
                    {
                        DataContractSerializer ser = new DataContractSerializer(typeof(T));

                        // Deserialize the data and read it from the instance.
                        res = (T)ser.ReadObject(reader, true);
                    }
                }
            }
            catch (Exception)
            {
                res = new T();
            }

            return res;
        }

        public static void Serialize<T>(string path, T obj) where T: new()
        {
            using (XmlWriter writer = XmlWriter.Create(path, new XmlWriterSettings { Indent = true }))
            {
                DataContractSerializer ser =
                  new DataContractSerializer(typeof(T));

                ser.WriteObject(writer, obj);
            }
        }
    }
}
