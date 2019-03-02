using System;
using System.Collections.Generic;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Lol = new List<int>();
            int n = int.Parse(Console.ReadLine());
            string s = Convert.ToString(Console.ReadLine());
            string[] s1 = s.Split();

                for(int i = 0; i < s1.Length; i++)
            {
                Lol.Add(Convert.ToInt32(s1[i]));

                Lol.Add(Convert.ToInt32(s1[i]));
            }       

                for(int i = 0; i < Lol.Count; i++)
            {
                Console.Write(Lol[i] + " ");
            }
        }

    }

}
