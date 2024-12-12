using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNum, secondNum;
        string oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "7";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "8";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "9";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "9";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "6";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "6";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "5";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "5";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
           // if (textDisplay.Text == "0")
            //{
            //    textDisplay.Text = "4";
            //}
           // else
           // {
                textDisplay.Text = textDisplay.Text + "4";
           // }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "3";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "3";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "2";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "2";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "1";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "1";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "0";
            }
            else
            {
                textDisplay.Text = textDisplay.Text + "0";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textDisplay.Text);
            oper = "+";
            textDisplay.Text = " ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textDisplay.Text);
            oper = "-";
            textDisplay.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textDisplay.Text);
            oper = "*";
            textDisplay.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textDisplay.Text);
            oper = "/";
            textDisplay.Text = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(textDisplay.Text);
            q = -1 * q;
            textDisplay.Text = Convert.ToString(q);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            string f, s;
            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);
            f = "";
            s = "";

        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "0";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(textDisplay.Text);
            if (oper == "+")
            {
                textDisplay.Text = (firstNum + secondNum).ToString();
            }
            if (oper == "-")
            {
                textDisplay.Text = (firstNum - secondNum).ToString();
            }
            if (oper == "*")
            {
                textDisplay.Text = (firstNum * secondNum).ToString();
            }
            if (oper == "/")
            {
                textDisplay.Text = (firstNum / secondNum).ToString();
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
