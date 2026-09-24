using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating variables
            string dayofTheweek, nameofthemonth, numericdayOM, year,concat;
             dayofTheweek = dayOfWeektextbox.Text;
            nameofthemonth=monthtextbox.Text;
            numericdayOM=daymonthtextbox.Text;
            year= yeartextbox.Text;

            concat = dayofTheweek + "  " + nameofthemonth + "/" + numericdayOM + "/" + year;
            dateoutputlabel.Text = concat;

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            dayOfWeektextbox.Text = "";
            monthtextbox.Text = "";
            daymonthtextbox.Text = "";
            yeartextbox.Text = "";
            dateoutputlabel.Text = "";
        }
    }
}
