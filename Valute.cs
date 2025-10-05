using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProiectCasaDeSchimbValutar
{
    [Serializable]
    public class Valute
    {
        private string numeValuta;
        private string codValuta;
        private string taraDeOrigine;

        public string NumeValuta { get => numeValuta; set => numeValuta = value; }
        public string CodValuta { get => codValuta; set => codValuta = value; }
        public string TaraDeOrigine { get => taraDeOrigine; set => taraDeOrigine = value; }

        public Valute()
        {
            numeValuta = "N/A";
            codValuta = "N/A";
            taraDeOrigine = "N/A";
        }
    
        public Valute(string n, string c, string t)
        {
            numeValuta = n;
            codValuta = c;
            taraDeOrigine = t;
        }

        public override string ToString()
        {
            return codValuta;
        }
    }
}
