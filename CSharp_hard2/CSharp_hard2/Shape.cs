using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_hard2
{
    public class Shape
    {
        //자식만 쓸 수 있다.
        protected string getShape() => "Shape";
        public string getShape2() => "Shape2";

        //같은 클래스에서만 사용가능
        private string getShape3() => "Shape3";

        //같은 프로젝트내 다 사용가능
        internal string getShape4() => "Shape4";

    }

    //상속
    public class Squre : Shape
    {
        public Squre() { MessageBox.Show(getShape()); }
        

    }

}
