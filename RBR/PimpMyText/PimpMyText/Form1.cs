using System;
using System.Linq;
using System.Windows.Forms;

namespace PimpMyText
{
    public partial class Form1 : Form
    {
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
            this.txtOutput.Text = String.Join("", this.txtInput.Text.Select(c => c == ' ' ? " " : String.Format(s, NewColor(), c)).ToArray());
        }

        private string NewColor()
        {
            string n;

            do
            {
                n = this._Colors[Rand.Next(0, this._Colors.Length)];
            }
            while (n == _LastColor);

            _LastColor = n;
            return n;
        }
    }
}