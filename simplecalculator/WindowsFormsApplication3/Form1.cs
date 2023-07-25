using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string s = "";
        int n1 = 0;
        int n2 = 0;
        int r = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            s += "1";
            textBox1.Text = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s += "2";
            textBox1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s += "3";
            textBox1.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s += "4";
            textBox1.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s += "5";
            textBox1.Text = s;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s += "6";
            textBox1.Text = s;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s += "7";
            textBox1.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s += "8";
            textBox1.Text = s;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            s += "9";
            textBox1.Text = s;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s += "0";
            textBox1.Text = s;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            s ="";
            textBox1.Text = s;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            s += "+";
            textBox1.Text = s;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            s += "-";
            textBox1.Text = s;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            s += "*";
            textBox1.Text = s;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            s += "/";
            textBox1.Text = s;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string s1="", s2 = "";
            char symbol='+';
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
                {
                    j = i;
                    symbol = s[i];
                    break;
                }
                else
                    s1 += s[i].ToString();
            }
            n1 = int.Parse(s1);
            s2 = s.Substring(j + 1);
            n2 = int.Parse(s2);
            //MessageBox.Show(n1.ToString());
            //MessageBox.Show(n2.ToString());
            if (symbol == '+')

            {
                r = n1 + n2;
                textBox1.Text = r.ToString();
                s = r.ToString();
            }
            else if (symbol == '-')

            {
                r = n1 - n2;
                textBox1.Text = r.ToString();
                s = r.ToString();
            }
            else if (symbol == '*')

            {
                r = n1 * n2;
                textBox1.Text = r.ToString();
                s = r.ToString();
            }
            else 

            {
                r = n1 / n2;
                textBox1.Text = r.ToString();
                s = r.ToString();
            }


        }
    }
}
