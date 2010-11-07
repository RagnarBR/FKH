using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Beta_2010_02
{
    class Beta_2010_02
    {
        static void Main(string[] args)
        {
            string line = null;
            int teljari = 1, tala = 0;

            using (StreamReader reader = new StreamReader("tolur.txt"))
            {
                line = reader.ReadLine();
            }

            string[] tolur = line.Split(' ');

            for (int i = 0; i < tolur.Length; i++)
            {
                Console.Write(tolur[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < tolur.Length; i++)
            {
                Console.Write("{0}: {1} ", teljari, tolur[i]);
                teljari++;

                tala = Convert.ToInt32(tolur[i].ToString());

                for (int x = 0; x < tala; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
