using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class SwitchDemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the city name");
            string city = Console.ReadLine();
            switch (city)
            {
                case "pune": Console.WriteLine("Welcome to Pune");
                    break;
                case "Mumbai": Console.WriteLine("Welcome to Mumbai");
                    break;
                case "Dehli": Console.WriteLine("Welcome to Dehlli");
                    break;
                case "Banglor": Console.WriteLine("Welcome to Banglor");
                    break;
                case "Bhopal": Console.WriteLine("Welcome to Bhopal");
                    break;
                default: Console.WriteLine("Enter city is wrong");
                    break;

            }
        }
    }
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int b = int.Parse(Console.ReadLine());

            switch (b%2)
            {
                case 0: Console.WriteLine("Even");
                    break;
                default: Console.WriteLine("Odd");
                    break;

            }
        }
    }
    class Vowel
    {
        static void Main(string[] args)
        {
            char v;
            Console.WriteLine("Enter the charcter");
            v = Convert.ToChar(Console.ReadLine());

            switch (v)
            {
                case 'a': Console.WriteLine("Vowel"+v);
                    break;
                case 'e':
                    Console.WriteLine("Vowel" + v);
                    break;
                case 'i':
                    Console.WriteLine("Vowel" + v);
                    break;
                case 'o':
                    Console.WriteLine("Vowel" + v);
                    break;
                case 'u':
                    Console.WriteLine("Vowel" + v);
                    break;
                default:
                    Console.WriteLine("Consonent" + v);
                    break;
                    
            }
        }
    }
    class Calculator
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the num1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Num2");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subtraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            Console.WriteLine("Enter the Number for Perform the Operation");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Add" + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Sub" + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Mul" + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Divi" + (a / b));
                    break;
                default:
                    Console.WriteLine("Wrong Choice in the menu");
                    break;
            }
        }
    }
}
