﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_hard3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
    /*       int[] arr = new int[2];
               arr[4] = 0;*/
                textBox1.Text += "Try실행\r\n";
                throw new Exception("에러 발생!");

            }
            catch(Exception e) 
            {
                textBox1.Text += e.Message + "\r\n";
            }
            finally 
            {
                textBox1.Text += "프로그램 종료";
            }

        }
    }
}
