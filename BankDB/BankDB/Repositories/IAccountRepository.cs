using BankDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Repositories
{
    public interface IAccountRepository
    {
        Account Create(Account newAccount);
    }
}
