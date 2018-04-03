using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationLibrary
{
   class Shared
   {

      private FlightFactory FlightFactory;
      //private string filepath = "../../flights.xml";
      private List<Flight> flightList;

      public List<Flight> GetList(String filepath)
      {
         FlightFactory = new FlightFactory();
         flightList = FlightFactory.Deserialize(filepath);
         return flightList;
      }
   }
}
