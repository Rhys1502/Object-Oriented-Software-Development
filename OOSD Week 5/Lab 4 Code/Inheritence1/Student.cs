using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes7
{
    public class Student : People // Inherit from People
    {
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Matriculation Number: " + matricNumber);
        }
    }
}
