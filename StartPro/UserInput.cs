using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class UserInput
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the value");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + 3);


            Console.WriteLine("Enter the percentage");
            float per = float.Parse(Console.ReadLine());
            Console.WriteLine("per=" + per);

            int num1;
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1);
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);



            char ch;
            Console.WriteLine("Enter the char");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);


        }
    }
}
