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
            D4();

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

        static void D3()
        {
            Console.Write("Tala: ");
            int t = Console.ReadLine().ToInt();

            int c = t / 50;
            t %= 50;

            int x = t / 10;
            t %= 10;

            int s = t;

            Console.WriteLine(new String('*', s) + new String('X', x) + new String('C', c));
        }

        static void D4()
        {
            Console.Write("Fyrsta tala? ");
            int f = Console.ReadLine().ToInt();

            Console.Write("Síðasta tala? ");
            int s = Console.ReadLine().ToInt();

            Console.Write("Veldi ");
            int v = Console.ReadLine().ToInt();

            Console.WriteLine("Niðurstaða: " + f.To(s).Sum(i => Math.Pow(i, v)));
        }
    }
}