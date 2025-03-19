using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozok> lista = new List<Dolgozok>();

            FileStream fs = new FileStream("berek2020.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                lista.Add(new Dolgozok(sr.ReadLine()));
            }

            sr.Close();
            fs.Close();

            // 3. feladat
            Console.WriteLine($"3. feladat: Dolgozók száma: {lista.Count()} fő");

            // 4. feladat
            double atlagfizu = Math.Round(lista.Average(x => x.Ber) / 1000, 1);
            Console.WriteLine($"4. feladat: Bérek átlaga: {atlagfizu} eFt");

            // 5. feladat
            Console.Write("5. feladat: Kérem a részleg nevét: ");
            string reszleg = Console.ReadLine();

            List<Dolgozok> reszelges = new List<Dolgozok>();
            foreach (var i in lista)
            {
                if (i.Reszleg == reszleg)
                {
                    reszelges.Add(i);
                }
            }
            if(reszelges.Count == 0)
            {
                Console.WriteLine("6. feladat: A megadott részleg nem található");
            }
            else
            {
                int max = reszelges.Max(x => x.Ber);

                Console.WriteLine($"6. feladat: A legtöbbet kereső dolgozó a megadott részlegen:");
                Console.WriteLine($"\tNév {reszelges.First(x => x.Ber == max).Nev}");
                Console.WriteLine($"\tNeme {reszelges.First(x => x.Ber == max).Neme}");
                Console.WriteLine($"\tBelépés {reszelges.First(x => x.Ber == max).Belepes}");
                Console.WriteLine($"\tBér: {reszelges.First(x => x.Ber == max).Ber.ToString("#,##0")} Forint");
            }

            // 7. feladat
            Console.WriteLine("7. feladat: Statisztika");

            Dictionary<string, int> statisztika = new Dictionary<string, int>();

            for (int i = 0; i < lista.Count; i++)
            {
                if (statisztika.ContainsKey(lista[i].Reszleg))
                {
                    statisztika[lista[i].Reszleg]++;
                }
                else
                {
                    statisztika.Add(lista[i].Reszleg, 1);
                }
            }
            foreach (var i in statisztika)
            {
                Console.WriteLine($"\t{i.Key} - {i.Value} fő");
            }


            Console.ReadKey(true);
        }
    }
}
