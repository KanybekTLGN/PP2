using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {

        public string name, id;
        public int yearofstudy;
        public Student(string a, string b, int c)
        {
            name = a;
            id = b;
            yearofstudy = c;
            Show();
        }
        public void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(yearofstudy);
        }

    }

    class Program
    {
      public static void Main(string[] args)
        {
            string name_ = Convert.ToString(Console.ReadLine());
            string id_ = Convert.ToString(Console.ReadLine());
            int yearofstudy_ =int.Parse(Console.ReadLine());
            
            Student S=new Student(name_, id_, yearofstudy_);
            
        }
    }
}
