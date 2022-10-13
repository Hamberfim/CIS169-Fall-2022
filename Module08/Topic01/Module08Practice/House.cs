using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Practice
{
    public class House
    {
        // properties
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

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int NumberBathrooms
        {
            get { return _numberBathrooms; }
            set { _numberBathrooms = value; }
        }

        public int NumberBedrooms
        {
            get { return _numberBedrooms; }
            set { _numberBedrooms = value; }
        }

        public override string ToString()
        {
            return ("House at " + Address + " has " + NumberBedrooms + " bedrooms and " + NumberBathrooms + " bathrooms.");
        }

    }
}
