using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Product.Data.Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void GivenHigherStartDateThanEndDateShouldReturnFalse()
        {
            // Arrange + Act 
            var product = CreateSUT(new DateTime(2018, 10, 1), new DateTime(2019, 10, 26));
            var initial = product.IsValid;

            // Assert
            Assert.IsTrue(initial);        
        }

        [TestMethod]
        public void GivenHigherStartDateThanEndDateShouldReturnTrue()
        {
            // Arrange + Act 
            var product = CreateSUT(new DateTime(2019, 10, 29), new DateTime(2018, 10, 5));
            var initial = product.IsValid;

            // Assert
            Assert.IsFalse(initial);
        }

        private Product CreateSUT(DateTime start, DateTime end)
        {
            return new Product(Guid.NewGuid(), "product1", "tasty", start, end, 45.23, 5.8);
        }
    }
}
