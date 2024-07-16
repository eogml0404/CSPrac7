using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_ATT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Rifle rifle = new Rifle(40, 30, 3);

            //Knife knife = new Knife(30, 50, 5);

            //textBox1.Text = rifle.getInfo();

           // textBox1.Text += "\r\nAK47 "+rifle.combatPoint().ToString() + "\r\n";
            //공격력 변경
            rifle.setCombatPoint(77);
            textBox1.Text = rifle.getInfo() + "\r\n";
            //공격력, 공격속도 변경
            rifle.setCombatPoint(97,80);
            textBox1.Text += rifle.getInfo() + "\r\n";

            //공격력, 공격속도, 장탄 수 변경
            rifle.setCombatPoint(66, 60, 30);

            textBox1.Text += rifle.getInfo() + "\r\n";

        }
    }
}
