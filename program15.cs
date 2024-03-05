using System;

namespace Pattern
{
    internal class Program15
    {
        public int Ncr(int n, int r)
        {
            int res = 1;
            for (int i = 1; i <= r; i++)
            {
                res = res * (n - i+1 ) / i;
            }
            return res;
        }

        public void Ptt()
        {
            Console.WriteLine("15. Pascal’s Triangle:");
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Ncr(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
