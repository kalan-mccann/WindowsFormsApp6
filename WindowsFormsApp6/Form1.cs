using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp6
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
                //variable declarations
                double Atoms, Cells, Subtotal, Tax, Total;
                double TaxRate = 0.13;
                double Atompricerate = 283;
                double Cellpricerate = 500;



                //get inputs
                Atoms = Convert.ToDouble(textBox1.Text);
                Cells = Convert.ToDouble(textBox2.Text);

                //do calculations
                Subtotal = Atoms * Atompricerate + Cells * Cellpricerate;
                Tax = Subtotal * TaxRate;
                Total = Tax + Subtotal;

                //output
                Recipet.Text  += $"Your subtotal is {Subtotal.ToString("$.00")}";
                Refresh();
                Thread.Sleep(80);
                Recipet.Text += $"\n__________________________________";
                Refresh();
                Thread.Sleep(80);
                Recipet.Text += $"\nYour TaxRate is";
                Refresh();
                Thread.Sleep(800);
                Recipet.Text += $"\n${Tax}";
                Refresh();
                Thread.Sleep(800);
                Recipet.Text += $"\n__________________________________";
                Refresh();
                Thread.Sleep(800);
                Recipet.Text += $"\n your Total is";
                Refresh();
                Thread.Sleep(8000);
                Recipet.Text += $"\n{Total.ToString("C")}";
                Refresh();
                Thread.Sleep(8000);
                Recipet.Text += $"\n +----Thank you have a nice day----+";
                Refresh();
                Thread.Sleep(10000)
                //Recipet.Text = $"{Total.ToString("C")}";

            ;}
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
                Recipet.Text = $"your total is";
                // temp message
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Recipet.Text = $"Its in the walls";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
