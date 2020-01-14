using System;
using System.Collections.Generic;
using System.IO;

namespace CA20200114
{
    class Program
    {
        static List<Jatekos> jatekosok;
        static int forduloIndex;
        static void Main()
        {
            F2();
            F3();
            F4();
            F5();
            Console.ReadKey();
        }

        private static void F2()
        {
            jatekosok = new List<Jatekos>();
            var sr = new StreamReader(@"..\..\Forras\egyszamjatek1.txt");

            while (!sr.EndOfStream)
                jatekosok.Add(new Jatekos(sr.ReadLine()));
            sr.Close();
        }

        private static void F3()
        {
            Console.Write("3. feladat: ");

            Console.Write("Játékosok száma: ");
            Console.WriteLine($"{jatekosok.Count} fő");
        }

        private static void F4()
        {
            Console.Write("4. feladat: ");

            Console.Write("Kérem a forduló sorszámát: ");
            forduloIndex = int.Parse(Console.ReadLine()) - 1;
        }

        private static void F5()
        {
            Console.Write("5. feladat: ");

            int sum = 0;
            foreach (var j in jatekosok)
                sum += j.Tippek[forduloIndex];

            Console.Write(
                "Megadott fordulóban a tippek átlaga: {0:0.00}",
                sum / (float)jatekosok.Count);
        }
    }
}
