using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingInheritance
{
    class House : Building
    {
        private int _numberBedrooms;
        private int _numberBathrooms;

        // Constructors -  : base() Calls the Building class no-arg constructor
        public House() : base()
        {
            NumberBedrooms = 0;
            NumberBathrooms = 0;
        }

        // base(address, size) Calls the Building class arg constructor
        public House(string address, int size, int numberBedrooms, int numbrBathrooms) : base(address, size)
        {
            NumberBedrooms = numberBedrooms;
            NumberBathrooms = numbrBathrooms;
        }
        // New Properties, House still can access Building Properties Size and Address
        public int NumberBedrooms { get => _numberBedrooms; set => _numberBedrooms = value; }
        public int NumberBathrooms { get => _numberBathrooms; set => _numberBathrooms = value; }

        public override string ToString()
        {
            return base.ToString() + " It also has " + _numberBedrooms + " bedrooms " + _numberBathrooms + " baths.";
        }
    }
}
