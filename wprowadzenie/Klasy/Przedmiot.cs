using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace wprowadzenie.Klasy
{
    public class Przedmiot
    {
        [XmlAttribute("nazwa")]
        public string Nazwa { get; set; }
        [XmlAttribute("ileGodzin")]
        public int IleGodzin { get; set; }
    }
    

    
}
