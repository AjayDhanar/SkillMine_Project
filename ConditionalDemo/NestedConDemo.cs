using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class NestedConDemo
    {
        static void Main(string[] args)
        {
            
            int year, marks;
            Console.WriteLine("Enter the year");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks");
            marks = int.Parse(Console.ReadLine());

            /*if(year==2022 && marks > 60)
            {
                Console.WriteLine("Candidate is selected for the interview");
            }
            else
            {
                Console.WriteLine("Candidate is NOT selected for the interview");
            }*/

            string ans = year == 2022 ? (marks > 60 ? "selected" : "not selected inner") : "not selected";
            Console.WriteLine(ans);

            /*if (year == 2022)
            {
                if (marks > 60)
                {
                    Console.WriteLine("Candidate is selected for the interview");
                }
                else
                {
                    Console.WriteLine("Marks is less than 60 so this is not selected");
                }
                
            }
            else
            {
                Console.WriteLine("Candidate is not selected for the interview");
            }*/

        }
    }

    class GrettestNo
    {
        static void Main(string[] args)
        {

        }
    }
}
