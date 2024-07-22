using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDictionary
{
    public partial class Form1 : Form
    {
        public struct idNum
        {
            public string pwd;
            public string num;
        }

        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, idNum> idPwdNum= new Dictionary<string, idNum>();

        /*        Dictionary<string, string> idPwd = new Dictionary<string, string>();
                Dictionary<string, string> idNum = new Dictionary<string, string>();*/
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog()==DialogResult.OK)
            {
                //string path = ofd.FileName;
                var fileStream = ofd.OpenFile();
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        idNum idnum = new idNum();
                        textBox3.Text += line + "\r\n";
                        string[] arr = new string[3];
                        arr = line.Split(',');
                        try
                        {
                            idnum.pwd = arr[1];
                            idnum.num = arr[2];
                        }
                        catch
                        {
                            idnum.pwd = arr[1];
                            idnum.num = null;
                        }
                        
                            idPwdNum.Add(arr[0].ToString(), idnum);
                        
                        
                    }

                }    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (idPwdNum.TryGetValue(textBox1.Text, out idNum idnum))
            {
                string pwd = idnum.pwd;
                string Num = idnum.num;
                if (textBox2.Text.Equals(pwd))
                {
                    MessageBox.Show("로그인 성공 \r\n " + Num);
                   
                }
                else
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
                }
            }
            else
            {
                MessageBox.Show("아이디가 존재하지 않습니다.");
            }
        }
    }
}
