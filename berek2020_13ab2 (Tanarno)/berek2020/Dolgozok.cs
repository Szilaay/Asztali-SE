using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
    internal class Dolgozok
    {
        string nev;
        string neme;
        string reszleg;
        string belepes;
        int ber;

        public string Nev { get => nev; set => nev = value; }
        public string Neme { get => neme; set => neme = value; }
        public string Reszleg { get => reszleg; set => reszleg = value; }
        public string Belepes { get => belepes; set => belepes = value; }
        public int Ber { get => ber; set => ber = value; }

        public Dolgozok(string sor)
        {
            string[] darabok=sor.Split(';');
            nev=darabok[0];
            neme=darabok[1];
            reszleg=darabok[2];
            belepes=darabok[3];
            ber=Convert.ToInt32(darabok[4]);
        }
    }
}
