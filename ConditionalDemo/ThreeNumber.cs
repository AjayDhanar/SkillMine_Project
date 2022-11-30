using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class ThreeNumber
    {
        static void Main(string[] args)
        {
            //without using && operator

            Console.WriteLine("Enter the number num1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num3");
            int c = int.Parse(Console.ReadLine());

            int max = 0;

            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }
            }
            else if(b>c)

            {
                max = b;
            }
            else
            {
                max = c;
            }

            Console.WriteLine("Max=" + max);

            int g = (a > b) ? (a > c ? a : c) :( b > c ? b : c);
            Console.WriteLine("Largest number is" + g);

        }
    }
}
