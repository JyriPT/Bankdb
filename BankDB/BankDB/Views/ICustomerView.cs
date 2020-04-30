using BankDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Views
{
    public interface ICustomerView
    {
        Customer CreateCustomer(Bank bank);
    }
}
