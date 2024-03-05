using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program12
    {
        public void Ptt()
        {
            Console.WriteLine("12. Hollow Reverse Triangle Pattern:");
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            for (int i = n; i > 0; i--)
            {
               
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j == 1 || j == 2 * i - 2 || i == 1) 
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" "); 
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}
