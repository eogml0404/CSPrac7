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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Squre squre = new Squre();  
            
            NO n = new NO();
            /*            textBox1.Text = n.GetNumber(10).ToString() + "\r\n";
                        textBox1.Text += n.GetNumber(10,20).ToString() + "\r\n";
                        textBox1.Text += n.GetNumber((long)100).ToString() + "\r\n";*/

       /*     textBox1.Text = squre.Say();
            textBox1.Text += squre.go();
            textBox1.Text += squre.getShape5();*/

            Circle circle1 = new Circle();

           // textBox1.Text = circle1.getShape() + "\r\n";

            Circle circle2 = new Circle();

           // textBox1.Text += circle2.getShape() + "\r\n";

            Circle circle3 = new Circle();

           // textBox1.Text += circle3.getShape() + "\r\n";

            Triangle tri1 = new Triangle();

           // textBox1.Text += tri1.getShape() + "\r\n"; ;

            Triangle tri2 = new Triangle();

           // textBox1.Text += tri1.getShape() + "\r\n";

            Triangle tri3 = new Triangle();

            //주소 값을 넣어 줘야 한다.
            void setThree(ref int x) => x = 3;

            Squre sq1 = new Squre();

          //  textBox1.Text += sq1.getShape() + "\r\n";

            Squre sq2 = new Squre();

          //  textBox1.Text += sq2.getShape() + "\r\n";

            Squre sq3 = new Squre();

         //   textBox1.Text += sq3.getShape() + "\r\n";

            Squre sq4 = new Squre();

          //  textBox1.Text += sq4.getShape();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(circle1);
            shapes.Add(circle2);
            shapes.Add(circle3);
            shapes.Add(tri1);
            shapes.Add(tri2);
            shapes.Add(tri3);
            shapes.Add(sq1);
            shapes.Add(sq2);
            shapes.Add(sq3);
            shapes.Add(sq4);

            for(int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is Squre)
                {
                    textBox1.Text += "Squre\r\n" ;
                }
                else if (shapes[i] is Triangle)
                {
                    textBox1.Text += "Triangle\r\n";
                }
                else
                {
                    textBox1.Text += "Circle\r\n";
                }
            }




        }

    }


}
