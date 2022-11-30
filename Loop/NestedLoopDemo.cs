using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.Loop
{
    class NestedLoopDemo
    {
        static void Main(string[] args)
        {
            /*for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 2; j++)
                {
                    Console.WriteLine(j);
                }
            }*/

            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("//////////////////////////");
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("/////////////////////First Pattern");
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("///////////////////////");
            for(int i =1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {

                    if (i == 1 || j == 1 || i == 5 || j == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("/////////////////////////");

            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'A'; j <= 'D'; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write((char)(j + 64));
                }
                Console.WriteLine();
            }
        }


    }
}
