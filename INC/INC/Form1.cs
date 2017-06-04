using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace INC
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String majorString;
                String name = richTextBox1.Text;
                int ID = Convert.ToInt32(richTextBox2.Text);

                bool computerProgrammer = radioButton1.Checked;
                bool electronicsEngineer = radioButton2.Checked;
                bool technician = radioButton3.Checked;

                int dependents = Convert.ToInt32(richTextBox4.Text);
                double Hours = Convert.ToDouble(richTextBox3.Text);

                double socialS = 0.06;
                double fedTax = 0.14;
                double provTax = 0.05;
                double unionFee = 25;
                double totalD;

                double grossPay;
                double netPay;

                double cpRate = 35.50;
                double eeRate = 40.25;
                double techRate = 37.50;



                // HOURS LESS THEN 40
                if (Hours <= 40)
                {
                    if (computerProgrammer == true)
                    {
                        if (dependents > 3)
                        {
                            dependents = dependents * 15;
                        }
                        else
                        {
                            dependents = 50;
                        }
                        grossPay = (cpRate * Hours);
                        socialS = grossPay * socialS;
                        fedTax = grossPay * fedTax;
                        provTax = grossPay * provTax;
                        netPay = grossPay - socialS - fedTax - provTax - unionFee - dependents;

                        majorString = ("Name: " + name + " Work ID: " + ID + " Gross Pay: $" + grossPay + " Social Security: $" + socialS + " Federal Tax: $" + fedTax + " Provincal Tax: $" + provTax + " Union Fee: $" + unionFee + " Depedents: $" + dependents + " Net pay: $" + netPay);
                        using (StreamWriter writer = File.AppendText("team.txt"))
                            writer.WriteLine(majorString);
                    }

                    if (electronicsEngineer == true)
                    {
                        if (dependents > 3)
                        {
                            dependents = dependents * 15;
                        }
                        else
                        {
                            dependents = 50;
                        }
                        grossPay = (eeRate * Hours);
                        socialS = grossPay * socialS;
                        fedTax = grossPay * fedTax;
                        provTax = grossPay * provTax;
                        netPay = grossPay - socialS - fedTax - provTax - unionFee - dependents;

                        majorString = ("Name: " + name + " Work ID: " + ID + " Gross Pay: $" + grossPay + " Social Security: $" + socialS + " Federal Tax: $" + fedTax + " Provincal Tax: $" + provTax + " Union Fee: $" + unionFee + " Dependents: " + dependents + " Net pay: $" + netPay);
                        using (StreamWriter writer = File.AppendText("team.txt"))
                            writer.WriteLine(majorString);
                    }

                    if (technician == true)
                    {
                        if (dependents > 3)
                        {
                            dependents = dependents * 15;
                        }
                        else
                        {
                            dependents = 50;
                        }
                        grossPay = (techRate * Hours);
                        socialS = grossPay * socialS;
                        fedTax = grossPay * fedTax;
                        provTax = grossPay * provTax;
                        netPay = grossPay - socialS - fedTax - provTax - unionFee - dependents;

                        majorString = ("Name: " + name + " Work ID: " + ID + " Gross Pay: $" + grossPay + " Social Security: $" + socialS + " Federal Tax: $" + fedTax + " Provincal Tax: $" + provTax + " Union Fee: $" + unionFee + " Dependents: $" + dependents + " Net pay: $" + netPay);
                        using (StreamWriter writer = File.AppendText("team.txt"))
                            writer.WriteLine(majorString);
                    }
                }
                // HOURS GREATER THEN 40
                else if (Hours > 40)
                {
                    if (computerProgrammer == true)
                    {
                        if (dependents > 3)
                        {
                            dependents = dependents * 15;
                        }
                        else
                        {
                            dependents = 50;
                        }
                        grossPay = (cpRate * Hours) + (cpRate * (Hours - 40 * 1.5));
                        socialS = grossPay * socialS;
                        fedTax = grossPay * fedTax;
                        provTax = grossPay * provTax;
                        netPay = grossPay - socialS - fedTax - provTax - unionFee - dependents;


                        majorString = ("Name: " + name + " Work ID: " + ID + " Gross Pay: $" + grossPay + " Social Security: $" + socialS + " Federal Tax: $" + fedTax + " Provincal Tax: $" + provTax + " Union Fee: $" + unionFee + " Depedents: $" + dependents + " Net pay: $" + netPay);
                        using (StreamWriter writer = File.AppendText("team.txt"))
                            writer.WriteLine(majorString);
                    }

                    if (electronicsEngineer == true)
                    {
                        if (dependents > 3)
                        {
                            dependents = dependents * 15;
                        }
                        else
                        {
                            dependents = 50;
                        }
                        grossPay = (eeRate * Hours) + (100 * Hours - 40);
                        socialS = grossPay * socialS;
                        fedTax = grossPay * fedTax;
                        provTax = grossPay * provTax;
                        netPay = grossPay - socialS - fedTax - provTax - unionFee - dependents;

                        majorString = ("Name: " + name + " Work ID: " + ID + " Gross Pay: $" + grossPay + " Social Security: $" + socialS + " Federal Tax: $" + fedTax + " Provincal Tax: $" + provTax + " Union Fee: $" + unionFee + " Dependents: $" + dependents + " Net pay: " + netPay);
                        using (StreamWriter writer = File.AppendText("team.txt"))
                            writer.WriteLine(majorString);
                    }

                    if (technician == true)
                    {
                        if (dependents > 3)
                        {
                            dependents = dependents * 15;
                        }
                        else
                        {
                            dependents = 50;
                        }
                        grossPay = (techRate * Hours) + (techRate * (Hours - 40 * 1.5));
                        socialS = grossPay * socialS;
                        fedTax = grossPay * fedTax;
                        provTax = grossPay * provTax;
                        netPay = grossPay - socialS - fedTax - provTax - unionFee - dependents;

                        majorString = ("Name: " + name + " Work ID: " + ID + " Gross Pay: $" + grossPay + " Social Security: $" + socialS + " Federal Tax: $" + fedTax + " Provincal Tax: $" + provTax + " Union Fee: $" + unionFee + " Dependents: $" + dependents + " Net pay: $" + netPay + "\n");
                        using (StreamWriter writer = File.AppendText("team.txt"))
                            writer.WriteLine(majorString);
                    }


                } // Else statement ends here! 
                MessageBox.Show("Added Check the Text File: team");
            }
            catch
            {
                MessageBox.Show("Please make sure ID, Hours and Dependents are numeric.");
            }
           

        } // Button ends here 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
