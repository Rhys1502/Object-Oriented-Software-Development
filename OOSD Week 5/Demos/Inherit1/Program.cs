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
        public void ToLowerCase()
        {
            name = name.ToLower();
        }
    }
    class Staff : Person
    { // Inherit from Person
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    class Program
    {
        static void Main()
        {
            Staff p1 = new Staff();
            p1.Name = "FRED";
            p1.ToLowerCase();
            p1.Display();
            System.Console.ReadLine();
        }
    }
}
