using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2;
        string result;
        string ope = "", pr = "";
        private void all(string n)
        {
           if (tb.Text == "0")
            {
                tb.Text = n;
                return;
            }
            if (pr == "")
                tb.Text += n;
            else
            {
                tb.Text = n;
                pr = "";
            }  
        }
        private void equal()
        {
            if (tb.Text == "")
            {
                tb.Text = "";
            }
            else
            {
                num2 = double.Parse(tb.Text);
                switch (ope)
                {
                    case "+":
                        result = Convert.ToString(num1 + num2);
                        break;
                    case "-":
                        result = Convert.ToString(num1 - num2);
                        break;
                    case "*":
                        result = Convert.ToString(num1 * num2);
                        break;
                    case "/":
                        result = Convert.ToString(num1 / num2);
                        break;
                }
            }
            
            tb.Text =result;
            pr = "s";
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                tb.Text = "";
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            all("1");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                tb.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            all("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            all("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            all("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            all("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            all("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            all("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            all("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            all("9");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            all("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tb.Text.IndexOf('.') < 0)
            {
                if (tb.Text == "0")
                    all("0.");
                else
                    all(".");
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void oper(string operation)
        {
            if (tb.Text == "")
            {
                tb.Text = "0";
            }
            else
            {
                num1 = Convert.ToDouble(tb.Text);
                tb.Text = "";
                ope = operation;
                pr = "s";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
           
            oper("+");
        }

        private void sub_Click(object sender, EventArgs e)
        {
            oper("-");
        }

        private void multi_Click(object sender, EventArgs e)
        {
            oper("*");
        }

        private void div_Click(object sender, EventArgs e)
        {
            oper("/");
        }

        private void mudl_Click(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                tb.Text = "";
            }
            else
            {
                double num = double.Parse(tb.Text);
                num = num * (-1);
                tb.Text = Convert.ToString(num);
                MessageBox.Show("Enter Number Please!");
            }
            }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This Calculator Created By:Mahmoud Qourani\nMahmoudQourani@Gmail.com");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            equal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
