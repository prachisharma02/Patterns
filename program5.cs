using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program5
    {
        public  void Ptt()
        {
            Console.WriteLine("5. Number-changing Pyramid Pattern:");
            Console.Write("enter the no of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= n; i++)
            {   
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count+" ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
