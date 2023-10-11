using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile pf1 = new Profile("00000");
            pf1.Name = "Fred Smith";
            pf1.Telephone = "123456";
            pf1.Display();
        }

    }

    class Profile
    {
        string code, name, telephone;
        // Constructor
        public Profile(string c)
        {
            code = c;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Telephone
        {
            set { telephone = value; }
            get { return telephone; }
        }
        public void Display()
        {
            Console.WriteLine("Code: " + code + " Name: " +
                    name + " Telephone: " + telephone);
            Console.ReadLine();
        }
    }
}
