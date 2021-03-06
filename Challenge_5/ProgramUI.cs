﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class ProgramUI
    {
        CustomerRepository _customerRepo = new CustomerRepository();

        public void Run()
        {
            RunMenu();
        }
        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome To Komodo's brand new Mass Emailing System, What would you like to do today?" +
                    "\n1. Add Person to Mailing List" +
                    "\n2. Read Mailing List" +
                    "\n3. Remove Person from Mailing List" +
                    "\n4. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddtoMailingList();
                        break;
                    case 2:
                        ViewMailingList();
                        break;
                    case 3:
                        UpdateMailingList();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using Komodo's Mass Emailing System");
                        Console.ReadLine();
                        isRunning = false;
                        break;
                }
            }
        }
        public void AddtoMailingList()
        {
            Console.Clear();
            Customer customer = new Customer();
            Console.WriteLine("What is This Person's First Name?");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine("What is this person's Last Name?");
            customer.LastName = Console.ReadLine();

            Console.WriteLine("What Type of Customer is this person? Please choose" +
                "\n1. Potential" +
                "\n2. Current" +
                "\n3. Past");
            int intput = int.Parse(Console.ReadLine());
            switch (intput)
            {
                case 1:
                    customer.CustomerType = CustomerType.Potenial;
                    customer.Email = "We currently have the lowest rates on Helicopter Insurance!";
                    break;
                case 2:
                    customer.CustomerType = CustomerType.Current;
                    customer.Email = "Thank you for your work with us. We appreciate your loyalty. Here's a coupon";
                    break;
                case 3:
                    customer.CustomerType = CustomerType.Past;
                    customer.Email = "It's been a long time since we've heard from you, we want you back";
                    break;
            }

            _customerRepo.AddCustomerToList(customer);

        }
        public void ViewMailingList()
        {
            Console.Clear();
            List<Customer> customerList = _customerRepo.GetCustomerList();
            Console.WriteLine("First Name\tLast Name\tType\t\tEmail");
            var orderedList = customerList.OrderBy(c => c.LastName).ToList();
            foreach (Customer customer in orderedList)
            {
                Console.WriteLine($"{customer.FirstName}\t\t{customer.LastName}\t\t{(CustomerType)customer.CustomerType}\t\t{customer.Email}");
            }
            Console.ReadLine();
        }
        public void UpdateMailingList()
        {
            List<Customer> customers = _customerRepo.GetCustomerList();
            ViewMailingList();

            Console.WriteLine("Please Enter The First Name of the Customer you wish to Remove And Update");
            var Name1 = Console.ReadLine();
            Console.WriteLine("Customer Name Recieved, Press Enter");
            foreach (Customer customer in customers.ToList())
            {
                if (Name1 == customer.FirstName)
                    _customerRepo.RemoveCustomer(customer);
            }

            Console.Clear();
            Console.WriteLine("Alright Lets get This fixed");
            AddtoMailingList();
        }
    }
}
