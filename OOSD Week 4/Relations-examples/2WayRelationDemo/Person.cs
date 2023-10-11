using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayRelationDemo
{
    public class Person
    {
        private string aName;
        private string anAddress;
        private Car owns;

        public Person()
        {
            name = "Neil";
        }

        public void ownsCar(Car newCar)
        {
            owns = newCar;
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

        private void AddCar()
        {
            owns = new Car();
            owns.setOwner(this);
            owns.colour = "Red";
            owns.make = "Ford";
        }

        private void ShowCar()
        {
            owns.printDetails();
        }
    }
}
