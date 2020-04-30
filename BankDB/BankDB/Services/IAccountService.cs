using BankDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Services
{
    public interface IAccountService
    {
        Account Create(Account newAccount);
        List<Account> Read(Bank bank);
    }
}
