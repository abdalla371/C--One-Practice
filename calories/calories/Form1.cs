using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaring variables
            double totalcalories, fat,numberCalories,percentage;
            //initialising variables
            totalcalories=int.Parse(textBoxCalories.Text);
            fat=int.Parse(textBoxFat.Text);
            //validating the input
            if (totalcalories < 0 || fat<0) {
                MessageBox.Show("Please enter number greater than 0");
                return;
            }
            //calculating number of calories
            numberCalories = fat * 9;
            //calculating percentage
             percentage=(numberCalories/ totalcalories)*100;
            //Validating Number of calories cannot greater than the total
            if (numberCalories > totalcalories)
            {
                MessageBox.Show("Number of calories cannot greater than the total");
                return;
            }
            //Checkboc lowfat
            if (percentage < 30)
            {
                checkBoxLowfat.Checked = true;
            }
            //Displaying the output

            labelFatgrams.Text = numberCalories.ToString();
            labelPercentage.Text = percentage.ToString();


        }

        private void labelPercentage_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
