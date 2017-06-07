using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyExerciseFour;

namespace TravelAgencyExerciseFourTests
{
    [TestFixture]
    [Category("ExerciseFour TourScheduleTests")]
    public class TourScheduleTests
    {
        private TourSchedule sut;
        [SetUp]
        public void Setup()
        {
            sut = new TourSchedule();
        }
        [Test]
        public void CanCreateANewTour()
        {
            
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1), 20);

            var result = sut.GetToursFor(new DateTime(2013, 1, 1));

            
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("New years day safari", result[0].NameOfTour);
            Assert.AreEqual(20, result[0].NumberOfSeats);

        }

        [Test]
        public void ToursScheduledByDateOnly()
        {
           
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            var result = sut.GetToursFor(new DateTime(2013, 1, 1));

          
            Assert.AreEqual(new DateTime(2013, 1, 1), result[0].DateOfTour.Date);
        }

        [Test]
        public void GetToursForGivenDayOnly()
        {
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("May safari", new DateTime(2013, 5, 1, 10, 15, 0), 20);
          
            sut.CreateTour("April safari", new DateTime(2013, 4, 1, 10, 15, 0), 20);

            var result = sut.GetToursFor(new DateTime(2013, 4, 1));

            Assert.AreEqual(new DateTime(2013, 4, 1), result[0].DateOfTour.Date);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void ThrowsExceptionWhenThereIsMoreThanOneTourPerDay()
        {
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("New safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("Winter safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);

            Assert.Throws<TourAllocationException>(() => sut.CreateTour("Winter safari", new DateTime(2013, 1, 1, 10, 15, 0), 20));
        }

       

       
        [Test]
        public void ScheduleSameNameAndDateThrowException()
        {
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);


            Assert.Throws<SameNameSameDateException>(() =>
                sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20));
        }

          [Test]
        public void ShouldThrowExceptionWhenSeatsAreZeroOrNegative()
        {

            Assert.Throws<NegativeSeatException>(() =>
                sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), -1));

        }

     
        [Test]
        public void IsItPossibleToAskForUnbookedDay()
        {
            var result = sut.GetToursFor(new DateTime(2013, 1, 1));
            Assert.AreEqual(0, result.Count);
        }

       
    }
}

