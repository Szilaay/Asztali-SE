using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tb_valutavalto
{
    internal class Devizak
    {
        private string devkod;
        private string devnev;

        public string Devkod { get => devkod; set => devkod = value; }
        public string Devnev { get => devnev; set => devnev = value; }

        public Devizak(string sor)
        {
            string[] elemek = sor.Split(';');
            devkod = elemek[0];
            devnev = elemek[1];
        }

        public string nevKiiras()
        {
            return devkod + " - " + devnev;
        }
    }
}
