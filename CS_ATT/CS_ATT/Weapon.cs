using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_ATT
{
    public class Weapon
    {
        public int attPower;
        public int attSpeed;

        // 생성자에서 파라미터를 받아 필드를 초기화합니다.
        public Weapon(int attPower, int attSpeed)
        {
            this.attPower = attPower;
            this.attSpeed = attSpeed;
        }

        // getInfo 메서드
        public string getInfo()
        {
            
            return "공격력 : " + attPower.ToString() + ", " +
                "공격속도 : " + attSpeed.ToString();
        }
    }

    public class Rifle : Weapon
    {


        public int bullet;
        public Rifle(int attPower, int attSpeed, int bullet) : base(attPower, attSpeed)
        {
            //this.attPower = attPower ;
            this.bullet = bullet;
            
        }

        public string getInfo()
        {

            return "공격력 : " + attPower.ToString() + ", " +
                "공격속도 : " + attSpeed.ToString() + ", 장탄 수 : " + bullet.ToString();
        }

        public int combatPoint() => attPower * attSpeed * bullet;

        public void setCombatPoint(int a)
        {
            this.attPower = a;
        }

        public void setCombatPoint(int a, int b)
        {
            this.attPower = a;
            this.attSpeed = b;
        }

        public void setCombatPoint(int a, int b, int c)
        {
            this.attPower = a;
            this.attSpeed = b;
            this.bullet = c;
        }
    }


    public class Knife : Weapon
    {
        public int sharp;
        public Knife(int attPower, int attSpeed, int sharp) : base(attPower, attSpeed)
        {
            this.sharp = sharp;
        }

        public int combatPoint() => attPower * attSpeed * sharp;

        public string getInfo()
        {

            return "공격력 : " + attPower.ToString() + ", " +
                "공격속도 : " + attSpeed.ToString() + ", 날카로움 : " + sharp.ToString();
        }

        public void setCombatPoint(int a)
        {
            this.attPower = a;
        }

        public void setCombatPoint(int a, int b)
        {
            this.attPower = a;
            this.attSpeed = b;
        }

        public void setCombatPoint(int a, int b ,int c)
        {
            this.attPower = a;
            this.attSpeed = b;
            this.sharp = c;
        }
    }
}
