using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btn
{
    public partial class Form1 : Form
    {
        //Form1 의 생성자
        public Form1()
        {
            InitializeComponent();
        }

   
        //버튼 클릭했을 때 실행
        private void button_hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕!");
        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
