using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectCasaDeSchimbValutar
{
    [Serializable]
    public class Tranzactii
    {
        private DateTime dataTranzactiei;
        private double valoareInitiala;
        private double valoareFinala;
        private Valute valutaInitiala;
        private Valute valutaFinala;

        public DateTime DataTranzactiei { get => dataTranzactiei; set => dataTranzactiei = value; }
        public double ValoareInitiala { get => valoareInitiala; set => valoareInitiala = value; }
        public double ValoareFinala { get => valoareFinala; set => valoareFinala = value; }
        internal Valute ValutaInitiala { get => valutaInitiala; set => valutaInitiala = value; }
        internal Valute ValutaFinala { get => valutaFinala; set => valutaFinala = value; }
    
        public Tranzactii()
        {
            dataTranzactiei = DateTime.Now;
            valoareInitiala = 0;
            valoareFinala= 0;
            valutaInitiala = null;
            valutaFinala = null;
        }

        public Tranzactii(DateTime d, double vi, double vf, Valute vali, Valute valf)
        {
            dataTranzactiei = d;
            valoareInitiala = vi;
            valoareFinala = vf;
            valutaInitiala = vali;
            valutaFinala = valf;
        }

        public override string ToString()
        {
             int i;
             if (valoareFinala.ToString().IndexOf('.') != -1)
                 i = valoareFinala.ToString().IndexOf('.') + 5;
             else
                 i = valoareFinala.ToString().Length;
            if(i > valoareFinala.ToString().Length)
                return "La data de " + dataTranzactiei.ToString() + ", ai schimbat " + valoareInitiala + " " + valutaInitiala.ToString() + " in " + valoareFinala.ToString() + " " + valutaFinala.ToString();
               else
            return "La data de " + dataTranzactiei.ToString() + ", ai schimbat " + valoareInitiala + " " + valutaInitiala.ToString() + " in " + valoareFinala.ToString().Substring(0,i) + " " + valutaFinala.ToString();
             
            }

        public void efectuareTranzactie()
        {
            dataTranzactiei = DateTime.Now;

            if (valutaInitiala.CodValuta != valutaFinala.CodValuta)
            {
                CursuriValutare cursuriValutare = new CursuriValutare();
            cursuriValutare.incarcaCursuriXML();

            double rataToRon = 0.0;
            double rataRonTo = 0.0;

            foreach(KeyValuePair<string, double> pereche in cursuriValutare.RateSchimb) 
            { 
                
                if(valutaInitiala.CodValuta == "RON")
                {
                    rataToRon = 1.0;
                }
                else 
                    if(valutaInitiala.CodValuta == pereche.Key)
                {
                    rataToRon = pereche.Value;
                }
                
                if(valutaFinala.CodValuta == "RON")
                {
                    rataRonTo = 1.0;
                }
                else
                    if(valutaFinala.CodValuta== pereche.Key)
                {
                    rataRonTo = pereche.Value;
                }
            }
            
                double valoare = 0;
                valoare = valoareInitiala * rataToRon;
                valoareFinala = valoare / rataRonTo;
            }
            else
            {
                valoareFinala = valoareInitiala;
            }
        }

    }
}
