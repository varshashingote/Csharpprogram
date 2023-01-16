using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodingPractice
{
    public class EvenOdd
    {
        int num1;
        public EvenOdd(int no1)
        {
            this.num1 = no1;
           

        }
        public void findevenodd()
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            
        }
        

        
    }
}
