using BankDB.Models;
using BankDB.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Services
{
    class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }
        public Customer Create(Customer newCustomer)
        {
            var createdCustomer = _customerRepository.Create(newCustomer);
            return createdCustomer;
        }
    }
}
