using System;
using System.Linq;
using System.Windows.Forms;

namespace PimpMyText
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        string[] colorStart = new string[] { @"[color=red]", @"[color=blue]", @"[color=cyan]", @"[color=green]", @"[color=black]", @"[color=pink]", @"[color=yellow]", @"[color=purple]"};
        string colorEnd = @"[/color]";
        string temp = null;
        Random rand = new Random();
        int currentColor = 0, previousColor = 100;

=======
>>>>>>> 2e7af0ee34f3f638b4693d6a0c44c511bdf6c428
        public Form1()
        {
            InitializeComponent();
        }

        private const string _Open = "[color={0}]";
        private const string _Close = "[/color]";
        private readonly string[] _Colors = new[] { "red", "blue", "cyan", "green", "black", "yellow", "pink", "purple" };
        private string _LastColor;
        private readonly Random Rand = new Random();

        private void ButtonPimpMyTextClick(object sender, EventArgs e)
        {
            const string s = _Open + "{1}" + _Close;
            this.txtOutput.Text = String.Join("", this.txtInput.Text.Select(c => Char.IsWhiteSpace(c) ? c : String.Format(s, NewColor(), c)).ToArray());
        }

        private string NewColor()
        {
            string n;

            do
            {
<<<<<<< HEAD
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
=======
                n = this._Colors[Rand.Next(0, this._Colors.Length)];
>>>>>>> 2e7af0ee34f3f638b4693d6a0c44c511bdf6c428
            }
            while (n == _LastColor);

            _LastColor = n;
            return n;
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
