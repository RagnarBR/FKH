using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beta_2010_01
{
    class Beta_2010_01
    {
        static void Main(string[] args)
        {
            string nafn = null, utkoma = null;

            Console.WriteLine("Sláðu inn nafn:", nafn);
            nafn = Console.ReadLine();

            for (int i = 0; i < nafn.Length; i++)
            {
                if (char.IsLetter(nafn[i]))
                {
                    utkoma += nafn[i] + " ";
                }
            }

            Console.WriteLine(utkoma);
            Console.ReadLine();
        }
    }
}
