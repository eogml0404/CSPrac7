using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
struct Point
        {
            public int x;
            public int y;
            public int z;
        }
namespace CSharp_hard1
{
    struct Point
    {
        public int x;
        public int y;
        public int z;
    }
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            Point p = new Point();

            p.x = 13;
            p.y = 21;
            p.z = -4;


           //달러 넣으면 변수 넣기쉬움
           //textBox1.Text  = $"point {p.x}, {p.y}, {p.z}";

            Point[] pArr = new Point[3];

            for(int i = 0; i < pArr.Length; i++)
            {
                pArr[i].x = i;
                pArr[i].y = i*i;
                pArr[i].z = -i;

                textBox1.Text += $"point ({pArr[i].x}, {pArr[i].y}, {pArr[i].z})\r\n";
            }

            // 화살표 함수 => (Arrow Function)

            Hi();
            textBox1.Text += Add(4, 2).ToString();

            Class1 class1 = new Class1();
            class1.a = 1;
            class1.b = 2;

        }
        
        // => 다음 마지막 줄이 리턴된다
        // 익명 함수에 많이 쓰인다.
        void Hi() => textBox1.Text = "Hi\r\n";

        int Add(int a, int b) => a + b;
        
    }
}
