using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCal
{
    class Program
    {
        public static void Main(string[] args)
            {
                string value;
                do
                {



                    int no1;
                    int no2;
                    int result;
                    Console.WriteLine("Enter  first Number:");
                    no1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second Number  :");
                    no2 = Convert.ToInt32(Console.ReadLine());




                    //Console.ReadLine();
                    Console.WriteLine("Enter the Symbol(+,-,/,*):");
                    string symbol = Console.ReadLine();
                    switch (symbol)
                    {
                        case "+":
                            result = no1 + no2;
                            Console.WriteLine("Result of add is" + result);
                            break;

                        case "-":
                            result = Math.Abs(no1 - no2);
                            Console.WriteLine("Result of sub is" + result);
                            break;
                        case "*":
                            result = no1 * no2;
                            Console.WriteLine("Result multiplication is" + result);
                            break;
                        case "/":
                            result = no1 / no2;
                            Console.WriteLine("Result div is" + result);
                            break;
                        default:
                            Console.WriteLine("you enter wrong operator");
                            break;

                    }
                    Console.ReadLine();
                    Console.WriteLine("Do you want to c continoue(Y/N):");
                    value = Console.ReadLine();


                }
                while (value == "Y" || value == "N");




            }
        }

    }


