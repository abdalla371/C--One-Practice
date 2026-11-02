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
                if(!double.TryParse(txtboxPrice.Text, out double price))
                {
                    MessageBox.Show("Please enter a valid numeric price.");
                    return;
                }
                if(price <= 0)
                {
                    MessageBox.Show("Please enter a valid price greater than zero.");
                    return;
                }
                if(listBox1.Items.Count >= 5)
                {
                    MessageBox.Show("You cannot add more than 5 courses.");
                    return;
                }
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("NO          CourseName           Price");
                }
                    //add courses and prices to the listbox
                    listBox1.Items.Add((txtboxNumber.Text)+"                  " + (txtboxCourseName.Text) + "                   $" + price.ToString());
                MessageBox.Show("Course added succeessfully");

                lblNumberRegCourses.Text = listBox1.Items.Count.ToString();
                txtboxCourseName.Text = "";
                txtboxPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. &Remove Course Button (Alt + R) - Cutubka 3.11
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Please select a course to delete");
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
                string id, studentName;
                id= textBoxId.Text;
                studentName = textBoxName.Text;
                if (!int.TryParse(textBoxAge.Text, out age))
                {
                    MessageBox.Show("Please enter a valid numeric age");
                    return;
                }
                if(age < 16|| age > 60)
                {
                    MessageBox.Show("You must be at least 16 and no more than 60 years old to register for courses.");
                    return;
                }
                if(id== "")
                {
                    MessageBox.Show("Please enter a valid ID");
                    return;
                }
                if(studentName == "")
                {
                    MessageBox.Show("Please enter a valid name");
                    return;
                }
                if(listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Please add at least one course before calculating the total price.");
                    return;
                }

                double basicFee = 0;
                int count = listBox1.Items.Count;
                int i = 0;
                //ina kaso dhexbaxsado priceka stringka gudaha
                while (i < count)
                {
                    //itemka la jogo ama indexka hadda la jogo qoralkisa ikeydi
                    string itemText = listBox1.Items[i].ToString();
                    //Indexkee ayuu ku jira xarafka dollar sign
                    int dollarsignIndex = itemText.IndexOf("$");
                    //hubi in xarafkas la heley hadii anan la helin wuxu so celin dona -1
                    if (dollarsignIndex != -1)
                    {
                        //ikeydi qoralka oo laso goyey
                        string priceText = itemText.Substring(dollarsignIndex + 1);
                        if(double.TryParse(priceText, out double price))
                        {
                            basicFee += price;
                        }
                    }
                    i++;
                }

                //xisabinta discountka
                double discount = 0;
                double scholarshipDiscount = 0;
                if (count == 2)
                {
                    discount = basicFee * 0.05;
                }
                else if (count == 3)
                {
                    discount = basicFee * 0.1;
                }
                else if (count == 4)
                {
                    discount = basicFee * 0.15;
                }
                //xisabinta checkboxka scholarship

                if (checkboxScholarship.Checked)
                {
                    scholarshipDiscount = basicFee * 0.2;
                }
                double  TotalFee = basicFee - discount - scholarshipDiscount;
                listBox2.Items.Clear();
                listBox2.Items.Add("STUDENT REGISTRATION RESULTS");
                listBox2.Items.Add("------------------------------------");
                listBox2.Items.Add("Student Name: " + textBoxName.Text);
                listBox2.Items.Add("Student ID: " + textBoxId.Text);
                listBox2.Items.Add("Number of courses: " + count);
                listBox2.Items.Add("Basic Fee: $" + basicFee.ToString("0.00"));
                listBox2.Items.Add("Course Discount: $" + discount.ToString("0.00"));
                listBox2.Items.Add("Scholarship Discount: $" + scholarshipDiscount.ToString("0.00"));
                listBox2.Items.Add("Final Fee: $" + TotalFee.ToString("0.00"));
                listBox2.Items.Add("Registration Status: Approved");


            }
            catch(Exception ex)
            {
                MessageBox.Show("Some weng wrong", ex.Message);
            }
           
        }

        // 4. C&lear Button (Alt + L) - Cutubka 2.1 / 3.11
        

        // 5. E&xit Button (Alt + X) - Cutubka 1.9 / 2.9
        
    }
}
