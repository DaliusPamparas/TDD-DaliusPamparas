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
        private TourSchedule sut;
        [SetUp]
        public void Setup()
        {
            sut = new TourSchedule();
        }

        [Test]
        public void CanCreateNewTour()
        {

            sut.CreateTour(
            "New years day safari",
            new DateTime(2013, 1, 1), 20);

            
            List<Tour> tours = sut.GetToursFor(new DateTime(2013, 1, 1));
            Assert.AreEqual(1, tours.Count);
        }
        [Test]
        public void ToursAreScheduledByDateOnly()
        {
            sut.CreateTour("New years day safari", 
                new DateTime(2013, 1, 1, 10, 15, 0), 20);

            List<Tour> tours = sut.GetToursFor(new DateTime(2013, 1, 1));
            Assert.AreEqual(1, tours.Count);

        }
        [Test]
        public void GetToursForGivenDayOnly()
        {
            sut.CreateTour("New years day safari",
                new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("New years day safari",
               new DateTime(2014, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("New years day safari",
               new DateTime(2015, 1, 1, 10, 15, 0), 20);

            List<Tour> tours = sut.GetToursFor(new DateTime(2015, 1, 1));
            Assert.AreEqual(1, tours.Count);

        }

        [Test]
        public void FindTourAllocationException()
        {
            sut.CreateTour("New years day safari",
                new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("New years day safari",
               new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("winter safari",
               new DateTime(2015, 1, 1, 10, 15, 0), 20);


            Assert.Throws<TourAllocationException>(() => sut.CreateTour("Winter safari", new DateTime(2013, 1, 1, 10, 15, 0), 20));

        }
    }
}