using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // 필드 및 백업 필드 정의
        private string _name;
        private int _num;
        private decimal _money;

        // 속성 정의
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Num
        {
            get { return  _num; }
            set {
                    _num = 2 * value;
                    textBox1.Text += _num.ToString() + "\r\n";
                 }
        }

        public decimal Money
        {
            get { return _money; }
            set { _money = value; }
        }

        public Form1()
        {
            InitializeComponent();

            // Square 클래스가 정의되지 않아서 주석 처리
            // Square square = new Square("생성자 야호");

            int a = 1;
            textBox1.Text += a.ToString() + "\r\n";
            Num = a;
            

            int b = 3;
            textBox1.Text += b.ToString() + "\r\n";
            Num = b;
            
        }
    }
}