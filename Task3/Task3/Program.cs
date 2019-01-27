using System;
using System.Collections.Generic;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int n=Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] =Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");           }
                */
                
            int m = int.Parse(Console.ReadLine());
            // m = is size of s2;
            string s = Convert.ToString(Console.ReadLine());
            // s is like sequence of numbers;
           string[] s2 = s.Split();
            //s2 is s without " ";
            for(int i = 0; i < 2 * m; i++)
            {
                Console.Write(s2[i] + " " + s2[i] + " ");
            }
        }

    }

}
