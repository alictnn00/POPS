using POPS_System_Design.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POPS_System_Design.Classes
{
    public class Customer
    {
        //Encapsulation
        private int _customerID;

        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;

        //PK
        public int CustomerID
        {
            get => _customerID;
            set => _customerID = value;
        }

        //Personal Information
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First Name is required");
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last Name is required");
                _lastName = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("Valid email required");
                _email = value;
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                if (!IsValidPhone(value))
                    throw new ArgumentException("Invalid phone number");
                _phone = value;
            }
        }

        //Address Information
        public Address Address { get; set; }

        //Constructors
        
        public Customer()
        {

        }
        public Customer(string firstname,string lastname, string email, string phone, Address address)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Address = address ?? throw new ArgumentException("Address required");
        }


        //Helper Methods
        private bool IsValidPhone(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                phone, @"^\(?\d{3}\)?[-\s]?\d{3}[-\s]?\d{4}$");
        }
    }
}
