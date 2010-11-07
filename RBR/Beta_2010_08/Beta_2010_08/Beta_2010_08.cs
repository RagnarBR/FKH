using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beta_2010_08
{
    class Beta_2010_08
    {
        static void Main(string[] args)
        {
            int hofudstoll = 0, sparnadur = 0, vextir = 0, ar = 0;

            Console.WriteLine("Upphafsupphæð:");
            hofudstoll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Árleg viðbót:");
            sparnadur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vextir:");
            vextir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fjöldi ára:");
            ar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ar; i++)
            {
                hofudstoll += (hofudstoll * vextir) / 100;

                if (i != 0)
                {
                    hofudstoll += sparnadur;
                }

                Console.WriteLine(hofudstoll);
            }
            Console.ReadLine();
        }
    }
}
