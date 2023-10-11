using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace _2WayRelationDemo
{
    public class Car
    {
        private string aMake;
        private string aColour;

        private Person owner;
        //The owner of this car

        public void setOwner(Person owner){
            this.owner = owner;
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

      
        public void printDetails()
        {
            string output = "This car belongs to " + owner.name +
             " it  is a " + aColour + " " + aMake;
            MessageBox.Show(output);
            
        }
        
    }
}
