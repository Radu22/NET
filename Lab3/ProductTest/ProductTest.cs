using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductTest
{
    [TestClass]
    public class ProductTest
    {
        private List<Product> _products = new List<Product>();
        private ProductRepository productRepo;

        [TestMethod]
        public void GivenAListOfProductShouldRetriveActiveProducts()
        {
            CreateSUT();
            productRepo = new ProductRepository(_products);
            var activeCount = productRepo.RetrieveActiveProducts();
            
            Assert.IsTrue(activeCount.Count == 3);
        }

        [TestMethod]
        public void GivenAListOfProductShouldRetriveInactiveProducts()
        {
            CreateSUT();
            productRepo = new ProductRepository(_products);
            var activeCount = productRepo.RetrieveActiveProducts();

            Assert.IsTrue(activeCount.Count == 3);
        }

        [TestMethod]
        public void GivenAListOfProductShouldRetriveSortedByPrice()
        {
            CreateSUT();
            productRepo = new ProductRepository(_products);
            var currentList = _products.OrderBy(x => x.Price).ToList();
            var activeCount = productRepo.RetrieveAllOrderByPriceAscending();


            CollectionAssert.AreEqual(currentList, activeCount);
        }

        [TestMethod]
        public void GivenAListOfProductShouldRetriveSortedByPriceDesc()
        {
            CreateSUT();
            productRepo = new ProductRepository(_products);
            var currentList = _products.OrderByDescending(x => x.Price).ToList();
            var activeCount = productRepo.RetrieveAllOrderByPriceDescending();


            CollectionAssert.AreEqual(currentList, activeCount);
        }

        [TestMethod]
        public void GivenAListOfProductShouldRetriveByName()
        {
            CreateSUT();
            productRepo = new ProductRepository(_products);
            var activeCount = productRepo.RetriveAllByName("name");

            Assert.IsTrue(activeCount.Count == 5);
        }

        private void CreateSUT()
        {

            _products.Add(new Product(Guid.NewGuid(), "name1", "description1",
                new DateTime(2018, 10, 1), new DateTime(2018, 11, 1), 12.12));
            _products.Add(new Product(Guid.NewGuid(), "name2", "description2",
                new DateTime(2018, 10, 10), new DateTime(2018, 11, 10), 12.12));
            _products.Add(new Product(Guid.NewGuid(), "name3", "description3",
                new DateTime(2018, 10, 7), new DateTime(2018, 11, 22), 12.12));
            _products.Add(new Product(Guid.NewGuid(), "name4", "description4",
                new DateTime(2018, 11, 1), new DateTime(2018, 11, 1), 12.12));
            _products.Add(new Product(Guid.NewGuid(), "name5", "description5",
                new DateTime(2018, 12, 1), new DateTime(2018, 11, 1), 12.12));
            _products.Add(new Product(Guid.NewGuid(), "nasdasd", "asdasd",
                new DateTime(2019, 10, 1), new DateTime(2018, 11, 1), 12.12));
        }
    }
}
