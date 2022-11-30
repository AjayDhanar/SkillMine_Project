using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class ConditionDemo
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            if (n % 5 == 0)
            {
                Console.WriteLine("Number " + n + " is divisible by 5");

            }
            else
            {
                Console.WriteLine("Number is not divisible by 5");
            }

        }
    }
    class checkNo
    {
        static void Main(string[] args)
        {
            int u;
            Console.WriteLine("Enter the the no");
            u = int.Parse(Console.ReadLine());
            if (u > 0)
            {
                Console.WriteLine("Given no is positive");
            }
            else if (u < 0)
            {
                Console.WriteLine("Given no is Negative");
            }
            else
            {
                Console.WriteLine("Given no is Zero");
            }

        }


    }
    class ThreeNO
    {
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("Enter the the no");
            t = int.Parse(Console.ReadLine());
            if(t%3==0)
            {
                Console.WriteLine("No is divisible by 3");

            }
            else if(t%9==0)
            {
                Console.WriteLine("NO is divisible by 9");
            }
            else
            {
                Console.WriteLine("no is not divisible by both number");
            }

        }
    }

    class WeekDay
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter the day no of Week for print the Day name");
            day = int.Parse(Console.ReadLine());
            if (day == 1)
            {
                Console.WriteLine(" Monday =" + day);
            }
            else if (day == 2)
            {
                Console.WriteLine(" Tuesday =" + day);
            }
            else if (day == 3)
            {
                Console.WriteLine(" Wednesday =" + day);
            }
            else if (day == 4)
            {
                Console.WriteLine(" Thursday =" + day);
            }
            else if (day == 5)
            {
                Console.WriteLine(" Friday =" + day);
            }
            else if (day == 6)
            {
                Console.WriteLine(" Saturday =" + day);
            }
            else if (day == 7)
            {
                Console.WriteLine(" Sunday =" + day);
            }

        }
    }

    class EvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the value");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("number is Even");


            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }

    }


    class VowelDemo
    {

        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the char");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'o' || ch == 'e' || ch == 'i' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }




            /*if(ch=='a')
            {
                Console.WriteLine("Vowel");

            }
            else if(ch=='e')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='i')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='o')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }*/
        }

    }


}
