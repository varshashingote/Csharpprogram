using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*            j =columns
                          ******   i=rows
                          ******
                          ******
                          ******
                          ******
             
             */
            {


                for (int i = 1; i <= 5; i++)  //for rows
                {
                    for (int j = 1; j <= 5; j++) //for colums

                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}

              
