using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simonasBlozisPS01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;
        double[] mas = new double[10];

        static bool typeCheck(String input)
        {
            int number;
            return int.TryParse(input, out number);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt1 = textBox1.Text;



            if (typeCheck(txt1))
            {
                richTextBox1.Clear();
                if (n < 10)
                {
                    mas[n] = Convert.ToDouble(txt1);

                    if (n == 9)
                    {
                        double sum = mas.Sum();
                        richTextBox1.Text = "suma = " + sum.ToString();
                    }
                    n++;
                    MessageBox.Show(" Tau dar liko " + (10 - n).ToString() + " ivesti ");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }


            }

            else
            {
                MessageBox.Show("ERROR");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt2 = textBox2.Text;



            if (typeCheck(txt2))
            {

                if (Convert.ToDouble(txt2) == 4)
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "   *";
                    richTextBox1.AppendText(Environment.NewLine + "  * *");
                    richTextBox1.AppendText(Environment.NewLine + " * * *");
                    richTextBox1.AppendText(Environment.NewLine + "* * * *");
                }

            }

            else
            {
                MessageBox.Show("ERROR");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
