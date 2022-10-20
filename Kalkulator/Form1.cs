using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public double res;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "0";
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = "";
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "%";
            OutRes(1);
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "/";
            OutRes(1);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text.Remove(TextOutLb.Text.Length - 1);
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "*";
            OutRes(1);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "-";
            OutRes(1);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += "+";
            OutRes(1);
        }

        private void commaBtn_Click(object sender, EventArgs e)
        {
            TextOutLb.Text = TextOutLb.Text += ",";
        }

        private void equallyBtn_Click(object sender, EventArgs e)
        {
            OutRes(0);
        }     
        
        public void OutRes(int i)
        {
            res = double.Parse(TextOutLb.Text);
            if (i == 0)
            {
                TextOutLb.Text = res.ToString();
                TextEquallyLb.Text = "";
            }
            else
            {
                TextEquallyLb.Text = res.ToString();
            }
        }
    }
}
