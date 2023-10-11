using System;

namespace Classes7
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class7
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// example of inheritance
			
			Staff p1 = new Staff();
			p1.Name="Fred"; // inherits this from People Class
			p1.ToLowerCase();// inherits this from People Class
			p1.Display();// from Staff Class

			Student s1 = new Student();
			s1.Name = "Rhys";
			s1.matricNumber = 40664301;
			s1.ToLowerCase();
			s1.Display();

            Console.ReadLine();
        }
	}
}
