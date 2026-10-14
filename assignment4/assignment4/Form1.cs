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
            string name, roomType;
            int age, numberOfNights, numberGuests;
            double ratePerNight, basicRoomCost, stayDiscount;
            double seniorDiscount, breakfastCost, surcharge, finalCost;

            // Get and validate input
            name = txtboxName.Text;

            if (
                !int.TryParse(txtboxAge.Text, out age) ||
                !int.TryParse(txtboxNofNights.Text, out numberOfNights) ||
                !int.TryParse(txtboxNofGuests.Text, out numberGuests))
            {
                MessageBox.Show("Please enter a valid name, age, nights and guests.");
                return;
            }

            // Validate age
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                return;
            }

            // Validate number of nights
            if (numberOfNights < 1 || numberOfNights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.");
                return;
            }

            // Validate number of guests
            if (numberGuests < 1 || numberGuests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.");
                return;
            }

            // Select room type and check capacity
            if (radioStandard.Checked)
            {
                roomType = "Standard Room";
                ratePerNight = 50;

                if (numberGuests > 2)
                {
                    MessageBox.Show("Standard Room allows a maximum of 2 guests.");
                    return;
                }
            }
            else if (radioNormal.Checked)
            {
                roomType = "Normal Room";
                ratePerNight = 80;

                if (numberGuests > 4)
                {
                    MessageBox.Show("Normal Room allows a maximum of 4 guests.");
                    return;
                }
            }
            else if (radioHigh.Checked)
            {
                roomType = "High Room";
                ratePerNight = 130;

                if (numberGuests > 6)
                {
                    MessageBox.Show("High Room allows a maximum of 6 guests.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            // Calculate basic room cost
            basicRoomCost = ratePerNight * numberOfNights;

            // Calculate stay discount
            stayDiscount = 0;

            if (numberOfNights >= 10)
            {
                stayDiscount = basicRoomCost * 0.12;
            }
            else if (numberOfNights >= 5)
            {
                stayDiscount = basicRoomCost * 0.05;
            }

            // Subtract stay discount
            double discountedRoomCost = basicRoomCost - stayDiscount;

            // Calculate surcharge for more than 4 guests
            surcharge = 0;

            if (numberGuests > 4)
            {
                surcharge = discountedRoomCost * 0.05;
            }

            // Calculate breakfast cost
            breakfastCost = 0;

            if (checkbocBreakfast.Checked)
            {
                breakfastCost = 10 * numberGuests * numberOfNights;
            }

            // Calculate subtotal before senior discount
            double subtotal = discountedRoomCost + surcharge + breakfastCost;

            // Calculate senior discount
            seniorDiscount = 0;

            if (age > 60)
            {
                seniorDiscount = subtotal * 0.05;
            }

            // Calculate final cost
            finalCost = subtotal - seniorDiscount;

            // Display booking details
          

            listBox1.Items.Add("HOTEL ROOM BOOKING");
            listBox1.Items.Add("------------------------------");
            listBox1.Items.Add("Booking Status: APPROVED");
            listBox1.Items.Add("Guest Name: " + name);
            listBox1.Items.Add("Guest Age: " + age);
            listBox1.Items.Add("Room Type: " + roomType);
            listBox1.Items.Add("Price Per Night: $" + ratePerNight.ToString("0.00"));
            listBox1.Items.Add("Number of Nights: " + numberOfNights);
            listBox1.Items.Add("Number of Guests: " + numberGuests);

            listBox1.Items.Add("Basic Room Cost: $" + basicRoomCost.ToString("0.00"));
            listBox1.Items.Add("Stay Discount: -$" + stayDiscount.ToString("0.00"));
            listBox1.Items.Add("Discounted Room Cost: $" + discountedRoomCost.ToString("0.00"));
            listBox1.Items.Add("Guest Surcharge: $" + surcharge.ToString("0.00"));
            
            listBox1.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("0.00"));
            listBox1.Items.Add("Senior Discount: -$" + seniorDiscount.ToString("0.00"));
            listBox1.Items.Add("------------------------------");
            listBox1.Items.Add("FINAL PRICE: $" + finalCost.ToString("0.00"));
        } }
}
