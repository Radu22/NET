using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Query
    {
        private IEnumerable<Product> _products;

        public Query(List<Product> products)
        {
            _products = products;
        }

        public IEnumerable<Product> RetrieveActiveProducts()
        {
            return from p in _products
                   where p.StartDate < DateTime.Now &&
                    p.EndDate > DateTime.Now
                   select p;
        }

        public IEnumerable<Product> RetrieveInactiveProducts()
        {
            return from p in _products where p.StartDate >= DateTime.Now || p.EndDate <= DateTime.Now
                   select p;
        }

        public IEnumerable<Product> RetrieveAllOrderByPriceDescending()
        {
            return from p in _products orderby p.Price descending select p;
        }

        public IEnumerable<Product> RetrieveAllOrderByPriceAscending()
        {
            return from p in _products orderby p.Price select p;
        }

        public IEnumerable<Product> RetriveAllByName(string name)
        {
            return from p in _products where p.ProductName.Contains(name) select p;
        }

        public IEnumerable<Product> RetriveAllByDate(DateTime startDate, DateTime endDate)
        {
            return from p in _products where p.StartDate == startDate && p.EndDate == endDate select p;
        }
    }
}
