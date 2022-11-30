using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.OOPs
{
    class MethodDemo

    {
        int num = 3;
        //AccessModifier return_type MethodName()
        //{

        //smt

        //}

        //no returntype No parameter
        public void Show()//Method defination
        {
            Console.WriteLine("hello show Method");
        }

        //No returntype with parameter
        public void Addition(int x,float y)
        {
            float ans = x + y;
            Console.WriteLine("ans="+ans);
        }

        public int SumOfFactor(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public double AreaOfCircle(int r,double PI)
        {
            double area = PI * r * r;
            return area;
        }

        public int FindCube()
        {
            return (num * num * num);
        }
        static void Main(string[] args)
        {
            MethodDemo d = new MethodDemo();
            d.Show();//Method calling
            d.Addition(5, 3.4f);

            /*int result = d.SumOfFactor(6);
            Console.WriteLine("Sumof Factor" + result);

            double are = d.AreaOfCircle(4, 3.14);
            Console.WriteLine("Area of Circle" + are);*/

            Console.WriteLine("SumofFactors=" + d.SumOfFactor(12));
            Console.WriteLine("Cube of number" + d.FindCube());
        }
    }

    class Car
    {
        int modelno;
        string carname;
        int carprize;
        string color;

        public void CarDetails()
        {
            
            Console.WriteLine("please Enter the Car Model no");

            modelno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Car Name");
            carname = Console.ReadLine();
            Console.WriteLine("Enter the Car Prize");
            carprize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Car Color");
            color = Console.ReadLine();

        }
        public void Show(int t)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine(t + "st Car Details");
            Console.WriteLine("The Car Details is her\nModel no= " + modelno + "\n Carname=" + carname + "\n CarPrize=" + carprize + "\nCar Color=" + color);
            Console.WriteLine("==================================================");
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine("How many Car Details do you want to print");
            int p = int.Parse(Console.ReadLine());
            for (int i = 1; i <= p; i++)
            {
                c.CarDetails();
                c.Show(i);

            }

            

        }
    }
}
