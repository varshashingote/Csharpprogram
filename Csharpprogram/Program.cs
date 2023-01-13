using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprogram
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("welcome to cSharp basic program");
            Console.WriteLine("Enter first Number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int second= Convert.ToInt32(Console.ReadLine());

            Calculator c1 = new Calculator(first, second);
            
            c1.Addition();
            c1.Substraction();
            c1.Multiplication();

            c1.division();
            Console.ReadLine();









        }
    }
}
