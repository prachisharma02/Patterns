using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program2
    {
        public void Ptt()
        {
            Console.WriteLine("2. Number triangle Pattern:");
            Console.Write("enter the no of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j<=n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                
                Console.WriteLine("  ");
            }
        }
    }
}
