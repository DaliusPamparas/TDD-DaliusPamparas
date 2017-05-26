using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TravelAgency;


namespace TravelAgencyTests
{
    [TestFixture]
    class TourScheduleTests
    {
        [Test]
        public void CanCreateNewTour()
        {
            var sut = new TourSchedule();
            sut.CreateTour(
            "New years day safari",
            new DateTime(2013, 1, 1), 20);

        }
    }
