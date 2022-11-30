using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class SwappingNumber
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the value for num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the valu for num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine(num1 + " " + num2);

                

        }
    }
}
