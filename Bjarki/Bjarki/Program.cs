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
            D1B();

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

        static void D1B()
        {
            Console.Write("Nafn: ");
            string s = Console.ReadLine();

            Console.WriteLine(String.Join(" ", s.ToCharArray()));
        }
    }
}