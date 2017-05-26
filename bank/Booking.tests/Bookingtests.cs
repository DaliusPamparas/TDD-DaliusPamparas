using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Booking.tests
{
    [TestFixture]
    public class Bookingtests
    {
        [Test]
        public void CanMakeABookingOnAnOpenDay()
        {
            var sut = new Booking.booking();
            sut.OpenOn(new DateTime(2012, 10, 14));
            sut.MakeBooking("Dave",
            new DateTime(2012, 10, 14, 10, 0, 0),
            TimeSpan.FromMinutes(45));
            var bookings = sut.GetBookingsFor(new DateTime(2012, 10, 14));
            Assert.AreEqual(1, bookings.Count, "Have a single booking");
            Assert.AreEqual("Dave", bookings[0].Name);
        }
    }
}
