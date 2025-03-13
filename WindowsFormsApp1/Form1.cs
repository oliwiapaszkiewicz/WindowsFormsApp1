using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double value1, value2, result;
        string sign;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))  
            {
                textBox1.Text += ".";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "+";
            button1.Text = textBox1.Text + " " + sign;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "-";
            button1.Text = textBox1.Text + " " + sign;
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "*";
            button1.Text = textBox1.Text + " " + sign;
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "/";
            button1.Text = textBox1.Text + " " + sign;
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            sign = "%";
            button1.Text = textBox1.Text + " " + sign;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)  
        {
            value2 = Convert.ToDouble(textBox1.Text);
            button2.Text = textBox1.Text;  

            switch (sign)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    if (value2 != 0)
                        result = value1 / value2;
                    break;
                case "%":
                    result = value1 % value2;
                    break;
            }

            textBox1.Text = result.ToString();
            button1.Text = "";
            button2.Text = "";
        }
    }
}