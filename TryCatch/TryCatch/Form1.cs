using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public void makeArr(out string[] strArr, string path)
        {
            List<string> lines = new List<string>();

            StreamReader reader = new StreamReader(path);
            
                string readLine;
                while ((readLine = reader.ReadLine()) != null)
                {
                    lines.Add(readLine);
                }

            strArr = lines.ToArray();
        }

        public void printArr(string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                try
                {
                    int.Parse(strArr[i]);
                    textBox1.Text += "숫자 " + int.Parse(strArr[i]) + "\r\n";
                }
                catch (Exception e)
                {
                    textBox1.Text += "문자 " + strArr[i] + "\r\n";
                }
                finally
                {
                    if (i == strArr.Length - 1)
                        textBox1.Text += "완료";
                }

            }
        }

        public Form1()
        {
            InitializeComponent();

            //@붙여야 \의 기능 무시 (탈출 문자열 \)
            //절대경로 (전체 경로 복사)
            //string content = File.ReadAllText(@"C:\Users\dbseo\source\repos\CSPrac7\TryCatch\TryCatch\hihi.txt");

            //상대경로 bin - 디버그 파일안에 넣어놓기


            string[] strArr;
            string path = "hihi.txt";

            makeArr(out strArr, path);

            printArr(strArr);

        }
    }
}
