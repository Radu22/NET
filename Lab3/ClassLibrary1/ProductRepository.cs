using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class ProductRepository
    {
        private List<Product> _products;

        public ProductRepository(List<Product> products)
        {
            _products = products;
        }

        public List<Product> RetrieveActiveProducts()
        {
            return _products.Where(p => p.StartDate < DateTime.Now && p.EndDate > DateTime.Now).ToList();
        }

        public List<Product> RetrieveInactiveProducts()
        {
            return _products.Where(p => p.StartDate >= DateTime.Now || p.EndDate <= DateTime.Now).ToList();
        }

        public List<Product> RetrieveAllOrderByPriceDescending()
        {
            return _products.OrderByDescending(x => x.Price).ToList();
        }

        public List<Product> RetrieveAllOrderByPriceAscending()
        {
            return _products.OrderBy(x => x.Price).ToList();
        }

        public List<Product> RetriveAllByName(string name)
        {
            return _products.Where(x => x.ProductName.Contains(name)).ToList();
        }

        public List<Product> RetriveAllByDate(DateTime startDate, DateTime endDate)
        {
            return _products.Where(x => x.StartDate == startDate && x.EndDate == endDate).ToList();
        }

        public void Add(Product product)
        {
            if(product!=null)
            {
                _products.Add(product);
            }
        }

    }
}
