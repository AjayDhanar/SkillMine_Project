using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Loop
{
    class KrishnaMurthiNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                int fact = 1;
                for(int i = 1; i <= digit; i++)
                {
                    fact = fact * i;

                }
                sum = sum + fact;
                num = num / 10;
            }

            // Console.WriteLine(sum);
            if (temp == sum)
            {
                Console.WriteLine("Number is KrishnaMurthiNumber");

            }
            else
            {
                Console.WriteLine("Number is not the KrishnaMurthiNumber");
            }
        }
    }
}
