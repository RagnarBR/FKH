using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beta_2010_03
{
    class Beta_2010_03
    {
        static void Main(string[] args)
        {
            int c = 0, x = 0, stjarna = 0, tala = 0, afgangur = 0;

            Console.WriteLine("Sláðu inn tölu:");
            tala = Convert.ToInt32(Console.ReadLine());

            c = tala / 50;
            afgangur = tala % 50;
            x = afgangur / 10;
            afgangur = tala % 10;
            stjarna = afgangur / 1;

            while (stjarna > 0)
            {
                Console.Write("*");
                stjarna--;
            }

            while (x > 0)
            {
                Console.Write("X");
                x -= 1;
            }
            while (c > 0)
            {
                Console.Write("C");
                c -= 1;
            }

            //Console.WriteLine("C: {0}, X: {1}, *: {2}", c, x, stjarna);
            Console.ReadLine();
        }
    }
}
