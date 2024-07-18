using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCollection
{
    public partial class Form1 : Form
    {
        int[] nums = { 1, 2, 3 };

        public void print_nums(int[] arr, int index)
        {
            if (index < 0)
            {
                textBox1.Text += "스택이 비어있습니다.";
                return;
            }

            textBox1.Text += arr[index].ToString() + "\r\n";
            print_nums(arr, index - 1);
        }

        public Form1()
        {
            InitializeComponent();

            Stack st = new Stack();
         
            /*st.Push("일");
            st.Push("이");
            st.Push("삼");

            try
            {
                int stack_size = st.Count;

                for (int i = 0; i < stack_size +1; i++)
                {
                    textBox1.Text += $"{st.Peek()}\r\n";
                    textBox1.Text += $"{st.Pop()}\r\n";
                }
            }catch (Exception ex)
            {
                textBox1.Text += ex.Message;
            }*/
            //print_nums(nums, nums.Length - 1);

            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            try
            {
                int queue_size = queue.Count;

                for (int i = 0; i < queue_size + 1; i++)
                {
                    textBox1.Text += $"{queue.Dequeue()}\r\n";
                
                }
            }
            catch (Exception ex)
            {
                textBox1.Text += ex.Message;
            }
         
        }
    }
}
