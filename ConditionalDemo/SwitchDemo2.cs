using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class SwitchDemo2
    {
        static void Main(string[] args)
        {
            int a, b;
            char op;
            Console.WriteLine("Enter the num1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Num2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operato");
            op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("(+) Addition");
            Console.WriteLine("(-) Subtraction");
            Console.WriteLine("(*) Multiplication");
            Console.WriteLine("(/) Division");
            Console.WriteLine("Enter the operator (Sign) for Operation");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine("Add" + (a + b));
                    break;
                case '-': Console.WriteLine("Sub" + (a - b));
                    break;
                case '*': Console.WriteLine("Mul" + (a * b));
                    break;
                case '/': Console.WriteLine("Divi" + (a / b));
                    break;
                default: Console.WriteLine("Wrong Choice in the menu");
                    break;


            }

        }
    }
}
