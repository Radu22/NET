using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IProductRepo
    {
        void Create(Product product);

        void Update(Product product);

        void Delete(Product product);

        Product GetById(Guid id);

        ICollection<Product> GetAll();
    }
}
