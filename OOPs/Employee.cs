using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.OOPs
{
    class Employee
    {
        int id;
        string ename;
        int salary;
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.id = 200;
            emp.ename = "Queen";
            emp.salary = 900000;
            Console.WriteLine(emp.id + " " + emp.ename + " " + emp.salary);

            Employee emp2 = new Employee();
            emp2.id = 102;
            emp2.ename = "Ajay";
            emp2.salary = 80000;
            Console.WriteLine(emp2.id + " " + emp2.ename + " " + emp2.salary);
        }
    }
}
