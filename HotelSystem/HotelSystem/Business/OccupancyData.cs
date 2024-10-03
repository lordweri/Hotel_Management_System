using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Business
{
    //A class to store the data for the occupancy report and display it in the form of a list of objects-BRWCAL007
    public class OccupancyData
    {
        // The date when the occupancy is recorded
        public DateTime Date { get; set; }

        // The occupancy percentage for that specific date
        public decimal OccupancyPercentage { get; set; }


        // Add a constructor if  want to initialize the data easily
        public OccupancyData(DateTime date, decimal occupancyPercentage)
        {
            Date = date;
            OccupancyPercentage = occupancyPercentage;
        }

        // Optional: Override the ToString() method for easier debugging or display purposes
        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}, Occupancy: {OccupancyPercentage}%";
        }
    }
}