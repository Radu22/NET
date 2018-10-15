using FluentAssertions;
using NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void When_ClassIsInstanciated_ThenShould_Have3Elements()
        {
            var ProductRepository = new ProductRepository();
            
            // Assert
            Assert.IsTrue(ProductRepository.Capacity() == 3);
        }
        
         [TestMethod]
         public void WhenTheSearchProductByNameShouldReturnRightProduct()
         {
             var ProductRepository = new ProductRepository();
             // Assert             
             Assert.IsTrue(ProductRepository.GetPoductByName("name1").Name.ToString() == "name1" );
         }

        [TestMethod]
         public void WhenAddingOneProductShouldGet4Products()
         {
             var ProductRepository = new ProductRepository();
             // Assert         
             Product product = new Product(new Guid(), "name4", "description4", new DateTime(), new DateTime(), 226.1,14.2);
             ProductRepository.AddProduct(product);    
             Assert.IsTrue(ProductRepository.Capacity() == 4) ;
         }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_AddedNullProduct_ThenShould_ThrowException()
        {
            // Arrange && Act
            var ProductRepository = new ProductRepository();
            ProductRepository.AddProduct(null);
        }

        [TestMethod]
         public void WhenGetProductByPositionZeroShouldGetFirstProduct()
         {
             var ProductRepository = new ProductRepository();
             // Assert           
             Assert.IsTrue(ProductRepository.GetProductByPosition(0).Name.ToString() == "name1") ;
         }

        [TestMethod]
         public void WhenRemoveOneProductfromProductRepositoryShouldHaveOnlyTwoProducts()
         {
             var ProductRepository = new ProductRepository();
             // Assert           
             ProductRepository.RemoveProductByName("name1");
             Assert.IsTrue(ProductRepository.Capacity() == 2) ;
         }

         [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_RemoveNullProduct_ThenShould_ThrowException()
        {
            // Arrange && Act
            var ProductRepository = new ProductRepository();
            ProductRepository.RemoveProductByName(null);
        }
    }
}
