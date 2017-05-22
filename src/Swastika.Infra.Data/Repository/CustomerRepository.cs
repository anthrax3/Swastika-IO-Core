﻿using System.Linq;
using Swastika.Domain.Interfaces;
using Swastika.Domain.Models;
using Swastika.Infra.Data.Context;

namespace Swastika.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>,  ICustomerRepository
    {
        public CustomerRepository(SwastikaContext context)
            :base(context)
        {

        }       

        public Customer GetByEmail(string email)
        {
            return Find(c => c.Email == email).FirstOrDefault();
        }
    }
}
