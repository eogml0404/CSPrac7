using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCal
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<int> numbers = new List<int>();
        List<string> operators = new List<string>();
        
        bool resultFlag = false;

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
            if (operators.Count > numbers.Count)
            {
                return;
            }
            else
            {
                
                if (!string.IsNullOrEmpty(resultBox.Text))
                {
                    char lastChar = resultBox.Text[resultBox.Text.Length - 1];
                    if (lastChar == '+' || lastChar == '-' || lastChar == '*')
                    {
                        return; 
                    }
                }

                resultBox.Text += op;

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
            if (numbers.Count == 0) return;

            List<int> tempNumbers = new List<int>(numbers);
            List<string> tempOperators = new List<string>(operators);

            for (int i = 0; i < tempOperators.Count; i++)
            {
                if (tempOperators[i] == "*" || tempOperators[i] == "/")
                {
                    int result = tempNumbers[i];
                    switch (tempOperators[i])
                    {
                        case "*":
                            result *= tempNumbers[i + 1];
                        break;
                    }
                    tempNumbers[i] = result;
                    tempNumbers.RemoveAt(i + 1);
                    tempOperators.RemoveAt(i);
                    i--; 
                }
            }

            int finalResult = tempNumbers[0];
            for (int i = 0; i < tempOperators.Count; i++)
            {
                switch (tempOperators[i])
                {
                    case "+":
                        finalResult += tempNumbers[i + 1];
                        break;
                    case "-":
                        finalResult -= tempNumbers[i + 1];
                        break;
                }
            }

            resultBox.Text += " = " + finalResult.ToString("N0");
            inputBox.Text = "";
            numbers.Clear();
            operators.Clear();

            resultFlag = true;
        }

        private void AppendToInputBox(string value)
        {
            if (resultFlag == true)
            {
                resultBox.Text = "";
            }
            inputBox.Text += value;
            resultBox.Text += value;

            resultFlag = false;
            
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
            if (resultBox.Text.Length > 0)
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.Text.Length - 1);

            }
        }

    }
}
