using BankDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Services
{
    public interface IBankService
    {
        Bank Create(Bank newBank);
        Bank Update(int id, Bank updateBank);
        void Delete(int id);
        Bank Read(int id);
    }
}
