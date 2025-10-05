using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProiectCasaDeSchimbValutar
{
    internal class CursuriValutare
    {
   
        private Dictionary<string, double> rateSchimb;
        public Dictionary<string, double> RateSchimb { get => rateSchimb; set => rateSchimb = value; }

        public void incarcaCursuriXML()
        {
            rateSchimb = new Dictionary<string, double>();

            StreamReader reader = new StreamReader("nbrfxrates.xml");
            XmlReader xmlReader = XmlReader.Create(reader);

            while (xmlReader.Read())
            {
                if(xmlReader.Name == "Rate")
                {
                    string cod = xmlReader.GetAttribute("currency"); //ia valoarea atributului currency
                    double curs = double.Parse(xmlReader.ReadInnerXml()); //ia valoarea din interiorul nodului
                    rateSchimb.Add(cod, curs);
                }
            }
        }
        
    
    
    
    }
}
