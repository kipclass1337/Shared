using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationLibrary
{
   public class Flight
   {


      public int FlightNumber { get; set; }
      public DateTime DateAndTime { get; set; }
      public String OrigAirport { get; set; }
      public String DestAirport { get; set; }
      public double Fare { get; set; }
      public int Seats { get; set; }
      
      public Flight() { }

      public Flight(int FlightNumber, DateTime DateAndTime, String OrigAirport, String DestAirport, double Fare, int Seats)
      {
         this.FlightNumber = FlightNumber;
         this.DateAndTime = DateAndTime;
         this.OrigAirport = OrigAirport;
         this.DestAirport = DestAirport;
         this.Fare = Fare;
         this.Seats = Seats;
      }

      public override string ToString()
      {
         string f = string.Format("{0:.00}", Fare);
         return FlightNumber + ", " + DateAndTime.ToString("MM/dd/yyyy") + " at " + DateAndTime.ToString("HH:mm") + ", " + OrigAirport + " to " + DestAirport + ", Cost: " + f + ", Seats: " + Seats;
      }
   }
}
