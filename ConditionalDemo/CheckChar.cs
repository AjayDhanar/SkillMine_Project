using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class CheckChar
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')//(ch >= 'A' && ch <= 'Z')|| (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("Small Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Digit");

            }
            else
            {
                Console.WriteLine("Special Char");
            }
        }
    }
    
}
