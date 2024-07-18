using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_hard2
{
    //인스턴스 생성없이 사용 가능한 필드 또는 메서드
    public class Instant
    {
        public static int cnt;

        public static int Count
        {
            get { return cnt; }
        }

        public Instant() => cnt++;
    }
}
