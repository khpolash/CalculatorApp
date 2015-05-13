using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator aCalculator = new Calculator();
        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text!="" && secondNumberTextBox.Text!="")
            {
                aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                resulrtTextBox.Text = Convert.ToString(aCalculator.Add(aCalculator.firstNumber, aCalculator.secondNumber));
            }
            else
            {
                MessageBox.Show("Please enter First & Second Number");
            }
           
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resulrtTextBox.Text = Convert.ToString(aCalculator.Sub(aCalculator.firstNumber, aCalculator.secondNumber));
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resulrtTextBox.Text = Convert.ToString(aCalculator.Mul(aCalculator.firstNumber, aCalculator.secondNumber));
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resulrtTextBox.Text = Convert.ToString(aCalculator.Div(aCalculator.firstNumber, aCalculator.secondNumber));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            resulrtTextBox.Clear();
        }
    }
}
