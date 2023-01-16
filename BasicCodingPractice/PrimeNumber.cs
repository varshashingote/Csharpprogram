using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodingPractice
{
    internal class PrimeNumber
    {
        int n, i, m = 0, flag = 0;
        public PrimeNumber(int num1)
        {
            this.n = num1;
        }
        public  void Prime()
        {
            m = n / 2;
            for (i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }

            }
            if(flag==0)
            {
                Console.WriteLine("Number is prime");

            }

        }
    }
}
