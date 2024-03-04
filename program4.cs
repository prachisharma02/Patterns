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
            for (int i = n; i >=0; i--)
            {
                for (int j = i; j >=0 ; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
}
