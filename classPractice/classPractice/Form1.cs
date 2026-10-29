using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name, Gender;
            int age, validation;
            String faculty = string.Empty;
            if(int.TryParse(txtboxAge.Text, out validation))
            {
                name=txtboxname.Text;
                age=int.Parse(txtboxAge.Text);
                if (age > 0)
                {
                    if (male.Checked)
                    {
                        Gender = "Male\n";
                        listBox1.Items.Add(Gender);
                    }
                    else if (female.Checked) {
                        Gender = "Female\n";
                        listBox1.Items.Add(Gender);

                    }
                    else { MessageBox.Show("Please choose A gender"); }

                    //faculty
                    if (Computer.Checked && IT.Checked && business.Checked) {
                        faculty += "Computer\n" + ", " + "IT" + " and " + "Business";
                        listBox1.Items.Add (faculty);
                    }
                    else if(Computer.Checked & IT.Checked)
                    {
                        faculty += "Computer\n" + " and  " + "IT";
                        listBox1.Items.Add(faculty);
                    }
                    else if(IT.Checked && business.Checked)
                    {
                        faculty += "IT\n" + " and " + "Business\n";
                        listBox1.Items.Add(faculty);
                    }
                    else if(Computer.Checked && business.Checked)
                    {
                        faculty += "Computer\n" + " and " + "Business";
                        listBox1.Items.Add(faculty);
                    }
                    else if (Computer.Checked)
                    {
                        faculty += "Computer\n" ;
                        listBox1.Items.Add(faculty);
                    }
                    else if (IT.Checked)
                    {
                        faculty += "IT\n";
                        listBox1.Items.Add(faculty);
                    }
                    else if (business.Checked)
                    {
                        faculty += "Busines\n";
                        listBox1.Items.Add(faculty);
                    }
                    else { MessageBox.Show("Please select a faculty"); }
                }
                else
                {
                    MessageBox.Show("Age  mustbe more than 0");
                }
            }
            else
            {
                MessageBox.Show("Age must be a numeric data!");
            }
        }
    }
}
