using BankDB.Data;
using BankDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankDB.Repositories
{
    class AccountRepository : IAccountRepository
    {
        private readonly BankdbContext _context;

        public AccountRepository()
        {
            _context = new BankdbContext();
        }

        public Account Create(Account newAccount)
        {
            try
            {
                _context.Account.Add(newAccount);
                _context.SaveChanges();
                return newAccount;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public List<Account> Read(Bank bank)
        {
            var accounts = _context
                .Account
                .Include(p => p.Bank)
                .ToList();
            return accounts;
        }
    }
}
