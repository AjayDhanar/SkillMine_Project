﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ArrayDemo
{
    class ArrayDemo2
    {
        public void DisplayEven(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter the array elements");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }

            ArrayDemo2 my = new ArrayDemo2();
            my.DisplayEven(a);


        }
    }
}
