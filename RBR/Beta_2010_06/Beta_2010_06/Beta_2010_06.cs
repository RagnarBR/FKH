using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beta_2010_06
{
    class Beta_2010_06
    {
        static void Main(string[] args)
        {
            int skammhlid = 0, teljari = 0;

            Console.WriteLine("Sláðu inn fjölda x í skammhlið þríhyrnings:");
            skammhlid = Convert.ToInt32(Console.ReadLine());

            teljari = skammhlid;

            for (int i = 0; i < skammhlid; i++)
            {
                for (int x = 0; x < teljari; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                teljari--;
            }

            Console.ReadLine();
        }
    }
}
