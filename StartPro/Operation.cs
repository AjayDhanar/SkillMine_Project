using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class Operation

    {
        static void Main(String[] args)
        {
            // Area of Rectangel
            int l, b;
            l = 5;
            b = 6;
   
            Console.WriteLine("Area of Rectangle=" + (l * b));

            // Area of circle
            double pi = 3.14;
            int r = 4;
            Console.WriteLine("Area of the Circle=" + (pi * r *r));

            // Arithmatic operation
            int a, c;
            a = 10;
            c = 20;
            Console.WriteLine("Addition is=" + (a + c));
            Console.WriteLine("Subtraction is=" + (a - c));
            Console.WriteLine("Multiplication is=" + (a * c));
            Console.WriteLine("Division is=" + (a / c));





        }
    }


}