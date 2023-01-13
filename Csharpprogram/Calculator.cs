using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprogram
{
   public class Calculator

    {
       public int first, second, result;
        public Calculator( int firstNum, int SecondNum)
        {
            first = firstNum;
            second = SecondNum;

        }
        public void Addition()
        {
            result=first+second;
            Console.WriteLine("Sum" + result);


        }
        public void Substraction()
        {
            result =Math.Abs( first - second);
            Console.WriteLine("Substraction"+ result);


        }
        public void Multiplication()
        {
            result = first * second;
            Console.WriteLine("multiplication is"+result);
        }

        public  void division()
        {
            result = first / second;
            Console.WriteLine("Division"+result);


        }




    }
}
