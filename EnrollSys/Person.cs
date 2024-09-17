using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace EnrollSys
{
    public class Person
    {
        public const string DEF_NAME = "Name";
        public const string DEF_EMAIL = "Email";
        public const string DEF_PN = "0";
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        public Person() : this(DEF_NAME,DEF_EMAIL,DEF_PN, new Address()) { }
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {PhoneNumber}, Address: {Address}";
        }
    }

}
