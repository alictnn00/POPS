using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPS_System_Design.Classes
{
    public class Address
    {
        //Encapsulation
        private string _street;
        private string _city;
        private string _state;
        private string _zip;

        //Getters and Setters
        public string Street
        {
            get => _street;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Street is required");
                _street = value;
            }
        }

        public string City
        {
            get => _city;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("City is required");
                _city = value;
            }
        }

        public string State
        {
            get => _state;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("State is required");
                _state = value;
            }
        }

        public string Zip
        {
            get => _zip;
            set
            {
                if (!IsValidZip(value))
                    throw new ArgumentException("Invalid ZIP code");
                _zip = value;
            }
        }

        private bool IsValidZip(string zip)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(zip, @"^\d{5}$");
        }

        //Constructors
        public Address() 
        {

        }

        //ToString Override for DataGridView Display
        public override string ToString()
        {
            return $"{Street}, {City}, {State} {Zip}";
        }
    }
}
