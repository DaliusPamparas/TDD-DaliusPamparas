﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public interface ITourSchedule
    {
        List<Tour> Tours { get; set; }
        void CreateTour(string name, DateTime date, int seats);
        List<Tour> GetToursFor(DateTime dateTime);
    }
}
