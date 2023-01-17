using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_no3
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int a = 90;
            int b = 60;
            int c = 40;
           if(a > b && a > c)
            {
                Console.WriteLine("Numbr a is greater");
                Console.ReadLine();
            }
           
            if( b > a && b > c)
            {
                Console.WriteLine("Number b is grater");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number c is greater");
                Console.ReadLine();
            }

            }
        }
    
}
