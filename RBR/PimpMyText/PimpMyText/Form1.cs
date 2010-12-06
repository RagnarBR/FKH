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
        string[] colorStart = new string[] { @"[color=red]", @"[color=blue]", @"[color=cyan]", @"[color=green]", @"[color=black]", @"[color=pink]", @"[color=yellow]", @"[color=purple]", @"[color=pink]"};
        string colorEnd = @"[/color]";
        string temp = null;

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
                if (char.IsLetterOrDigit(textBox1.Text[i])) //r i = 0 
                {
                    for (int x = 0; x < textBox1.Text.Length; x++) //x = 0
                    {
                        if (x != i) 
                        {
                            temp += textBox1.Text[x]; 
                        }

                        else //x = i
                        {
                            temp += colorStart[0] + textBox1.Text[x] + colorEnd; //[color=red] + textBox1.Text[0] + [/color]
                        }
                    }
                }
            }

            textBox1.Text = temp;
        }
    }
}
