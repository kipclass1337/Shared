using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReservationLibrary
{
   public class ReservationFactory
   {
      List<Flight> flightList;
      List<FlightRequest> flightRequestList;
      FlightFactory flightFactory;
      XmlSerializer Serializer;

      public ReservationFactory() { }

      public List<FlightRequest> CreateFlightRequest (String filePath)
      {
         flightList = new List<Flight>();
         flightFactory = new FlightFactory();
         flightList = flightFactory.Deserialize(filePath);

         flightRequestList = new List<FlightRequest>();
         Random random = new Random();

         int counter = 0;

         while (counter < 20)
         {
            int ranIndex = random.Next(0, flightList.Count);
            Flight fl = flightList[ranIndex];

            FlightRequest flightRequest = new FlightRequest(fl.DateAndTime, fl.OrigAirport, fl.DestAirport);

            if (!flightRequestList.Any(fr => (fr.DateAndTime.Date == flightRequest.DateAndTime.Date) && (fr.OrigAirport == flightRequest.OrigAirport) && (fr.DestAirport == flightRequest.DestAirport)));
            {
               flightRequestList.Add(flightRequest);
               counter += 1;
            }
         }

         return flightRequestList;
      }

      public void Search(DateTime dateTime, String origAirport, String destAirport, String fileMatchPath)
      {
         flightFactory = new FlightFactory();
         List<Flight> insertList = new List<Flight>();
         insertList = flightList.FindAll(f => (f.DateAndTime.Date == dateTime.Date) && (f.OrigAirport == origAirport) && (f.DestAirport == destAirport));

         Serialize(fileMatchPath, insertList);
      }

      private bool Serialize(string FilePath, List<Flight> insertList)
      {
         try
         {
            Serializer = new XmlSerializer(insertList.GetType());

            using (var stream = File.OpenWrite(FilePath))
            {
               Serializer.Serialize(stream, insertList);
            }
         }
         catch (Exception ex)
         {
            return false;
         }
         return true;
      }

   }
}
