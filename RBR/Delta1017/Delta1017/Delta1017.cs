using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delta1017
{
    class Delta1017
    {
        static void Main(string[] args)
        {
            int linufjoldi = 0, dalkafjoldi = 0, l = 0;
            string lina = "|";
            Console.WriteLine("Línufjöldi:");
            linufjoldi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dálkafjöldi:");
            dalkafjoldi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < linufjoldi; i++)
            {
                if (i == 0)
                {
                    for (int x = 0; x < dalkafjoldi; x++)
                    {
                        Console.Write("x--");

                        if (x == (dalkafjoldi - 1))
                        {
                            Console.Write("x");
                        }
                    }

                    Console.WriteLine();
                }

                l = dalkafjoldi;
                lina = "|";
                while (l >= 0)
                {
                    
                    if (l == (dalkafjoldi - 1))
                    {
                        lina = "  " + "|";
                    }

                    Console.Write(lina);
                    l--;
                }
                Console.WriteLine();
                for (int y = 0; y < dalkafjoldi; y++)
                {
                    Console.Write("x--");

                    if (y == (dalkafjoldi - 1))
                    {
                        Console.Write("x");
                        Console.WriteLine();
                    }
                }
                
            }

            Console.ReadLine();
        }
    }
}
