using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            //creating variables
            String name,department,showdata;
            //getting values from textboxes
            name = txtname.Text;
            int id = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            int semester = int.Parse(txtsemester.Text);
            //show the data
            showdata = "Name: " + name + "ID: " + id + "Department: " + department + "Semester: " + semester;
            lbloutput.Text = showdata;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtstudentid.Text = "";
            txtdepartment.Text = "";
            txtsemester.Text = "";
            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
