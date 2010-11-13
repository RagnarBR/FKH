using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Craps
{
    public class Kast : Form
    {

        public void Kasta(Random rand, List<int> teningar)
        {
            for (int i = 0; i < 2; i++)
            {
                teningar.Add(rand.Next(1, 7)); 
            }
        }

        public bool[] Checka(List<int> teningar, int summa)
        {
            bool[] check = new bool[2];

            if (summa == 7 || summa == 11)
            {
                check[0] = true; 
            }

            else if (summa == 2 || summa == 3 || summa == 12)
            {
                check[1] = true;
            }

            return check;
        }
    }
}
