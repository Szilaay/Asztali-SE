using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace szegedCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Data> lista = new List<Data>();

            FileStream fs = new FileStream("szegedCLI_adatok.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while(!sr.EndOfStream)
            {
                lista.Add(new Data(sr.ReadLine()));
            }

            sr.Close();
            fs.Close();

            //:...........:\\

            //3. feladat
            int megallok = lista.Count;
            Console.WriteLine($"3. feladat: Szegeden {megallok} darab megálló található.");

            //4. feladat
            int trolimegallo = lista.Where(x => x.Jarattipus == "troli").Count();
            Console.WriteLine($"4. feladat: Szegedi troli megállók száma: {trolimegallo}");

            //5. feladat
            //Határozza meg, hogy melyik járatnak hány megállója van!

            Dictionary<string, int> jaratmegallo = new Dictionary<string, int>();
            foreach (var item in lista)
            {
                if (jaratmegallo.ContainsKey(item.Jaratszam))
                {
                    jaratmegallo[item.Jaratszam]++;
                }
                else
                {
                    jaratmegallo.Add(item.Jaratszam, 1);
                }
            }

            Console.WriteLine("5. feladat:");
            foreach (var item in jaratmegallo)
            {
                Console.WriteLine($"\tJáratszám: {item.Key}, megállók száma: {item.Value} db");
            }

            //6. feladat
            //Kérjen be a felhasználótól egy járatszámot, majd ellenőrizze, hogy az adott járat létezik-e (a
            //keresést fejezze be, ha a járat létezik). Ha nincs ilyen járat, akkor írja ki a felhasználónak!

            Console.WriteLine("6. feladat:");

            Console.Write("\tAdjon meg egy járatszámot: ");
            string jaratszam = Console.ReadLine();

            if(!lista.Any(x => x.Jaratszam == jaratszam))
            {
                Console.WriteLine("\tNem létezik ilyen járat!");
            }

            //7. feladat

            Console.WriteLine("7. feladat:");

            List<string> keresett = new List<string>();

            foreach(var item in lista)
            {
                if (item.Jaratszam == jaratszam)
                {
                    keresett.Add(item.Jaratmegallonev);
                }
            }

            if(keresett.Count > 0)
            {
                int random = new Random().Next(0, keresett.Count);
                Console.WriteLine($"\tA {jaratszam} járat egyik megállója {keresett[random]}");
            }



















            Console.ReadKey(true);
        }
    }
}
