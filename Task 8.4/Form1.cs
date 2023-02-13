using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2;
            double result;
            Int32.TryParse(textBox1.Text, out number1);
            Int32.TryParse(textBox2.Text, out number2);

            if (radioButton1.Checked)
            {
                result = number1 % number2;
                textBox3.Text = result.ToString();
            }
            if (radioButton2.Checked)
            {
                result = Math.Pow(number1,number2);
                textBox3.Text = result.ToString();
            }
            if (radioButton3.Checked)
            {
                textBox3.Text = textBox1.Text + textBox2.Text;
            }
            if (radioButton4.Checked)
            {
                result = number1 / number2;
                textBox3.Text = result.ToString();
            }

        }
        
    }
}
