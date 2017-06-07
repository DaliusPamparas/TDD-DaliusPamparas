using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace TravelAgency
{
    public class TourSchedule
    {
        private List<Tour> _tours = new List<Tour>();
        public void CreateTour(string tourName, DateTime tourDate, int tourPlaces)
        {
           
            var nTour = new Tour();
            nTour.Name = tourName;
            nTour.When = tourDate.Date;
            nTour.AvailableSeats = tourPlaces;
            

            _tours.Add(nTour);
            var result = _tours.Count(x => x.When.Date == tourDate.Date);
            if (result >= 3)
            {
              
                throw new TourAllocationException();
            }
        }

        public List<Tour> GetToursFor(DateTime dateTime)
        {

            var result = _tours.Where(x => x.When == dateTime.Date).ToList();
            return result;
        }
    }
}
