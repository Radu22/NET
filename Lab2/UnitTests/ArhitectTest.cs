using FluentAssertions;
using NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class ArhitectTest
    {
        [TestMethod]
        public void GivenDateTimeNowLowerThanEndDateAndHigherThanStartDateShouldReturnTrue()
        {
           var arhitect = CreateSUT(new DateTime(2018, 10, 1), new DateTime(2018, 10, 29));

           arhitect.IsActive().Should().Be(true);
        }

        [TestMethod]
        public void GivenDateTimeNowHigherThanEndDateAndLowerThanStartDateShouldReturnFalse()
        {
           var arhitect = CreateSUT(new DateTime(2018, 10, 29), new DateTime(2018, 10, 1));

           arhitect.IsActive().Should().Be(false);
        }

        private Arhitect CreateSUT(DateTime start, DateTime end)
        {
            return new Arhitect(Guid.NewGuid(),"123", "213", start, end, 34.12);
        }
    }
}
