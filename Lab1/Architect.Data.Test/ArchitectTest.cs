using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Architect.Data.Test
{
    [TestClass]
    public class ArchitectTest
    {
        [TestMethod]
        public void GivenActiveStatusBetweenStartDateAndEndDateShouldReturnTrue()
        {
            var architect = CreateSUT(new System.DateTime(2018, 10, 1), new System.DateTime(2019, 10, 15));
            var status = architect.IsActive();

            Assert.IsTrue(status);
        }

        [TestMethod]
        public void GivenActiveStatusBetweenStartDateAndEndDateShouldReturnFalse()
        {
            var architect = CreateSUT(new System.DateTime(2019, 10, 18), new System.DateTime(2017, 10, 15));
            var status = architect.IsActive();

            Assert.IsFalse(status);
        }

        private Architect CreateSUT(DateTime start, DateTime end)
        {
            return new Architect(Guid.NewGuid(), "ilie", "vasilica", start, end, 123.2);
        }
    }
}
