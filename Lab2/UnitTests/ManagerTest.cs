using FluentAssertions;
using NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class Managertest
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

        private Manager CreateSUT(DateTime start, DateTime end)
        {
            return new Manager(Guid.NewGuid(),"123", "213", start, end, 34.12);
        }
    }
}
