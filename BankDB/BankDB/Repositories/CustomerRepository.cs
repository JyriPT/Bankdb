using BankDB.Data;
using BankDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Repositories
{
    class CustomerRepository : ICustomerRepository
    {
        private readonly BankdbContext _context;

        public CustomerRepository()
        {
            _context = new BankdbContext();
        }

        public Customer Create(Customer newCustomer)
        {
            try
            {
                _context.Customer.Add(newCustomer);
                _context.SaveChanges();
                return newCustomer;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
    }
}
