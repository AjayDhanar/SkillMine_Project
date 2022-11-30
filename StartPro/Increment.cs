using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class Increment
    {
        static void Main(String[] args)
        {



            int a = 2;
            int b = 2;
            //int x = ++a + b++;
            /*Console.WriteLine(x + " " + a + " " + b);//5,3,3
            x = a++ + b++ + a;
            Console.WriteLine(x + " " + a + " " + b);//10,4,4
*/          int x = ++a + ++b;
            Console.WriteLine(x + " " + a + " " + b);//6,3,3
            x = --a - --b;
            Console.WriteLine(x + " " + a + " " + b);//0,2,2
            x = a++ + b--;
            Console.WriteLine(x + " " + a + " " + b);//4,3,1
            x=++a - --b + b;
            Console.WriteLine(x + " " + a + " " + b);//4,4,0
            x = a++ + ++b + a;
            //Console.WriteLine(x+" ")


        }
    }
}
