using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teglalap
{
    public partial class Form1 : Form
    {
        double a, b, ker, ter;
        bool oka = false;
        bool okb = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void aoldal_TextChanged(object sender, EventArgs e)
        {
            kerulet.Text = "";
            terulet.Text = "";
        }

        private void boldal_TextChanged(object sender, EventArgs e)
        {
            kerulet.Text = "";
            terulet.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oka = false;
            okb = false;
            if ((aoldal.Text != "") && (boldal.Text != ""))
            {
                try
                {
                    a = double.Parse(aoldal.Text);
                    if (a > 0) oka = true; 
                    else
                    {
                        oka = false;
                        MessageBox.Show("Az A oldal nem lehet negatív");
                    }
                }
                catch
                {
                    MessageBox.Show("Az A oldal nem szám");
                }
                try
                {
                    b = double.Parse(boldal.Text);
                    if (b > 0) okb = true;
                    else
                    {
                        okb = false;
                        MessageBox.Show("A B oldal nem lehet negatív");
                    }
                }
                catch
                {
                    MessageBox.Show("A B oldal nem szám");
                }
                if(oka && okb)
                {
                    ker = 2 * (a + b);
                    ter = a * b;
                    kerulet.Text = Convert.ToString(ker);
                    terulet.Text = Convert.ToString(ter);
                }
            }
            else
            {
                MessageBox.Show("Mindkét oldalt meg kell adni!");
            }
        }
    }
}
