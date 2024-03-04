using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program4
    {
        public void Ptt()
        {
            Console.WriteLine("5. Number-changing Pyramid Pattern:");
            Console.Write("enter the no of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j <n; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
