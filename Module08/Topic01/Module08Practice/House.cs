using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08House
{
    public class House
    {
        // Properties/Fields
        private string _address;
        private int _numberBathrooms;
        private int _numberBedrooms;

        // no arg constructor
        public House()
        {
            _address = "";
            _numberBathrooms = 0;
            _numberBedrooms = 0;
        }

        // arg constructor
        public House(string address, int numberBathrooms, int numberBedrooms)
        {
            _address = address;
            _numberBathrooms = numberBathrooms;
            _numberBedrooms = numberBedrooms;
        }

        //Properties with public access to set and get values 
        public string Address { get => _address; set => _address = value; }
        public int NumberBedrooms { get => _numberBedrooms; set => _numberBedrooms = value; }
        public int NumberBathrooms { get => _numberBathrooms; set => _numberBathrooms = value; }

        // ToString override for display
        public override string ToString()
        {
            return ("House at " + Address + " has " + NumberBedrooms + " bedroom(s) and " + NumberBathrooms + " bathroom(s).");
        }

    }
}
