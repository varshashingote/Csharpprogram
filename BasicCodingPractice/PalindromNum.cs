using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodingPractice
{
    public class PalindromNum
    {

        int num3, revese = 0;
        int temp;
        public PalindromNum(int no1)
        {
            this.num3 = no1;

        }
       public void palindrom()
        {
            temp = num3;
            while(num3 > 0)
            {
                revese = revese * 10;
                revese = revese + num3 % 10;
                num3 = num3 / 10;
            }

        
            if(temp == revese)
                Console.WriteLine("palindrom Number");
            else
                Console.WriteLine("Number is not palindrom ");
        }
    }
}
