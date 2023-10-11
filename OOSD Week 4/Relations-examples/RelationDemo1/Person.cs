using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RelationDemo1
{
    class Person
    {
        private string aName;
        private string anAddress;
        private Car owns;

        public Person()
        {

        }

        public void addCar()
        {
            owns = new Car();
            owns.colour = "Red";
            owns.make = "Ford";
        }

        public void showCar()
        {
            MessageBox.Show(owns.printDetails());
        }

        public string name
        {
            get
            {
                return aName;
            }
            set
            {
                aName = value;
            }
        }

        public string address
        {
            get
            {
                return anAddress;
            }
            set
            {
                anAddress = value;
            }
        }
    }
    
}
