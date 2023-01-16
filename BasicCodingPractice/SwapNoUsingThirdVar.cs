using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodingPractice
{
    public class SwapNoUsingThirdVar
    {
        int n1, n2;
        int temp;
        public SwapNoUsingThirdVar(int no1, int no2)
        {
            this.n1 = no1;
            this.n2 = no2;

            

        }
       public void Swap()
        {
            Console.WriteLine("before Swapping n1:"+n1);
            Console.WriteLine("before Swapping n2:"+n2);
            temp =n1 ;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("After Swapping n1:"+n1);
            Console.WriteLine("After Swapping n2:"+n2);
        }


    }
}
