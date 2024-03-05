using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program9
    {
        public void Ptt()
        {
            Console.WriteLine("9. Diamond Star Pattern:");
            Console.Write("enter the no of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 2*n-1; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                for (int j = n; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }


                Console.WriteLine("  ");

            }
        }
    }
}
