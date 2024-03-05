using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program11
    {
        public void Ptt()
        {
            Console.WriteLine("11.  Hollow Triangle Pattern:");
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    if (j == 1 || j == i * 2 - 1 || i == n) 
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
