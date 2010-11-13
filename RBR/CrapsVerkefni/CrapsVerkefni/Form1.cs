using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Craps
{
    public partial class Form1 : Form
    {
        //Breytti ImageSize í Properties á ImageList í stærðina á picture boxunum

        public Form1()
        {
            InitializeComponent();
        }

        Kast stuff = new Kast();
        int summa = 0, teljari = 0;
        Random rand = new Random();
        List<int> teningar = new List<int>();
        List<int> stig = new List<int>(); 

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (teljari > 0)
            {
                Clear();
            }

            teljari++;

            Roll(); 

            stuff.Checka(teningar, summa);

            if (stuff.Checka(teningar, summa)[0] == true)
            {
                pictureBoxTeningur1.Image = null;
                pictureBoxTeningur2.Image = null;

                summa = teningar[0] + teningar[1];
                labelVannedaTapadi.ForeColor = Color.Green; 
                labelVannedaTapadi.Text = "Þú vannst.";
            }

            else if (stuff.Checka(teningar, summa)[1] == true)
            {
                pictureBoxTeningur1.Image = null;
                pictureBoxTeningur2.Image = null;

                summa = teningar[0] + teningar[1];
                labelVannedaTapadi.ForeColor = Color.Red;
                labelVannedaTapadi.Text = "Þú tapaðir.";
            }

            else
            {
                summa = teningar[0] + teningar[1]; 
                groupBox1.Text = "Þetta eru stigin þín: " + summa;
                buttonPlay.Enabled = false;
                buttonRoll.Enabled = true;

                pictureBoxTeningur1.Image = imageList1.Images[teningar[0] - 1]; //Bætt við
                pictureBoxTeningur2.Image = imageList1.Images[teningar[1] - 1]; //Bætt við 
                stig = new List<int>(); 

                for (int i = 0; i < 2; i++)
                {
                    stig.Add(teningar[i]); 
                }
            }
        }

        public void Clear()
        {
            pictureBoxTeningur3.Image = null; //1 og 2
            pictureBoxTeningur4.Image = null;
            labelVannedaTapadi.Text = null;
            teningar = new List<int>();
            label1.Text = null; 
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            Roll();

            if (summa == stig.Sum())
            {
                labelVannedaTapadi.ForeColor = Color.Green;
                labelVannedaTapadi.Text = "Þú vannst.";

                buttonRoll.Enabled = false;
                buttonPlay.Enabled = true;
            }

            else if (summa == 7)
            {
                labelVannedaTapadi.ForeColor = Color.Red;
                labelVannedaTapadi.Text = "Þú tapaðir.";

                buttonRoll.Enabled = false;
                buttonPlay.Enabled = true;
            }
        }

        public void Roll()
        {
            Clear(); 

            stuff.Kasta(rand, teningar);
            summa = teningar[0] + teningar[1];

            /*for (int i = 0; i < teningar.Count; i++)
            {
                label1.Text += teningar[i];
            }
             * */

            pictureBoxTeningur3.Image = imageList1.Images[teningar[0] - 1]; //1 og 2
            pictureBoxTeningur4.Image = imageList1.Images[teningar[1] - 1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
