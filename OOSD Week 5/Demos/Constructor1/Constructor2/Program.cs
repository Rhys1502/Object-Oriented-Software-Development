using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Colour = "Blue";
            car1.Make = "Ford";
            car1.Type = "Mondeo";
            car1.Country = "UK";
            car1.Cost = 15000;

            Car car2 = new Car("Ford", "Mondeo");
            car2.Colour = "Red";
            car2.Country = "UK";
            car2.Cost = 12000;

            Console.WriteLine("Car 1 : \n" +car1);//calls car1.ToString()
            Console.WriteLine("\nCar 2 : \n" +car2);//calls car2.ToString()

            Console.ReadKey();
        }
    }

    public class Car
	{


		public Car() {	}
        //Default constructor

		public Car(string m){
        //Constrcutor with one parameter
			Make=m;
		}

		public Car(string m, string t) {
        //Constructor with two parameters
			Make=m; 	
            Type=t;
		}

        public Car(int ownerID, string m)
        {
        }

        //Properties
        public string Colour { get; set; }
        public string Type{ get; set; }
        public string Make { get; set; }
        public string Country { get; set; }
        public int Cost { get; set; }

        //toString mtheod

        public override string ToString()
            /*
             * The ToString method is a method that is declared for all classes, it is called whenever the 
             * the object is converted to a string (e.g. when printed in the example above).
             * Because ToString() is already declared as part of the C# Class structure we use use
             * the override keyword to ensure that it is this version of toString() that is called
             */
        {
            return "Make " + Make + "\nType " + Type + "\nColour " + Colour + "\nCountry " + Country + "\nCost " + Cost; 
        }
    }
}
