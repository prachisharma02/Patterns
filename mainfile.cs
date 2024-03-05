using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8. Rhombus Pattern:");
            Console.Write("enter the no of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
               for(int j = 1; j <= n-i-1; j++)
                {
                    Console.Write(" ");
                }
               for(int j = 1;j < n; j++)
                {
                    Console.Write("*");
                }
              
                   
                
                Console.WriteLine();

            }
            //Pattern3 pattern3 = new Pattern3();
            //pattern3.Patt();
            //Program5 p = new Program5();
            //p.Ptt();
            //Program4 p4 = new Program4();
            //p4.Ptt();
            //Program6 p6 = new Program6();
            //p6.Ptt();
            //Program2 p2 = new Program2();
            //p2.Ptt();
            //Program7 p7 = new Program7();
            //p7.Ptt();
            //Program8 p8 = new Program8();
            //p8.Ptt();
            //Program9 p9 = new Program9();
            //p9.Ptt();
            //Program10 p10 = new Program10();
            //p10.Ptt();
            //Program15 p15 = new Program15();
            //p15.Ptt();
            //Program1 p1 = new Program1();
            //p1.Ptt();
            //Program11 p11 = new Program11();
            // p11.Ptt();
            //Program12 p12 = new Program12();
            //p12.Ptt();
            //Program13 p13 = new Program13();
            //p13.Ptt();
            //Program14 p14 = new Program14();
            //p14.Ptt();
            Console.ReadLine();


        }
    }
}
