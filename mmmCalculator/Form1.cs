using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmmCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double number1 { get; set; } = 0;
        private double number2 { get; set; } = 0;
        private string action { get; set; } = "";

        private double res = 0;

        private void MyClick(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }
        private void PXClick(object sender, EventArgs e)
        {
            action = ((Button)sender).Text;
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }
        private void XYUClick(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            switch (action)
            {
                case "+":
                    res = number1 + number2;
                    break;
                case "-":
                    res = number1 - number2;
                    break;
                case "/":
                    res = number1 / number2;
                    break;
                case "*":
                    res = number1 * number2;
                    break;
            }
            textBox1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            res = 0;
            number1 = 0;
            number2 = 0;
        }
    }
}
