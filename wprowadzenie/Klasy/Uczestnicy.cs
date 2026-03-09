using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using wprowadzenie.Klasy;

namespace wprowadzenie.osoby

{
    [XmlRoot("uczestnicy")]
    public class Uczestnicy
    {
        [XmlElement("osoba")]
        public List<Osoby> ListaOsob { get; set; }
    }
}
