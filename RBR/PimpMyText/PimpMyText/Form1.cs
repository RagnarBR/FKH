using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PimpMyText
{
    public partial class Form1 : Form
    {
        string[] colorStart = new string[] { @"[color=red]", @"[color=blue]", @"[color=cyan]", @"[color=green]", @"[color=black]", @"[color=pink]", @"[color=yellow]", @"[color=purple]"};
        string colorEnd = @"[/color]";
        string temp = null;
        Random rand = new Random();
        int currentColor = 0, previousColor = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPimpMyText_Click(object sender, EventArgs e)
        {
            temp = null;
            //temp = textBox1.Text; 

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] != ' ')
                {
                    for (int x = 0; x < textBox1.Text.Length; x++) //x = 0
                    {
                        if (x == i) //x = i
                        {
                            NextColor(); 
                            temp += colorStart[currentColor] + textBox1.Text[x] + colorEnd; //[color=red] + textBox1.Text[0] + [/color]
                        }
                    }
                }

                else
                {
                    temp += ' '; 
                }
            }

            textBox1.Text = temp;
        }

        public void NextColor()
        {
            bool useColor = false;

            while (useColor == false)
            {
                currentColor = rand.Next(0, (colorStart.Length - 1));

                if (currentColor == previousColor)
                {
                    useColor = false;
                }

                else
                {
                    useColor = true;
                }
            }
            previousColor = currentColor;
        }
    }
}
