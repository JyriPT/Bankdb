using BankDB.Models;
using BankDB.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Views
{
    class CustomerView : ICustomerView
    {
        private readonly ICustomerService _customerkService = new CustomerService();

        //Create customer entity
        public Customer CreateCustomer(Bank bank)
        {
            string input = String.Empty;
            Customer newCustomer = new Customer();

            do
            {
                Console.WriteLine("Enter first name of customer:");
                input = Console.ReadLine();
            } while (input == String.Empty);

            newCustomer.Firstname = input;
            input = String.Empty;

            do
            {
                Console.WriteLine("Enter surname of customer:");
                input = Console.ReadLine();
            } while (input == String.Empty);

            newCustomer.Lastname = input;

            newCustomer.BankId = bank.Id;

            var createdCustomer = _customerkService.Create(newCustomer);
            return createdCustomer;
        }
    }
}
