using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{

    class OperatorDemo
    {
        static void Main(String[] args)
        {
            Console.WriteLine(5+6-2*4/2);//7
            //<,> <= ,>= , !=, ==
            int a = 10;
            int b = 20;
            int c = 40;
            Console.WriteLine(a > b);
            Console.WriteLine(a==b);
            //logical operator [  && ||  ]
            Console.WriteLine(a>b && a>c);
            Console.WriteLine(".............."+((b>a)||(b>c)));

            //assingment

            int x = 10;
            x += 2;//x=x+2;
            Console.WriteLine(x);
            x -= 3;//x=x-3
            x *= 2;//x=x*2
            x /= 4;//x=x/4

            x %= 2;//x=x%2

        }
    }
}
