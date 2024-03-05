using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program7
    {
        public void Ptt()
        {
            Console.WriteLine("7. Palindrome Triangle Pattern:");
            Console.Write("enter the no of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j > 1; j--)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
}
