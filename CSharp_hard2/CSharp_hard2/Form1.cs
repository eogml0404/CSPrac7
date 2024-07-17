using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_hard2
{
    public static class Dog
    {
        public static string Voice() => "먼먼";
    }


    public partial class Form1 : Form
    {
        void Add1(ref int sum1, ref int sum2, ref int result2) => result2 = sum1 + sum2;
        public Form1()
        {
            InitializeComponent();

            void makeInstance(ref int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = i + 1;
            
                }
            }

            void makeInstance2(out int[] numbers, int len)
            {
                numbers = new int[len];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = i + 1;

                }
            }

            InitializeComponent();

            int a = 5;
            int b = 6;
            int result = 0;

           // textBox1.Text += circle2.getShape() + "\r\n";

            Add1(ref a, ref b, ref result);
            textBox1.Text = result.ToString();

           // textBox1.Text += circle3.getShape() + "\r\n";

            int[] nums = new int[10];
            makeInstance(ref nums);

            for (int i = 0; i < nums.Length; i++)
            {
                //    textBox1.Text += nums[i].ToString() + " ";
            }
            textBox1.Text += "\r\n\r\n";
            int Length = 10;
            int[] nums2;
            makeInstance2(out nums2, Length);

            for (int i = 0; i < nums.Length; i++)
            {
                // textBox1.Text += nums2[i].ToString() + " ";
            }

           // textBox1.Text += tri1.getShape() + "\r\n";

            Triangle tri3 = new Triangle();

            Squre squre = new Squre();

            // Dog dog = new Dog(); // 이 줄을 제거합니다.
            string dogVoice = Dog.Voice(); // Dog 클래스의 메서드를 직접 호출합니다.

            // dogVoice를 사용하여 필요한 작업 수행
            // MessageBox.Show(dogVoice); // 예시: 메시지 박스로 dogVoice 출력

            Squre sq2 = new Squre();

            Instant in1 = new Instant();
            Instant in2 = new Instant();

            //static 사용
            // textBox1.Text = Instant.Count.ToString();

            int num = 1;
            // textBox1.Text = minusOne(num).ToString();

            //setThree(ref num);
            setThree(out num);
            //textBox1.Text = num.ToString();

            //값의 참조
            int minusOne(int x) => x - 1;

            //num을 3으로 바꾸고 싶은데 안됨 (값만 넘어 왔기 때문에)
            //void setThree(int x) => x = 3;

            //주소 값을 넣어 줘야 한다. (참조)
            //void setThree(ref int x) => x = 3;

            //out -> int x 이라는게 나올 것 이다.
            void setThree(out int x) => x = 3;

            //out -> 미리 할당 안해도됨, ref -> 미리 할당해야됨(ex int num = 5;)


        }

    }


}
