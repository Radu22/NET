using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface ICustomerRepo
    {
        void Create(Customer product);

        void Update(Customer product);

        void Delete(Customer product);

        Customer GetById(Guid id);

        ICollection<Customer> GetAll();
    }
}
