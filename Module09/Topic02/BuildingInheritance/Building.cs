using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingInheritance
{
    public class Building
    {
        private string _address;
        private double _size; // in square feet

        // Constructors
        public Building()
        {
            Address = "unknown";
            Size = 0.0;
        }
        public Building(string address, double size)
        {
            Address = address;
            Size = size;
        }
        // Properties    
        public string Address { get => _address; set => _address = value; }
        public double Size { get => _size; set => _size = value; }
        // Methods
        public override string ToString()
        {
            return "Buidling at " + Address + " is " + Size.ToString() + " ft^2.";
        }
    }
}
