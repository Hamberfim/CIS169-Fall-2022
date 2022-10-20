using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Name         : Module9 - Address Class
* Author       : Anthony Hamlin
* Created      : 10/20/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is an address model  
*                      Input: Example data provided by instructor: 
*                           "123 Main Street Apt J2
*                            Small Town, Iowa 55555"
*                      Output: string of address based on information provided by instructor
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace Module9
{
    public class Address
    {
        // Fields
        private int _addressNumber;
        private string _addressStreet;
        private string _addressAptNum;
        private string _city;
        private string _state;
        private int _zipcode;

        // Constructors
        public Address() { }
        public Address(int addressNumber, string addressStreet, string addressAptNum, string city, string state, int zipcode)
        {
            _addressNumber = addressNumber;
            _addressStreet = addressStreet;
            _addressAptNum = addressAptNum;
            _city = city;
            _state = state;
            _zipcode = zipcode;
        }


        // Field Properties
        public int AddressNumber
        {
            get => _addressNumber; set => _addressNumber = value;
        }

        public string AddressStreet
        {
            get => _addressStreet; set => _addressStreet = value;
        }

        public string AddressAptNum
        {
            get => _addressAptNum; set => _addressAptNum = value;
        }

        public string City
        {
            get => _city; set => _city = value;
        }

        public string State
        {
            get => _state; set => _state = value;
        }

        public int Zipcode
        {
            get => _zipcode; set => _zipcode = value;
        }


        // add any necessary methods
        public override string ToString()
        {
            return $"{AddressNumber} {AddressStreet} {AddressAptNum}\n{City}, {State} {Zipcode}";
        }
    }
}
