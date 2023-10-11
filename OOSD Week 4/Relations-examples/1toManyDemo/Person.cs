using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _1toManyDemo
{
    class Person
    {
        private string aName;
        private string anAddress;
        private List<Car> owns = new List<Car>();

        public Person()
        {
           
        }

        public void ownsCar(Car newCar)
        {
            owns.Add(newCar);
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


        public void showCars()
        {
            foreach (Car c in owns)
            {
                MessageBox.Show(c.printDetails());
            }
        }

    }
}
