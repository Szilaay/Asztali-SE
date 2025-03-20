using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szegedCLI
{
    internal class Data
    {
        string jaratszam;
        string jaratvegallomas;
        string jaratmegallonev;
        string jarattipus;

        public string Jaratszam { get => jaratszam; set => jaratszam = value; }
        public string Jaratvegallomas { get => jaratvegallomas; set => jaratvegallomas = value; }
        public string Jaratmegallonev { get => jaratmegallonev; set => jaratmegallonev = value; }
        public string Jarattipus { get => jarattipus; set => jarattipus = value; }

        public Data(string sor)
        {
            string[] row = sor.Split(';');
            jaratszam = row[0];
            jaratvegallomas = row[1];
            jaratmegallonev = row[2];
            jarattipus = row[3];
        }
    }
}
