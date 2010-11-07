using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bjarki
{
    class Program
    {
        static void Main(string[] args)
        {
            D1();

            Console.ReadLine();
        }

        static void D1()
        {
            Console.Write("Nafn: ");
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                Console.Write(" ");
            }
        }
    }
}