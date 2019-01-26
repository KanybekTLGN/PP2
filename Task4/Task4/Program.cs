using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, m=4;
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("[*]");
                    }
                }Console.WriteLine();
            }
           
        }
    }
}
