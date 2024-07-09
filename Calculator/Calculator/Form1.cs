using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numbers = new List<int>();
        List<string> operators = new List<string>();
        bool flag = true;

        private void minus_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("-");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("+");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("*");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            AddNumberAndOperator("/");
        }

        private void AddNumberAndOperator(string op)
        {
            if (inputBox.Text != "")
            {
                int number;
                if (int.TryParse(inputBox.Text.Replace(",", ""), out number))
                {
                    numbers.Add(number);
                    operators.Add(op);
                    inputBox.Text = "";
                }
                else
                {
                    resultBox.Text = "Invalid input!";
                }
            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (inputBox.Text != "")
            {
                int number;
                if (int.TryParse(inputBox.Text.Replace(",", ""), out number))
                {
                    numbers.Add(number);
                    CalculateResult();
                }
                else
                {
                    resultBox.Text = "Invalid input!";
                }
            }
        }

        private void CalculateResult()
        {
            int result = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i])
                {
                    case "+":
                        result += numbers[i + 1];
                        break;
                    case "-":
                        result -= numbers[i + 1];
                        break;
                    case "*":
                        result *= numbers[i + 1];
                        break;
                    case "/":
                        if (numbers[i + 1] == 0)
                        {
                            resultBox.Text = "Error: Division by zero!";
                            return;
                        }
                        result /= numbers[i + 1];
                        break;
                }
            }

            resultBox.Text = result.ToString("N0");
            inputBox.Text = "";
            numbers.Clear();
            operators.Clear();
            flag = true;
        }

        private void AppendToInputBox(string value)
        {
            inputBox.Text += value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendToInputBox("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendToInputBox("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendToInputBox("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendToInputBox("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToInputBox("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendToInputBox("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendToInputBox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendToInputBox("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendToInputBox("9");
        }

        private void ACBtn_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            resultBox.Text = "";
            numbers.Clear();
            operators.Clear();
        }

        private void erase_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
            }
        }
    }
}