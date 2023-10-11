using System;
using System.ComponentModel;

namespace Classes5
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{

            AnotherCar car1 = new AnotherCar();// contructor method with no arguments passed
            car1.Colour = "White";
            car1.Make = "Vauxhall";
            car1.Type = "Corsa";
            car1.Cost = 15000;

            AnotherCar car2 = new AnotherCar();// contructor method with no arguments passed
            car2.Colour = "Red";
            car2.Make = "Ford";
            car2.Type = "Mondeo";
            car2.Cost = 35000;

            AnotherCar car3 = new AnotherCar();// contructor method with no arguments passed
            car3.Colour = "Black";
            car3.Make = "Renault";
            car3.Type = "Clio";
            car3.Cost = 65000;


            car1.Display();
            car2.Display();
            car3.Display();

            Console.ReadLine();

        }
	}
}
