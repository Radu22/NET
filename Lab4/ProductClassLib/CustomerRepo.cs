using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductClassLib
{
    public class CustomerRepo
    {
        protected readonly ApplicationContext Context;

        public CustomerRepo()
        {
            this.Context = new ApplicationContext();
        }

        public void Create(Customer customer)
        {
            Context.Customers.Add(customer);
            Context.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            Context.Customers.Remove(customer);
            Context.SaveChanges();
        }

        public ICollection<Customer> GetAll()
        {
            return this.Context.Customers.ToList();
        }

        public Customer GetById(Guid id)
        {
            return this.Context.Customers.First(t => t.Id == id);
        }

        public void Update(Customer customer)
        {
            var currentCustomer = Context.Customers.First(c => c.Id == customer.Id);
            Context.Customers.Update(currentCustomer);
            Context.SaveChanges();
        }

        public Customer GetCustomerByEmail(string email)
        {
            return Context.Customers.First(p => p.Email == email);
        }
    }
}
