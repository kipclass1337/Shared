using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationLibrary
{
   public class FlightRequest
   {
      public DateTime DateAndTime { get; set; }
      public String OrigAirport { get; set; }
      public String DestAirport { get; set; }

      public FlightRequest() { }

      public FlightRequest(DateTime DateAndTime, String OrigAirport, String DestAirport)
      {
         this.DateAndTime = DateAndTime;
         this.OrigAirport = OrigAirport;
         this.DestAirport = DestAirport;
      }

      public override string ToString()
      {
         return DateAndTime.ToString("MM/dd/yyyy") + ", flying from " + OrigAirport + " to " + DestAirport;
      }
   }
}
