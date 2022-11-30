using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Loop
{
    class WhileDemo2
    {
        static void Main(string[] args)
        {
            //find the sum of digit from the number
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;

            }
            Console.WriteLine("sum of digits =" + sum);

        }
    }

    class BreakConDemo
    {
        static void Main(string[] args)
        {
            /*int i = 1;
            while(i<=6)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;*/
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);

            }


        }
    }

    class GussingNumber
    {
        static void Main(string[] args)
        {
            int mgno = 66;
            while (true)
            {
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                if (num > mgno)
                {
                    Console.WriteLine("Number is larger than gussing number pls try again.....");
                    continue;
                }
                else if(num<mgno)
                {
                    Console.WriteLine("Number is less than gussing number please try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("wow gussing number is correct ..............!!!!!");
                    break;
                }

            }
        }
    }

    class PrimeNumber
    {
        static void Main(string[] args)
        {
            //check the number is prime or not
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("number is not prime");

                }
                else
                {

                }
            }
        }
    }

    class CheckNumber
    {
        static void Main(string[] args)
        {
            //check number is Armstrong or not
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + (digit * digit * digit);
                num = num / 10;

            }
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Not Armstrong");
            }
        }
    }
}
