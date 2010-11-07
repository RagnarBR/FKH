using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpBag;
using SharpBag.Strings;
using SharpBag.IO;
using SharpBag.FK;
using SharpBag.Math;
using SharpBag.Math.Converters;
using System.IO;

namespace Bjarki
{
    class Program
    {
        static void Main(string[] args)
        {
            D2();

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

        static void D2()
        {
            string s = File.ReadAllText("D2.txt");

            int n = 1;
            s.Split(' ').Select(i => i.ToInt()).ForEach(i =>
                {
                    Console.Write(n++ + ": " + i + "\t");

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                });
        }
    }
}