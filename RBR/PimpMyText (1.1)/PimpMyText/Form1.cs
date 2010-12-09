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
        bool itemSelected = false, newWord = false;

        //Breytti DropDownStyle úr Dropdown í DropDownList til þess að disablea writing í því

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPimpMyText_Click(object sender, EventArgs e)
        {
            itemSelected = false;

            if (comboBox1.Text == "After each character")
            {
                temp = null;
                itemSelected = true;
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (!char.IsWhiteSpace(textBox1.Text[i]))
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

                    else if (textBox1.Text[i] == ' ')
                    {
                        temp += ' ';
                    }

                    else if (textBox1.Text[i] == '\t')
                    {
                        temp += "\t";
                    }

                    else if (textBox1.Text[i] == '\n')
                    {
                        temp += '\n';
                    }
                }
            }

            else if (comboBox1.Text == "After each word")
            {
                temp = null;
                itemSelected = true;

                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    NextColor();
                    #region FortheFirstWord
                    if (i == 0) //Set color tag fyrir framan fyrsta orðið
                    {
                        temp += colorStart[currentColor];
                    }
                    #endregion 

                    if (!char.IsWhiteSpace(textBox1.Text[i]))//textBox1.Text[i] != ' ')
                    {
                        if (newWord)
                        {
                            temp += colorStart[currentColor];
                            newWord = false;
                        }
                        temp += textBox1.Text[i];
                    }

                    else if (textBox1.Text[i] == ' ')
                    {
                        temp += colorEnd; 
                        temp += ' ';
                        newWord = true;
                    }

                    else if (textBox1.Text[i] == '\t')
                    {
                        temp += colorEnd;
                        temp += "\t";
                        newWord = true; 
                    }

                    else if (textBox1.Text[i] == '\n')
                    {
                        temp += colorEnd; 
                        temp += '\n';
                        newWord = true; 
                    }

                  /*  else
                    {
                        temp += colorEnd; 
                        temp += ' ';
                        newWord = true;
                    }*/ 

                    #region FortheLastWord
                    if (i == (textBox1.Text.Length - 1))
                    {
                        temp += colorEnd;
                    }
                    #endregion 
                }

                textBox1.Text = temp;
            }

            else
            {
                MessageBox.Show("Please pick an item from the combobox.");
            } 

            

            if (itemSelected)
            {
                textBox1.Text = temp;
                textBox1.ReadOnly = true;
                buttonMorePimpin.Enabled = true;
                comboBox1.Enabled = false;
                buttonPimpMyText.Enabled = false;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ReadOnly = false;
            buttonMorePimpin.Enabled = false;
            comboBox1.Enabled = true;
            buttonPimpMyText.Enabled = true;
        }
    }
}
