using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            //switch (express)
            //{
            //case 1:
            //break;

            //case 2:
            //break;
            //default:
            //break;
            //}

            int dayno;
            Console.WriteLine("Enter the day number");
            dayno = int.Parse(Console.ReadLine());

            switch (dayno)
            {
                case 1: Console.WriteLine("Moday");
                    break;
                case 2: Console.WriteLine("Tueday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Invalid day number");
                    break;

            }
        }
    }
}
