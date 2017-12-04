using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            double valueOne = double.Parse(valueOneTextBox.Text);
            double valueTwo = double.Parse(valueTwoTextBox.Text);
            double result = valueOne + valueTwo;
            label1.Text = "+";
            resultLabel.Text = result.ToString();

        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            double valueOne = double.Parse(valueOneTextBox.Text);
            double valueTwo = double.Parse(valueTwoTextBox.Text);
            double result = valueOne - valueTwo;
            label1.Text = "-";
            resultLabel.Text = result.ToString();
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            double valueOne = double.Parse(valueOneTextBox.Text);
            double valueTwo = double.Parse(valueTwoTextBox.Text);
            double result = valueOne * valueTwo;
            label1.Text = "*";
            resultLabel.Text = result.ToString();
        }
    }
}
