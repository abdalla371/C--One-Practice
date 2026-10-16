using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaring variables;
            string name, travelClass;
            int passengerAge, numberOfTickets;
            double buggageWeight, discount, childDiscount, seniorDiscount, insurance, travelClassPrice, basicTicketCost;
            //inialising the variable name and also initialising some variables with texbox input
            name=txtboxName.Text;
            //validating numeric data input
            if (!int.TryParse(txtboxAge.Text, out passengerAge)||
                !int.TryParse(txtboxNofTickets.Text, out numberOfTickets) ||
                !double.TryParse(txtboxWeight.Text, out buggageWeight) )
            {
                MessageBox.Show("Please input a numeric data");
                return;
            }
            //validate age
            if(passengerAge < 1 || passengerAge>100)
            {
                MessageBox.Show("Age must be between 1 and 100");
                return;
            }
            //validate number of tickets
            if (numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5");
                return;
            }
            //validate buggage weight
            if (buggageWeight <=0 || buggageWeight > 50)
            {
                MessageBox.Show("Buggage weight cannot be negative and cannot exceed 50");
                return;
            }
            //select travel class
            if (radioFirst.Checked)
            {
                travelClass = "First class";
                travelClassPrice = 500;
                
                if (passengerAge < 12)
                {
                    MessageBox.Show("Passenger below 12 cannot book first class");
                    listBox1.Items.Add("Booking rejected");
                    return;
                }
            }
           
            else if (radioNormal.Checked)
            {
                travelClass = "Normal class";
                travelClassPrice = 200;
            }
            else if (radioBusiness.Checked)
            {
                travelClass = "Business class";
                travelClassPrice = 350;
            }

            else
            {
                MessageBox.Show("Please select a travel class");
                return;
            }
            //calculating basic ticket cost
            basicTicketCost = travelClassPrice * numberOfTickets;
            //calculating ticket discounts
            discount = 0;
            if(numberOfTickets>=3 && numberOfTickets <= 4)
            {
                discount = 0.05 * basicTicketCost;

            }
            else if (numberOfTickets == 5)
            {
                discount = 0.1 * basicTicketCost;

            }
            //calculating cost after ticket discount
            double subTotal = basicTicketCost - discount;
            //calculating child and senior discount
            childDiscount = 0;
            if (passengerAge < 12)
            {
                childDiscount = 0.2 * subTotal;
            }
            seniorDiscount = 0;
            if(passengerAge >=60)
            {
                seniorDiscount = 0.1 * subTotal;
            }

            insurance = 0;
            if (checkbocInsurance.Checked)
            {
                insurance=25* numberOfTickets;
            }
            //final cost calculation
            double finalCost = subTotal - childDiscount - seniorDiscount + insurance;

            //displaying the output in the listbox
            listBox1.Items.Clear();
            listBox1.Items.Add("Passenger Name: " + name);
            listBox1.Items.Add("Passenger Age: " + passengerAge);
            listBox1.Items.Add("Travel Class: " + travelClass);
            listBox1.Items.Add("Number of Tickets: " + numberOfTickets);
            listBox1.Items.Add("Buggage Weight: " + buggageWeight + " kg");
            listBox1.Items.Add("Basic Ticket Cost: $" + basicTicketCost);
            listBox1.Items.Add("Ticket Discount: $" + discount);
            listBox1.Items.Add("Child Discount: $" + childDiscount);
            listBox1.Items.Add("Senior Discount: $" + seniorDiscount);
            listBox1.Items.Add("Insurance: $" + insurance);
            listBox1.Items.Add("Final Cost: $" + finalCost);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clearing the listbox, texbox etc
            listBox1.Items.Clear();
            txtboxName.Text = "";
            txtboxAge.Text = "";
            txtboxNofTickets.Text = "";
            txtboxWeight.Text = "";

            radioBusiness.Checked = false;
            radioFirst.Checked = false;
            radioNormal.Checked = false;
            checkbocInsurance.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //closing the file
            Application.Exit();
            
        }
    }
}
