using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program1
    {
       public void Ptt()
        {
            Console.WriteLine("1. Square Hollow Pattern:");
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

           
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("*");
                for (int j = 1; j < n - 1; j++)
                {
                    Console.Write(" "); 
                }
                Console.WriteLine("*"); 
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}

