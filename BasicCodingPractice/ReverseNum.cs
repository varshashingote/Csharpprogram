using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodingPractice
{
    
     class ReverseNum
    {
        int num, revese=0;
         
        public ReverseNum(int num1)
        {
            this.num = num1;


        }
        public void Reversefunction()
        {

            while (num != 0)
            {
                revese = revese * 10;
                revese = revese + num % 10;
                num = num / 10;
            }
            Console.WriteLine("ReverseNumberIs"+revese);
        }

    }
}
