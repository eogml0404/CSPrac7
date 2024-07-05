using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0705
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //배열 초기화
            int[] array1 = new int[5];

            //배열 생성
            int[] array2 = { 1, 2, 3, 4, 5, 6 };
            
            int[,] multiDimensionalArray1 = new int[2, 3];
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //불규칙 배열 - > 잘 안쓰긴함
            int[][] jaggedArray = new int[6][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[3] { 1, 2, 3 };

            //for (int i = array2.Length-1; i >= 0 ; i--)
              //  Box1.Text += array2[i].ToString() + " ";
            
           /* foreach(int j in multiDimensionalArray2)
            {
                Box1.Text += j.ToString() + " ";
            }
*/

            //행의 길이 GetLength(0), 열의 길이 GetLength(1)
            /*for(int j = 0; j < multiDimensionalArray2.GetLength(0); j++)
            {
                for(int k = 0; k < multiDimensionalArray2.GetLength(1); k++)
                {
                    Box1.Text += multiDimensionalArray2[j,k] + " ";
                }
            }*/

            string codingon = "codingon";
            string[] a = "1 2 3".Split(' ');
            Box1.Text += a[0] + " ";
            Box1.Text += a[1] + " ";
            Box1.Text += a[2] + " ";

            Box1.Text = codingon.Replace("on", "off");
            Box1.Text = "";



            string str = "string 5";
            string[] strArr = str.Split(' ');

            string str1 = strArr[0];
            int num = int.Parse(strArr[1]);

            for (int i = 0; i < num; i++)
                Box1.Text += str1;





        }
            
    }
}
