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
        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        string op;

        //연산 플래그
        bool flag = true;

        private void minus_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                op = "-";
                num1 = int.Parse(inputBox.Text);
                inputBox.Text = "";
                flag = false;

            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                op = "+";
                num1 = int.Parse(inputBox.Text);
                inputBox.Text = "";
                flag = false;

            }
        }
        private void execute_Click(object sender, EventArgs e)
        {
            
            num2 = int.Parse(inputBox.Text);

            switch (op)
            {
                case "+":
                    resultBox.Text = num1.ToString() + op + num2.ToString() + " = " + (num1 + num2).ToString() ; break;
                case "-": resultBox.Text = num1.ToString() + op + num2.ToString() + " = " + (num1 - num2).ToString(); ; break;
                
            }

            

            inputBox.Text = ""; 
            flag = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputBox.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputBox.Text += "9";
        }

        private void ACBtn_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            resultBox.Text = "";
        }

        private void erase_Click(object sender, EventArgs e)
        {
            if(inputBox.Text.Length > 0)
            {

                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);

            }
        }
    }
}
