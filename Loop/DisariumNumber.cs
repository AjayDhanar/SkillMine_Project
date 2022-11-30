using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Loop
{
    //find the sum of prime number between 1 to 10
    class PrimeNumberSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int num = 1; num <= 10; num++)
            {
                bool isprime = true;
                for(int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;

                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine("................" + num);
                    sum = sum + num;

                }
            }
            Console.WriteLine("Sum of Prime is =" + sum);
        }
    }
    class DisariumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int Dis = num;
            int sum = 0,count=0;
            while (num > 0)
            {
                
                num = num / 10;
                count++;
            }
            Console.WriteLine("Total length of  the number " + count);
            Dis = num;
            while (num > 0)
            {
                int digit = num % 10;

            }
        }
    }
}
