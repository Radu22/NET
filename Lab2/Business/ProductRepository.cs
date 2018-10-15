
using System;
using System.Collections.Generic;

namespace NET
{
    public class ProductRepository
    {
        private List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product(Guid.NewGuid(),"name1","description1", new DateTime(), new DateTime(), 23.1,12.1),
                new Product(Guid.NewGuid(),"name2","description2", new DateTime(), new DateTime(), 25.1,14.1),
                new Product(Guid.NewGuid(),"name3","description3", new DateTime(), new DateTime(), 26.1,13.1)
            };
        }
        public Product GetPoductByName(string productName)
        {
            return _products.Find(product => product.Name == productName);
        }

        public List<Product> FindAllProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            CheckIfProductIsNull(product);
            _products.Add(product);
        }

        public Product GetProductByPosition(int position)
        {
            return _products[position];
        }

        public void RemoveProductByName(string name)
        {
            var product = GetPoductByName(name);
            CheckIfProductIsNull(GetPoductByName(name));
            _products.Remove(product);
        }

        public int Capacity()
        {
            return _products.Count;
        }

        private void CheckIfProductIsNull(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}


