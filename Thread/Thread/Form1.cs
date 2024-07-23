using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;



namespace ThreadPrac
{
    public partial class Form1 : Form
    {
        static int shareData = 0;
        static object lockobject = new object();
        Random rd = new Random();
        int[] pro = new int[5];
        Thread[] threads = new Thread[5];
        public Form1()
        {

            InitializeComponent();

            threads[0] = new Thread(() => carThread(1));
            threads[1] = new Thread(() => carThread(2));
            threads[2] = new Thread(() => carThread(3));
            threads[3] = new Thread(() => carThread(4));
            threads[4] = new Thread(() => carThread(5));

            textBox1.Text = $"출발 시간 :  {DateTime.Now}\r\n";
            foreach (var thread in threads)
            {
                thread.Start();
            }

        }
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        void RandomSleep()
        {
            

            int sleepTime = (int)(rd.NextDouble() * 1000.0);
            Thread.Sleep(sleepTime);
            

        }
        void carThread(int n)
        {
           
            pro[n - 1] = 0;
            while ((pro[n - 1] < 10))
            {
                pro[n - 1]++;
                RandomSleep();
            }
            UpdateTextBox($"{n} 번 째 자동차 도착! 완료 시간: {DateTime.Now}\r\n");
        }

        void UpdateTextBox(string text)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(() =>
                {
                    textBox1.Text += text;
                }));
            }
            else
            {
                textBox1.Text += text;
            }
        }

        private void UpdateData1()
        {
            //lock : 못들어오게 잠그는 것 실행을 보장 할 수 있다. for밖에 하는게 좋다
            lock (lockobject)
            {
                for (int i = 0; i < 10; i++)
                {


                    shareData++;
                    Thread.Sleep(100);
                    textBox1.Text += $"1 :{shareData} \r\n";

                }
            }
        }
        private void UpdateData2()
        {
            lock (lockobject)
            {
                for (int i = 0; i < 10; i++)
                {

                        shareData++;
                        Thread.Sleep(100);
                        textBox1.Text += $"2 :{shareData} \r\n";

                }
            }
        }



        private void MyThread()
        {
           // textBox1.Text += "2번 스레드 시작\r\n";

            Thread.Sleep(1000);

           //W textBox1.Text += "2번 스레드 끝\r\n";
        }
    }
}
