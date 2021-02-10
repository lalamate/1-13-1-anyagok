using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haromszog
{
    public partial class Form1 : Form
    {
        double a, b, c, s, ker, ter;

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

        private void coldal_TextChanged(object sender, EventArgs e)
        {
            kerulet.Text = "";
            terulet.Text = "";
        }

        bool aok = false;
        bool bok = false;
        bool cok = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aok = false;
            bok = false;
            cok = false;
            if((aoldal.Text!="")&& (boldal.Text != "")&& (coldal.Text != ""))
            {
                try
                {
                    a = Convert.ToDouble(aoldal.Text);
                    if(a<0)
                    {
                        MessageBox.Show("Az A oldal nem lehet negatív!");
                        aok = false;
                    }
                    else
                    {
                        aok = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Az A oldal nem szám!");
                }
                try
                {
                    b = Convert.ToDouble(boldal.Text);
                    if (b < 0)
                    {
                        MessageBox.Show("A B oldal nem lehet negatív!");
                        bok = false;
                    }
                    else
                    {
                        bok = true;
                    }
                }
                catch
                {
                    MessageBox.Show("A B oldal nem szám!");
                }
                try
                {
                    c = Convert.ToDouble(coldal.Text);
                    if (c < 0)
                    {
                        MessageBox.Show("A C oldal nem lehet negatív!");
                        cok = false;
                    }
                    else
                    {
                        cok = true;
                    }
                }
                catch
                {
                    MessageBox.Show("A C oldal nem szám!");
                }
                if(aok && bok && cok)
                {
                    if((a+b)<=c || (a+c)<=b || (b+c)<=a)
                    {
                        MessageBox.Show("Nem lehet háromszöget szerkeszteni a megadott adatokból!");
                    }
                    else
                    {
                        ker = a + b + c;
                        s = ker / 2;
                        ter = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                        kerulet.Text = Convert.ToString(Math.Round(ker,2));
                        terulet.Text = Convert.ToString(Math.Round(ter, 2));
                    }
                }
            }
            else
            {
                MessageBox.Show("Mindhárom oldalt meg kell adni!");
            }

        }
    }
}
