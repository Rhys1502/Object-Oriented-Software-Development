using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit1
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Display()
        {
            Console.WriteLine("\n My name is " + name);
        }
    }
    class Staff : Person
    { // Inherit from People
        private string payroll;
        public string Payroll
        {
            get { return payroll; }
            set { payroll = value; }
        }

        public  void Display()
        {
            base.Display(); 
            Console.WriteLine("Payroll : " + payroll);
        }
    }

    class Student : Person
    {
        private string matric;
        public string MatricNumber
        {
            get { return matric; }
            set { matric = value; }
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Matric : " + MatricNumber);
        }
    }
    class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.Name = "Fred";
            p.Display();

            Staff employee = new Staff();
            employee.Name = "Neil";
            employee.Payroll = "ABC123";
            employee.Display();

            Student st = new Student();
            st.Name = "Jane";
            st.MatricNumber = "130001";
            st.Display();
            System.Console.ReadLine();
        }
    }
}
