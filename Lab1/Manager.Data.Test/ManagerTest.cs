using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Manager.Data.Test
{
    [TestClass]
    public class ManagerTest
    {
        [TestMethod]
        public void GivenActiveStatusBetweenStartDateAndEndDateShouldReturnTrue()
        {
            var manager = CreateSUT(new System.DateTime(2018, 10, 1), new System.DateTime(2019, 10, 15));
            var status = manager.IsActive();

            Assert.IsTrue(status);
        }

        [TestMethod]
        public void GivenActiveStatusBetweenStartDateAndEndDateShouldReturnFalse()
        {
            var manager = CreateSUT(new System.DateTime(2019, 10, 18), new System.DateTime(2018, 10, 15));
            var status = manager.IsActive();

            Assert.IsFalse(status);
        }

        private Manager CreateSUT(DateTime start, DateTime end)
        {
            return new Manager(Guid.NewGuid(), "ilie", "vasilica", start, end, 123.2);
        }
    }
}
