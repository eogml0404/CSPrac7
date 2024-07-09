using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Remove(1);
            a.Contains(1);
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
