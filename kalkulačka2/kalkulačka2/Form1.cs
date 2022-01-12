using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulačka2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int prvnicislo;
                prvnicislo = int.Parse(textBox1.Text);
                int druhecislo;
                druhecislo = int.Parse(textBox2.Text);
                if (radioButton1.Checked)
                {
                    int vysledek;
                    vysledek = prvnicislo + druhecislo;
                    MessageBox.Show("vysledek je:" + vysledek);
                }
                if (radioButton2.Checked)
                {
                    int vysledek;
                    vysledek = prvnicislo - druhecislo;
                    MessageBox.Show("vysledek je:" + vysledek);
                }
                if (radioButton3.Checked)
                {
                    int vysledek;
                    vysledek = prvnicislo * druhecislo;
                    MessageBox.Show("vysledek je:" + vysledek);
                }
                if (radioButton4.Checked)
                {
                    double vysledek;
                    if(druhecislo != 0)
                    {
                        vysledek = prvnicislo / druhecislo;
                        MessageBox.Show("vysledek je:" + vysledek);
                    }
                    else
                    {
                        MessageBox.Show("nejde delit nulou");
                    }
                }
                if (radioButton5.Checked)
                {
                    int vysledek;
                    vysledek = prvnicislo % druhecislo;
                    MessageBox.Show("vysledek je:" + vysledek);
                }
            } catch (Exception)
            {
                MessageBox.Show("neco nefunguje");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
