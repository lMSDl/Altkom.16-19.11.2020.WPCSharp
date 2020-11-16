﻿using System.Collections.Generic;
using System.Linq;

namespace WPCSharp.DesignPrinciples
{
    public class CustomerService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };
        public Customer FindCustomerById(int customerId)
        {
            return Customers.SingleOrDefault(x => x.Id == customerId);
        }
    }
}
