using BankDB.Models;
using BankDB.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Services
{
    class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }

        public Account Create(Account newAccount)
        {
            var createdAccount = _accountRepository.Create(newAccount);
            return createdAccount;
        }
    }
}
