using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.OOPs
{
    class Student
    {
        int id;
        string name;
        double marks;
        public void AcceptDetails(int sid,string sname,double mk)
        {
            id = sid;
            name = sname;
            marks = mk;

        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + marks);
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.AcceptDetails(100, "Ajay", 78.56);
            s.Display();
        }
    }
}
