using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1toManyDemo
{
    public class Car
    {
        private string aMake;
        private string aColour;

        //Constructor
        public Car(string mycolour, string mymake)
        {
            colour = mycolour;
            make = mymake;
        }
        public string colour{
            get{
                return aColour;
            }
            set{
                aColour = value;
            }
        }

        public string make{
            get{
                return aMake;
            }
            set{
                aMake = value;
            }
        }

      
        public string printDetails()
        {
            return "My car is a " + aColour + " " + aMake;
        }
        
    }
}
