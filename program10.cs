using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program10
    {
        public void Ptt()
        {
            Console.WriteLine("10. Mirror Image Triangle Pattern:");
            Console.Write("enter the no of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= n; k++)
                {
                    Console.Write(k+" ");
                }
                Console.WriteLine("");

            }
            for (int i = 1; i <    n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = n-i; k <= n; k++)
                {
                    Console.Write(k+" ");
                }
                Console.WriteLine("  ");
            }
        }
    }
}
