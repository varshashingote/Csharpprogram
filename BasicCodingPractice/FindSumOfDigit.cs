using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodingPractice
{ 
    
    public class FindSumOfDigit
    {
        int num2 , digit ,result;
            public FindSumOfDigit( int n1)
            {
            this.num2 = n1;
            }
        public void sum()
        {
           while(num2 != 0)
            {
                digit = num2 % 10;
                result = result + digit;
                num2 = num2 / 10;
                

            }
            Console.WriteLine("sum is"+result);
        }


    }
}
