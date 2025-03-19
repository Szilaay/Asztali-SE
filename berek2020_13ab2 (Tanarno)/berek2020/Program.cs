using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozok> lista = new List<Dolgozok>();
            FileStream fs = new FileStream("berek2020.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                Dolgozok d = new Dolgozok(sr.ReadLine());
                lista.Add(d);
            }
            sr.Close();
            fs.Close();
            Console.WriteLine($"3. feladat: Dolgozók száma: {lista.Count} fő");
            double atlagfizu = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                atlagfizu = atlagfizu + lista[i].Ber;
            }
            atlagfizu = Math.Round(atlagfizu/lista.Count/1000,1);
            Console.WriteLine($"4. feladat: Bérek átlaga: {atlagfizu} eFt");
            Console.Write("5. feladat: Kérem egy részleg nevét: ");
            string keresettreszleg=Console.ReadLine();
            List<Dolgozok> keresettlista= new List<Dolgozok>();
            for(int i = 0;i < lista.Count;i++)
            {
                if (lista[i].Reszleg==keresettreszleg)
                    keresettlista.Add(lista[i]);
            }
            if(keresettlista.Count==0)
            {
                Console.WriteLine("6. feladat: A megadott részleg nem létezik a cégnél!");
            }
            else
            {
                int max = 0;
                for(int i = 0;i<keresettlista.Count; i++)
                {
                    if (keresettlista[i].Ber > keresettlista[max].Ber)
                        max = i;
                }
                Console.WriteLine("6. feladat: A legtöbbet kereső dolgozó a megadott részlegen");
                Console.WriteLine($"\tNév: {keresettlista[max].Nev}");
                Console.WriteLine($"\tNeme: {keresettlista[max].Neme}");
                Console.WriteLine($"\tBelépés: {keresettlista[max].Belepes}");
                Console.WriteLine($"\tBér: {keresettlista[max].Ber.ToString("#,##0")} Forint");
            }
            //A megadott részleg dolgozói közül véletlenszerűen válasszon ki egyet és írassa ki az adatait:

            Dictionary<string,int> reszlegenketi= new Dictionary<string,int>();
            for(int i = 0; i < lista.Count;i++)
            {
                if (reszlegenketi.ContainsKey(lista[i].Reszleg))
                    reszlegenketi[lista[i].Reszleg]++;
                else
                    reszlegenketi.Add(lista[i].Reszleg, 1);
            }
            Console.WriteLine("7. feladat: Statisztika");
            foreach(var item in reszlegenketi)
            {
                Console.WriteLine($"\t{item.Key} - {item.Value} fő");
            }
            Console.ReadKey();
        }
    }
}
