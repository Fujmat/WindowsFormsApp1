using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string sign;
        string count;
        double count2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 8;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 3;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 5;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 9;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 0;
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)//C
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)//←
        {
            
            int x1 = 0;
            x1 = textBox1.Text.Length - 1;
            textBox1.Text = textBox1.Text.Substring(0, x1);
        }

        private void button28_Click(object sender, EventArgs e)//+
        {
            sign = "+";
            count = textBox1.Text; 
            textBox1.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sign = "-";
            count = textBox1.Text;
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sign = "*";
            count = textBox1.Text;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sign = "/";
            count = textBox1.Text;
            textBox1.Text = "";
        }

        private void button29_Click(object sender, EventArgs e)//=
        {
            if (sign == "+")
            {
               count2 = Convert.ToInt32(count) + Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(count2);
            }
            else if (sign == "-")
            {
                count2 = Convert.ToInt32(count) - Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(count2);
            }
            else if (sign == "*")
            {
                count2 = Convert.ToInt32(count) * Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(count2);
            }
            else if (sign == "/")
            {
                count2 = Convert.ToInt32(count) / Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(count2);
            }
        }
    }
}
