using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Loop
{
    class LoopDemo2
    {
        static void Main(string[] args)
        {
            //find the sum of even numbers between 1 to 10

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    sum = sum + i;
            }

            Console.WriteLine("sum= " + sum);
        }
    }

    class Number
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class RevN
    {
        static void Main(string[] args)
        {
            for (int i = 75; i >= 61; i--)
            {
                Console.WriteLine(i);
            }
        }
    }

    class No
    {
        static void Main(string[] args)
        {
            for (int i = 120; i <= 200; i++)
                Console.WriteLine(i);
        }
    }

    class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("sum is=" + sum);
        }
    }
    class Odd
    {
        static void Main(string[] args)
        {
            for (int i = 120; i <= 181; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("the odd no is" + i);
                }
            }
        }
    }

    class CountOdd
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    count += 1;
                    Console.WriteLine("Odd no" + i);
                }
            }
            Console.WriteLine("Total odd no between 1 to 20 is" + count);
        }
    }

    class TableNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no for table");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Here the table of " + t);
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine((t * i) + "=" + t);
            }
        }
    }

    class Div
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number is ");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class SumFact
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the value of number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int i, sum = 0;
            for (i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + ",");
                    sum = sum + i;
                }
            }
            Console.WriteLine("The Sum of the " + sum);
            Console.ReadKey();

        }
    }



    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of number= " + fact);
        }
    }


    class Calculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent");
            int expo = int.Parse(Console.ReadLine());
            int power = 1;
            for(int i = 1; i <= expo; i++)
            {
                power = power * baseNumber;

            }
            Console.WriteLine(power);
                
        }
    }
}
