﻿using App.Core.CustomerEntity.Entities;

namespace App.Domain.Core.CustomerEntity.Contracts
{
    public interface ICustomerAppService
    {
        public Customer CheckLogin(string Email, string Password);
    }
}