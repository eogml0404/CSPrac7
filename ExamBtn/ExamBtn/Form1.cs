using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_output.Text += textBox_input.Text + "\r\n";

        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox_input.Text;
        }
    }
}
