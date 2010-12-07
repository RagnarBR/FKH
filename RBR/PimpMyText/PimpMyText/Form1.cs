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

        private void buttonPimpMyText_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string s = _Open + "{1}" + _Close;
            this.txtOutput.Text = String.Join("", this.txtInput.Text.Select(c => String.Format(s, this._Colors[r.Next(0, this._Colors.Length)], c)).ToArray());
        }
    }
}