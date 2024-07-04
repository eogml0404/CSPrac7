using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0704
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
            int cnt = 0;
            while (cnt < 5)
            {

                if (cnt == 0)
                {
                    Box1.Text += "Loop Start! \r\n";
                    cnt++;
                }
                else
                    Box1.Text += cnt++.ToString() + "\r\n";

            }

        }


    }
}
