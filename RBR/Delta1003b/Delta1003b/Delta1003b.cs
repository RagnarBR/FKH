using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delta1003b
{
    class Delta1003b
    {
        static void Main(string[] args)
        {
            string[] dagshlutar = new string[] { "miðnætti", "ótta", "rismál", "dagmál", "hádegi", "nón", "miðaftan", "náttmál" };
                                               //0, 1, 2     3,4,5    6,7,8     9, 10,11 12,13,14  15,16,17 18,19,20   21,22,23
            int klst = 0, min = 0, teljari = 0;

            Console.WriteLine("Hvaða klukkustund er:");
            klst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvaða mínúta:");
            min = Convert.ToInt32(Console.ReadLine());

            teljari = klst / 3;
              

            Console.WriteLine(dagshlutar[teljari]);
            Console.ReadLine();

        }
    }
}
