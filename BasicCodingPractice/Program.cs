using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodingPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.WriteLine("Welcome to Basic Program ::");
                Console.WriteLine("Please Enter any one program you want to execute!!!");
                Console.WriteLine("1:EvenOdd\n2:SwapNoUsingThridVar\n3:ReverseNum\n4:PalindromNum" +
                    "\n5:FindSumOfDigit\n6:PrimeNumber");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Number do you want check even or odd");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        EvenOdd eo = new EvenOdd(num1);
                        eo.findevenodd();
                        break;


                    case 2:

                        Console.WriteLine("Enetr the first no to swap");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second No to swap");
                        int n2 = Convert.ToInt32(Console.ReadLine());

                        SwapNoUsingThirdVar sw = new SwapNoUsingThirdVar(n1, n2);
                        sw.Swap();
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter the Number Do u want to reverse");
                        int num = Convert.ToInt32(Console.ReadLine());
                        ReverseNum rn = new ReverseNum(num);
                        rn.Reversefunction();
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Enter the Number do u want to check Number is palinrom or not");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        PalindromNum pn = new PalindromNum(num3);
                        pn.palindrom();
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Enter the Number Do u want sum");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        FindSumOfDigit fn = new FindSumOfDigit(num2);
                        fn.sum();
                        Console.ReadLine();
                        break;

                    case 6:

                        Console.WriteLine("Enter the Number Do u want to check prime or not");
                        int n = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber prn = new PrimeNumber(n);
                        prn.Prime();
                        Console.ReadLine();
                        break;
                  

                    default:
                     
                        Console.WriteLine("OOOP's not avaliable sorry!!!!");
                        break;
                        
                }
                Console.ReadLine();
                Console.WriteLine(" You like  this program !!!!!!!!!!! Do you want to continoue press(Y/N)");
                value = Console.ReadLine();
            }
            while (value == "Y" || value == "N");

        }
    }

}

