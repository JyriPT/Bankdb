﻿using BankDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Services
{
    public interface ICustomerService
    {
        Customer Create(Customer newCustomer);
    }
}
