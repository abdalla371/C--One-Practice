using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //creating values for food and prices
                string food1, food2;
                double price1, price2;

                food1 = txtboxfood1.Text;
                food2 = txtboxfood2.Text;
                price1 = double.Parse(txtboxprice1.Text);
                price2 = double.Parse(txtboxprice2.Text);

                double sum = price1 + price2;
                double salesText = sum * 0.07;
                double tips = sum * 0.15;

                double total = (sum + salesText) - tips;

                lblsalestext.Text = salesText.ToString("C");
                lblTips.Text = tips.ToString("C");
                lbltotal.Text = total.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for prices.");


            }
        }
    }
}
