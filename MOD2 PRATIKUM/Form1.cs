using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD2_PRATIKUM
{
    public partial class Form1 : Form
    {
        decimal bill1;
        decimal bill2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0") 
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void buttonnol_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text= "0";
            bill1 = 0;
            bill2 = 0;
            textBox1.Text = " ";
        }

        private void buttonkali_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(textBox1.Text);
            textBox2.Text = "x";
            textBox1.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void buttonbagi_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(textBox1.Text);
            textBox2.Text = "/";
            textBox1.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(textBox1.Text);
            textBox2.Text = "-";
            textBox1.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(textBox1.Text);
            textBox2.Text = "+";
            textBox1.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void buttonkoma_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(textBox1.Text);
            textBox2.Text = ",";
            textBox1.Text = " ";
            opr = 5;
            opr_selesai = true;
        }

        private void buttonhasil_Click(object sender, EventArgs e)
        {
            if(opr_selesai == true)
                bill2 = Convert.ToDecimal(textBox1.Text);
            {
                switch (opr)
                {
                    case 1:
                        textBox1.Text = Convert.ToString(bill1 * bill2);
                        break;
                    case 2:
                        textBox1.Text = Convert.ToString(bill1 / bill2);
                        break;
                    case 3:
                        textBox1.Text = Convert.ToString(bill1 - bill2);
                        break;
                    case 4:
                        textBox1.Text = Convert.ToString(bill1 + bill2);
                        break;
                }
            opr_selesai = false;

            }
        }
    }
}
