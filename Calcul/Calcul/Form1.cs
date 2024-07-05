using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string numA = "5"; 
            string numB = "4";  
            Calculation(numA, numB, '/'); 
        }

        public void Calculation(string a, string b, char op)
        {
            double numA, numB;

            if (!double.TryParse(a, out numA) || !double.TryParse(b, out numB))
            {
                MessageBox.Show("입력된 값이 올바르지 않습니다.");
                return;
            }
            switch (op)
            {
                case '+':
                    Box1.Text = "계산완료 \r\n" + (numA + numB).ToString();
                    break;
                case '-':
                    Box1.Text = "계산완료 \r\n" + (numA - numB).ToString();
                    break;
                case '*':
                    Box1.Text = "계산완료 \r\n" + (numA * numB).ToString();
                    break;
                case '/':
                    if (numB == 0.0)
                    {
                        Box1.Text = "0으로 나눌 수 없습니다.";
                    }
                    else
                    {
                        Box1.Text = "계산완료 \r\n" + (numA / numB).ToString();
                    }
                    break;
                default:
                    MessageBox.Show("지원하지 않는 연산자입니다."); 
                    break;
            }
        }
    }
}
