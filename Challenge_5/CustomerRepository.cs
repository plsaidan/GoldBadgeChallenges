using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class CustomerRepository
    {
        List<Customer> _listOfCustomers = new List<Customer>();

        public void AddCustomerToList(Customer customer)
        {
            _listOfCustomers.Add(customer);
        }
        public List<Customer> GetCustomerList()
        {
            return _listOfCustomers;
        }
        public void RemoveCustomer(Customer customers)
        {
            _listOfCustomers.Remove(customers);
        }
    }
}
