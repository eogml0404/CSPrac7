using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Square
    {
        // 기본 적으로는 private이다.
        public string MyName = "사각형";

        public string GetName() => MyName;

        public Square() { MessageBox.Show("기본 생성자"); }

        public Square(string Text) { MessageBox.Show(Text); }
        
        //~Square() { MessageBox.Show("소멸자");  }
   
    

    
    }
}
