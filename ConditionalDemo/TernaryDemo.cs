using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class TernaryDemo
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

          string re= num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(re);

            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        }
    }

    class GrNo
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the three no");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            string s = a > b ? (a > c ? a + "NO is grater" : c + "is grater") : b + "is grater";
            Console.WriteLine(s);
        }
    }

    class Div5
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Enter the no for divisible by 5 and 11");
            y = int.Parse(Console.ReadLine());
            string v = y % 5 == 0 && y % 11 == 0 ? "no is divisible by both no" : "no is not divisible";
        }
    }
}
