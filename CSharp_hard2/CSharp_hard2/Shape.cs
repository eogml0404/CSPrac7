using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_hard2
{
    public class NO
    {
        public int GetNumber(int n) => n;

        public int GetNumber(int n1, int n2) => n1 + n2;

        public long GetNumber(long n) => n - 99;

    }
    public class Shape
    {
        //자식만 쓸 수 있다.
        public string getShape() => "Squre";
        public string getShape2() => "Shape2";

        //같은 클래스에서만 사용가능
        private string getShape3() => "Shape3";

        //같은 프로젝트내 다 사용가능
        internal string getShape4() => "Shape4";

        public string Say() => "Hi\r\n";
        public string go() => "go\r\n";

        public virtual string getShape5() => "Shape\r\n";
       
    }

    //상속
    public class Squre : Shape
    {
        //public Squre() { MessageBox.Show(getShape()); }
        public string Say() => "HiHiHi\r\n";
        public new string go() => "gogogo\r\n";

        public string getShape5() => "Square\r\n";


    }
    public class Circle : Shape
    {

        public string getShape() => "Circle\r\n";
    }

    public class Triangle : Shape
    {
        public string getShape() => "Triangle\r\n";
    }
}
