using System;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. &Add Course Button (Alt + A) - Cutubka 2.11 / 3.11
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double serviceCost;

                //validate serviceCost
                if(!double.TryParse(txtboxPrice.Text, out serviceCost))
                {
                    MessageBox.Show("Please enter a valid numberic Service cost");
                    return;
                }
                if (serviceCost <= 0)
                {
                    MessageBox.Show("Please enter cost that is greater than zero");
                    return;
                }
                if (listBox1.Items.Count > 5)
                {
                    MessageBox.Show("Only Maximum 5 courses are allowed");
                    return;
                }
                int count = listBox1.Items.Count;
                int i = 0;
                while (i < count)
                {
                    string currentItem = listBox1.Items[i].ToString();
                    if (currentItem.Contains(txtboxServiceName.Text))
                    {
                        MessageBox.Show("this service has been registered");
                        return;
                    }
                    i++;
                }
                listBox1.Items.Add((txtboxNumber.Text)+"     " +(txtboxServiceName.Text)+  "       $" + serviceCost);

                lblNumberRegCourses.Text = listBox1.Items.Count.ToString();

                txtboxNumber.Text = "";
                txtboxPrice.Text = "";
                txtboxServiceName.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something weng wrong" + ex.Message);
            }
        }

        // 2. &Remove Course Button (Alt + R) - Cutubka 3.11
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(listBox1.SelectedIndex == -1)) {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Please select an item to delete");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Waxbaa khaldamey during removing" + ex.Message);
            }
           
        }
       
        // 3. &Calculate Button (Alt + C) - Cutubka 4.1 (While Loop) iyo 3.11
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int age;
                string patientName, patientID;
                patientName = textBoxName.Text;
                patientID = textBoxId.Text;
                if(!int.TryParse(textBoxAge.Text, out age))
                {
                    MessageBox.Show("Please input a valid numeric age data");
                    return;
                }
                if (age < 1 || age > 110)
                {
                    MessageBox.Show("AGE must be in betweeen 1-110");
                    return;
                }
                if (patientID == "")
                {
                    MessageBox.Show("Please enter patient ID");
                    return;
                }
                if (patientName == "")
                {
                    MessageBox.Show("Please enter patient Name");
                    return;
                }
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("At least one service must be registered");
                    return;
                }
                //subtotal
                double subtotal = 0;
                int count = listBox1.Items.Count;
                int i = 0;
                //loop
                while (i < count)
                {
                    string currentItem = listBox1.Items[i].ToString();
                    int dollarSign = currentItem.IndexOf("$");
                    if (dollarSign != -1)
                    {
                        String serviceCostText = currentItem.Substring(dollarSign + 1);
                        if(double.TryParse(serviceCostText, out double serviceCost))
                        {
                            subtotal += serviceCost;
                        }
                    }
                    
                    i++;
                }
                //discount
                double discount = 0;
                if (count == 2)
                {
                    discount = subtotal * 0.05;
                }
                else if (count == 3 || count == 4)
                {
                    discount = subtotal * 0.10;
                }
                else if (count == 5)
                {
                    discount = subtotal * 0.15;
                }
                //insurance
                double insurance = 0;
                if (checkboxScholarship.Checked)
                {
                    insurance = subtotal * 0.3;
                }
                double totalCost = subtotal - discount - insurance;
                //displaying
                listBox2.Items.Clear();
                listBox2.Items.Add("Hospital REGISTRATION RESULTS");
                listBox2.Items.Add("------------------------------------");
                listBox2.Items.Add("Patient Name: " + textBoxName.Text);
                listBox2.Items.Add("Patient ID: " + textBoxId.Text);
                
                listBox2.Items.Add("Number of services: " + count);
                listBox2.Items.Add("Basic Fee: $" + subtotal.ToString("0.00"));
                listBox2.Items.Add("service Discount: $" + discount.ToString("0.00"));
                listBox2.Items.Add("Insurance Discount: $" + insurance.ToString("0.00"));
                listBox2.Items.Add("Final Cost: $" + totalCost.ToString("0.00"));
                listBox2.Items.Add("Registration Status: Approved");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Some weng wrong", ex.Message);
            }
           
        }

        // 4. C&lear Button (Alt + L) - Cutubka 2.1 / 3.11
        

        // 5. E&xit Button (Alt + X) - Cutubka 1.9 / 2.9
        
    }
}
