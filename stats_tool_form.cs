using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics_Tool
{
    public partial class stats_tool_form : Form
    {
        double answer = 0;

        public stats_tool_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Initialize Fields
            average_result.ResetText();
            minimum_result.ResetText();
            maximum_result.ResetText();
            mode_result.ResetText();

            // Blank Data Field
            if (data.Text == "")
                MessageBox.Show("No Numbers Entered");

            else
            {
                try
                {
                    // Try Array For Format Exceptions
                    Double[] numbers = data.Text.Split(',').Select(s => Double.Parse(s)).ToArray();

                    // If The 'Average' Checkbox is Checked Run Average Calculation
                    if (average_checkbox.Checked)
                    {
                        double sum = 0;
                        int i = 0;
                        foreach (double num in numbers)
                        {
                            sum += num;
                            i++;
                        }
                        answer = sum / i;
                        average_result.Text = answer.ToString();
                    }

                    // If The 'Minimum' Checkbox is Checked Run Minimum Calculation
                    if (minimum_checkbox.Checked)
                    {
                        double min = double.MaxValue;
                        foreach (double num in numbers)
                        {
                            if (num < min)
                                min = num;
                        }
                        minimum_result.Text = min.ToString();
                    }

                    // If The 'Maximum' Checkbox is Checked Run Maximum Calculation
                    if (maximum_checkbox.Checked)
                    {
                        double max = 0;
                        foreach (double num in numbers)
                        {
                            if (num > max)
                                max = num;
                        }
                        maximum_result.Text = max.ToString();
                    }

                    // If The 'Mode' Checkbox is Checked Run Mode Calculation
                    if (mode_checkbox.Checked)
                    {
                        double mode = -1;
                        double selection;
                        int numCounter;
                        int modeCounter = 0;
                        foreach (double num in numbers)
                        {
                            numCounter = 0;
                            selection = num;
                            foreach (double num2 in numbers)
                            {
                                if (num2 == selection)
                                    numCounter++;
                            }
                            if (numCounter > modeCounter)
                            {
                                mode = num;
                                modeCounter = numCounter;
                            }

                        }
                        mode_result.Text = mode.ToString();
                    }
                }

                // Catch if an Exception is Thrown
                catch (System.FormatException)
                {
                    MessageBox.Show("Incorrect Input, Make Sure to Seprate Numbers With Commas");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Clear Button Press
        private void clear_button_Click(object sender, EventArgs e)
        {
            // Reset All Forms
            average_result.ResetText();
            minimum_result.ResetText();
            maximum_result.ResetText();
            mode_result.ResetText();

            average_checkbox.Checked = false;
            minimum_checkbox.Checked = false;
            maximum_checkbox.Checked = false;
            mode_checkbox.Checked = false;

            data.ResetText();
        }
    }
}
