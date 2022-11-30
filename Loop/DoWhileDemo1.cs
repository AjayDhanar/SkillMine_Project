using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Loop
{
    class DoWhileDemo1
    {
        static void Main(string[] args)
        {
            //initilization
            //do
            //{
            //logic smt
            //incremnet/decrement
            //}while(condition);

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i >= 10);
        }
    }


    class Menu
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Enter the 1st number");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the choice from following Menu");
                Console.WriteLine("1.Addition\n2. Substraction\n3.Multiplication\n4.Division");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num + num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction=" + (num - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + (num * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division=" + (num + num2));
                        break;
                }
                Console.WriteLine("Do you want to Continune Y/N...........");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'Y' || ch == 'y');
        }
    }

    //Sum of odd number between 1 to 20
    class SumOdd
    {
        static void Main(string[] args)
        {
            int sum = 0,i=1;
            do
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
                i++;
            } while (i <= 20);

            Console.WriteLine("the sum of odd no is =" + sum);
        }
    }
    //check the number is prime or not
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            //int count=0;
            bool isPrime = true;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    //count++;
                    isPrime = false;
                    break;
                }
                
            }
            if (isPrime == true)//(count==0)
            {
                Console.WriteLine("Number is Prime");
                
            }
            else
            {
                Console.WriteLine("NOt Prime");
            }

        }
    }
}
