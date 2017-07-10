using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        double firstnumber=0, secondnumber=0, result = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            secondnumber  = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+': result =  firstnumber + secondnumber;
                    break;
                case '-':
                    result = firstnumber - secondnumber;
                    break;
                case '*':
                    result = firstnumber * secondnumber;
                    break;
                case '/':
                    result = firstnumber / secondnumber;
                    break;
            }
            textBox1.Text = result.ToString();
        }

        char znak = '+';

        private void button2_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();

        }
    }
}
