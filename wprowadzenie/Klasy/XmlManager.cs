using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace wprowadzenie.Klasy
{
    internal static class XmlManager
    {
        public static T DeseralizujXML<T>(string sciezka, string xsdSciezka)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlReaderSettings opcje = new XmlReaderSettings();

            opcje.Schemas.Add(null, xsdSciezka);
            opcje.ValidationType = ValidationType.Schema;

            opcje.ValidationEventHandler += (sender, e) =>
            {
                if (e.Exception != null)
                {
                    throw new Exception($"Błąd walidacji XML\n{e.Message}\nLinia:{e.Exception.LineNumber}");

                }
            };
            using (XmlReader reader = XmlReader.Create(sciezka))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
