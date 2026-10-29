using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //importing the class
            StreamWriter outputFile;
            //opening the file
            outputFile = File.CreateText("output.txt");
            outputFile.WriteLine("Hello Ustad");
            outputFile.WriteLine("my name is Muhammad Ali");
            outputFile.WriteLine("I am a student");
            outputFile.WriteLine("At University of Jamhuriya");
            //closing the file
            outputFile.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //importing the class
            StreamReader inputFile;
            //opening the file
            inputFile = File.OpenText("output.txt");
            //reading the file
            string line;
            while (inputFile.EndOfStream==false)
            {
                line = inputFile.ReadLine();
                listBox1.Items.Add(line);
            }
            //closing the file
            inputFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            //opening the file
            inputFile = File.OpenText("output.txt");
            //closing the file
            inputFile.Close();
            //Deleting the file
            if (File.Exists("output.txt"))
            {
                File.Delete("output.txt");
                MessageBox.Show("File deleted successfully.");
            }
            else
            {
                MessageBox.Show("File not found.");
            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            //check if item is selected in the listbox
            if (listBox1.SelectedItem != null)
            {
                //remove the selected item from the listbox
                listBox1.Items.Remove(listBox1.SelectedItem);

                //convert the listbox items to a string array
                string[] lines = new string[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    lines[i] = listBox1.Items[i].ToString();
                }
                //write the updated lines back to the file
                File.WriteAllLines("output.txt", lines);
                MessageBox.Show("Selected item deleted successfully.");

            }
            else
            {
                MessageBox.Show("Please select an item to delete.");

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            string path = "output.txt";

            if (File.Exists(path))
            {
                // Read all lines into a string array
                string[] lines = File.ReadAllLines(path);

                // Display each line
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filePath = "output.txt";

            // Read the file into a byte array
            byte[] fileBytes = File.ReadAllBytes(filePath);

            listBox1.Items.Add($"Successfully read {fileBytes.Length} bytes.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filePath = "output.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                char[] buffer = new char[20]; // Buffer to hold up to 20 characters

                // Read up to 20 characters into the buffer
                int charsRead = sr.ReadBlock(buffer, 0, buffer.Length);

                // Convert the buffer segment to a string and print it
                string result = new string(buffer, 0, charsRead);
                listBox1.Items.Add(result);
            }
        }
    }
}
