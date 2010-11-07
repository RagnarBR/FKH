using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beta_2010_07
{
    class Beta_2010_07
    {
        static void Main(string[] args)
        {
            Random teningur = new Random();

            bool fullthus = false;
            double teljari = 0, endurtekning = 0, utkoma = 0;

            do
            {
                fullthus = false;
                List<int> kast = new List<int>();

                endurtekning++;

                for (int i = 0; i < 5; i++)
                {
                    kast.Add(teningur.Next(1, 7));
                }

                kast.Sort();

                for (int i = 0; i < kast.Count; i++)
                {
                    Console.Write(kast[i]);
                }
                Console.WriteLine();

                if (kast[0] == kast[1] && kast[1] == kast[2] && kast[3] == kast[4])
                {
                    if (kast[3] != kast[2])
                    {
                        fullthus = true;
                    }
                }

                else if (kast[0] == kast[1] && kast[2] == kast[3] && kast[3] == kast[4])
                {
                    if (kast[1] != kast[2])
                    {
                        fullthus = true;
                    }
                }

                if (fullthus)
                {
                    Console.WriteLine("Fullt hús.");
                    teljari++;
                }

                else
                {
                    Console.WriteLine("Ekki fullt hús.");
                }
            } while (endurtekning < 100000);

            Console.WriteLine("{0}, {1}", teljari, endurtekning);
            utkoma = teljari / endurtekning;

            Console.WriteLine(utkoma);
            Console.ReadLine();
        }
    }
}
