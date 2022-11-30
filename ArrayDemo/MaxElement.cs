using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ArrayDemo
{
    class MaxElement
    {
        public int FindMax(int[] a)
        {
            int max = 0;
            //int min = int.MaxValue;

            for(int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;

        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 7, 2, 8, 1 };
            MaxElement m = new MaxElement();
            Console.WriteLine("Max From array" + m.FindMax(arr));
        }
    }
}
