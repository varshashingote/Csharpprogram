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
            Console.WriteLine("Welcome to basic program");
            Console.WriteLine("Please choice any one program");
            Console.WriteLine("1:Calculator \n 2:WeekDay");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:


                    Console.WriteLine("welcome to cSharp basic program");
                    Console.WriteLine("Enter first Number");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second Number");
                    int second = Convert.ToInt32(Console.ReadLine());

                    Calculator c1 = new Calculator(first, second);

                    c1.Addition();
                    c1.Substraction();
                    c1.Multiplication();

                    c1.division();
                    Console.ReadLine();
                    break;
                case 2:

                    Console.WriteLine("Enter the Number from 1to 7");
                    int day = Convert.ToInt32(Console.ReadLine());
                    WeekDay.Finddaywhichfallonweek(day);
                    Console.ReadLine();
                    break;
            }
        }
    }
}

         
