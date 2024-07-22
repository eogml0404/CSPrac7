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

        //열거형
        //가독성이 좋고, 범위 제한가능
        public enum Weekday
        {
            Monday,
            Tuesday, 
            Wednesday, 
            thursday,
            Saturday,
            Friday,
            Sunday
        }
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
                   // textBox1.Text += $"{queue.Dequeue()}\r\n";

                }
            }
            catch (Exception ex)
            {
                textBox1.Text += ex.Message;
            }

            Hashtable ht = new Hashtable();
            ht[0] = 999;
            ht["이름"] = "조온";
            ht["취미"] = "게임";

           /* textBox1.Text += $"{ht[0]}\r\n";
            textBox1.Text += $"{ht["이름"]}\r\n";
            textBox1.Text += $"{ht["취미"]}\r\n";
*/
            //제네릭 컬렉션
            //Stack stack = new Stack(); 컬렉션
            Stack<int> i_stack = new Stack<int>(); //-> 더 빠름 int가 4byte라 (안정성도 o)
            i_stack.Push(1);
            int num = i_stack.Pop();
            i_stack = new Stack<int>();
            //i_stack.Push(1f);

            //textBox1.Text += $"{num}\r\n";

            List<double> d_list = new List<double>();
            d_list.Add(30.44); // -> 더블
            d_list.Add(303.44f); // -> 형 변환되서 더블로 됨
            //자동 형변환 -> 큰거에서 작은거로는 안됨 double -> float으로는 안됨 

            foreach(double d in d_list)
            {
               // textBox1.Text += $"{d}\r\n";
            }

            Weekday today = Weekday.Monday;

            int size = 10;
            //열거형
            //Enumerable => 자동으로 만들어줌, array가 아니라 열거형 타입이다.
            var numbers = Enumerable.Range(1, size);
            var same_numbers = Enumerable.Repeat(0, size);
            //var same_numbers_Arr = Enumerable.Repeat(0, size).toArray();

            textBox1.Text += $"numbers {numbers}\r\n";
            textBox1.Text += $"same_numbers {same_numbers}\r\n";

            foreach(var number in numbers)
            {
                textBox1.Text += $"{number}";
            }
            
            textBox1.Text += $"\r\nsame_numbers: {string.Join(", ", same_numbers)}\r\n";

            textBox1.Text = "";
            for(int i = 0; i < 10; i++)
            {
              //  textBox1.Text += $"{i}";
            }
            //textBox1.Text += "\r\n";
            foreach(var i in Enumerable.Range(0, 10))
            {
               // textBox1.Text += $"{i}";
            }

            //딕셔너리 -> 내부적으로는 해시테이블 이용해서 구현
            Dictionary<string, string> data1 = new Dictionary<string, string>();
            var data2 = new Dictionary<string, string>();

            data1.Add("오리온", "고래밥");
            data2.Add("농심", "신라면");

            data1.Remove("오리온");

            //변경은 가능
            data2["농심"] = "너구리";
            //textBox1.Text += $"{data2["농심"]}\r\n";
            /*try
            {
                data2.Add("농심", "짜파게티");

            }
            catch (Exception ex) { textBox1.Text += ex.Message; }*/

            if (!data1.ContainsKey("오리온"))
            {
                data1.Add("오리온", "초코파이");
            }
            
            //지정된 값을 가져오는 TryGetValue -> try catch 생략해서 좋다
            if(data1.TryGetValue("오리온", out string value))
            {
                textBox1.Text += value.ToString() + "\r\n";
            }
            foreach(KeyValuePair<string, string> pair in data1)
            {
                textBox1.Text += $"{pair.Key}에서 {pair.Value}를 만듭니다.";
            }
            textBox1.Text += "\r\n";
            //var 써도된다.
            foreach (var pair in data1)
            {
                textBox1.Text += $"{pair.Key}에서 {pair.Value}를 만듭니다.";
            }
        }

    }
}
