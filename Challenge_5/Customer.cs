using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public enum CustomerType { Potenial = 1, Current, Past }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType CustomerType { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string lastName, CustomerType customerType, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerType = customerType;
            Email = email;
        }
        public Customer()
        {
        
        }
    }
}
