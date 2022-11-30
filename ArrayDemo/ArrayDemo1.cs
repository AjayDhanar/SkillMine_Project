using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ArrayDemo
{
    class ArrayCreation
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 3;
            //int c = 78;

            int[] arr = { 5, 3, 2, 8 };
            int[] myarr = new int[4];
            /*myarr[0] = 7;
            myarr[1] = 3;
            myarr[2] = 12;
            myarr[3] = 4;*/

            Console.WriteLine("Enter the array elements");
            for(int i = 0; i <= myarr.Length; i++)
            {
                /*int x = int.Parse(Console.ReadLine());
                myarr[i] = x;*/
                myarr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(".....................................");

            for(int i = 0; i < myarr.Length; i++)
            {
                Console.WriteLine(myarr[i]);
            }
            //Console.WriteLine("The value of array is" + myarr);
            foreach(int ele in myarr)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine(" /////////////////////////");
            Console.WriteLine(string.Join(", ", myarr));
        }
    }
}
