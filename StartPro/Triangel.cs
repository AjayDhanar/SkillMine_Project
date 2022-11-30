using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class Triangel
    {
        static void Main(string[]args)
        {
            int h, b;
            double a;
            Console.WriteLine("Enter the hieght of triangle");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the base of triangle");
            b = int.Parse(Console.ReadLine());

            a = h * b *0.5;
            Console.WriteLine("the area the of Triangle is =" + a);


        }
    }
}
