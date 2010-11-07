using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beta_2010_04
{
    class Beta_2010_04
    {
        static void Main(string[] args)
        {
            int fyrstatala = 0, sidastatala = 0, veldi = 0, utkoma = 0;

            Console.WriteLine("Fyrsta tala:");
            fyrstatala = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Síðasta tala:");
            sidastatala = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veldi:");
            veldi = Convert.ToInt32(Console.ReadLine());

            for (int i = fyrstatala; i <= sidastatala; i++)
            {
                utkoma += (int)Math.Pow(i, veldi);
            }

            Console.WriteLine("Útkoman er {0}", utkoma);
            Console.ReadLine();
        }
    }
}
