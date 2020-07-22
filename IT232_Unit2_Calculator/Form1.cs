using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT232_Unit2_Calculator
{
    public partial class Calc : Form
    {
        int total = 0;
        char prevOperation = ' ';
        int plusClicked = 0;
        int minusClicked = 0;
        int multiplyClicked = 0;
        int divideClicked = 0;
        int equalClicked = 0;
        public Calc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate()
        {
            if (prevOperation == ' ')
            {
                total = Convert.ToInt32(lblDisplay.Text);
                lblDisplay.Text = "0";
            }
            else
            {
                if (prevOperation == '+')
                {
                    total = total + Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
                if (prevOperation == '-')
                {
                    total = total - Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
                if (prevOperation == '*')
                {
                    total = total * Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
                if (prevOperation == '/')
                {
                    total = total / Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
            }

            if (plusClicked ==1)
            {
                prevOperation = '+';
                plusClicked = 0;
            }
            else if (minusClicked == 1)
            {
                prevOperation = '-';
                minusClicked = 0;
            }
            else if (multiplyClicked == 1)
            {
                prevOperation = '*';
                multiplyClicked = 0;
            }
            else if (divideClicked == 1)
            {
                prevOperation = '/';
                divideClicked = 0;
            }
            else
            {
                prevOperation = ' ';
                equalClicked = 0;
                lblDisplay.Text = Convert.ToString(total);
            }

        }
                
        private void cmdClr_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            total = 0;
            prevOperation = ' ';
            plusClicked = 0;
            minusClicked = 0;
            multiplyClicked = 0;
            divideClicked = 0;
        }
        

        

        private void cmdZero_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "0";
            else
                lblDisplay.Text += "0";
        }

        private void cmdOne_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "1";
            else
                lblDisplay.Text += "1";
        }

        private void cmdTwo_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "2";
            else
                lblDisplay.Text += "2";
        }

        private void cmdThree_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "3";
            else
                lblDisplay.Text += "3";
        }

        private void cmdFour_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "4";
            else
                lblDisplay.Text += "4";
        }

        private void cmdFive_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "5";
            else
                lblDisplay.Text += "5";
        }

        private void cmdSix_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "6";
            else
                lblDisplay.Text += "6";
        }

        private void cmdSeven_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "7";
            else
                lblDisplay.Text += "7";
        }

        private void cmdEight_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "8";
            else
                lblDisplay.Text += "8";
        }

        private void cmdNine_Click_1(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "9";
            else
                lblDisplay.Text += "9";
        }

        private void cmdEqual_Click_1(object sender, EventArgs e)
        {
            equalClicked = 1;
            calculate();
        }

        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            plusClicked = 1;
            calculate();
        }

        private void cmdSub_Click_1(object sender, EventArgs e)
        {
            plusClicked = 1;
            calculate();
        }

        private void cmdMul_Click_1(object sender, EventArgs e)
        {
            multiplyClicked = 1;
            calculate();
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            divideClicked = 1;
            calculate();
        }
    }
}
