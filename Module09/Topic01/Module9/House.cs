using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public class House
    {
        /*
         *   In this assignment, you will use the class Address as property in your class House. (This is composition)
         *   Find the House class example, add to a file House.cs.
         *   Replace class string property with a variable of type Address, the class that you created.
         *   What do you need to change in the Constructor? Change that and add a comment on what you changed and why. 
         *   How will the property Address look with get and set? Add the needed code and don't forget to remove the string property get and set. Add a comment on the get and set.
         *   Submit House.cs and Address.cs files
         *   This is 10 points.
         */

        // fields 
        // Replace class string property with a variable of type Address.
        private Address _houseAddress;  // some confusion for me on naming convention, it appears some of the video conflict some of what is written hince my confusion
        private int _numberBedrooms;
        private int _numberBathrooms;

        // Constructors
        public House(int addressNumber, string addressStreet, string addressAptNum, string city, string state, int zipcode) // default no-arg
        {
            // What do you need to change in the Constructor? Change that and add a comment on what you changed and why.
            // call the Address class default constructor and provide it's required parameter args
            _houseAddress = new Address(addressNumber, addressStreet, addressAptNum, city, state, zipcode);
            NumberBedrooms = 0;
            NumberBathrooms = 0;
        }

        public House(int addressNumber, string addressStreet, string addressAptNum, string city, string state, int zipcode, int numberBedrooms, int numberBathrooms)
        {
            _houseAddress = new Address(addressNumber, addressStreet, addressAptNum, city, state, zipcode);
            NumberBathrooms = numberBedrooms;
            NumberBedrooms = numberBathrooms;
        }

        // How will the property Address look with get and set? Add the needed code and don't forget to remove the string property get and set. Add a comment on the get and set.
        // HIDE Address from House Class
        public Address HouseAddress { get => _houseAddress; set => _houseAddress = value; }
        public int NumberBedrooms { get => _numberBedrooms; set => _numberBedrooms = value; }
        public int NumberBathrooms { get => _numberBathrooms; set => _numberBathrooms = value; }

        public override string ToString()
        {
            // call Address class override ToString on Address 
            return ("House at " + _houseAddress.ToString() + " has " + NumberBedrooms + " bedrooms and " + NumberBathrooms + " bathrooms.");
        }
    }
}
