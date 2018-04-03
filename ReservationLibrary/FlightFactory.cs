using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReservationLibrary
{
   public class FlightFactory
   {
      List<Flight> FlightList;
      XmlSerializer Serializer;
      //const String FilePath = @"../../flights.xml";


      public FlightFactory() { }

      public void CreateFlightData()
      {
         String[] airport = { "MIA", "SEA", "DEN", "LAX" };
         DateTime futuredate = new DateTime(2017, 07, 01, 0, 0, 0);

         FlightList = new List<Flight>();
         Random random = new Random();

         for (DateTime date = new DateTime(2017, 6, 1, 0, 0, 0); date <= futuredate; date = date.AddDays(1))
         {
            int flightnum = 100;

            for (int i = 0; i < airport.Length; i++)
            {
               for (int x = 0; x < airport.Length; x++)
               {
                  if (airport[i] != airport[x])
                  {
                     int counter = 0;
                     for (int j = 0; j < 4; j++)
                     {
                        TimeSpan time = new TimeSpan();
                        DateTime datealt = date;
                        double fare = 0;
                        
                        switch (counter)
                        {
                           case 0:
                              {
                                 time = new TimeSpan(5, 0, 0);
                                 fare = random.Next(500, 2001);
                                 break;
                              }
                           case 1:
                              {
                                 time = new TimeSpan(13, 0, 0);
                                 fare = random.Next(1000, 3001);
                                 break;
                              }
                           case 2:
                              {
                                 time = new TimeSpan(18, 0, 0);
                                 fare = random.Next(500, 3001);
                                 break;
                              }
                           case 3:
                              {
                                 time = new TimeSpan(22, 0, 0);
                                 fare = random.Next(500, 2001);
                                 break;
                              }
                        }
                        flightnum++;
                        counter++;
                        DateTime combinedTime = datealt.Add(time);
                        
                        Flight flight = new Flight(flightnum, combinedTime, airport[i], airport[x], fare, 10);
                        FlightList.Add(flight);
                     }
                  }
               }
            }
         }

      }


      public bool Serialize(string FilePath)
      {

         try
         {
            Serializer = new XmlSerializer(FlightList.GetType());

            using (var stream = File.OpenWrite(FilePath))
            {
               Serializer.Serialize(stream, FlightList);
            }
         }
         catch (Exception ex)
         {
            return false;
         }


         return true;
      }

      public List<Flight> Deserialize(string FilePath)
      {
         try
         {
            FlightList = new List<Flight>();
            StreamReader XmlStream = new StreamReader(FilePath);
            Serializer = new XmlSerializer(FlightList.GetType());
            FlightList = (List<Flight>)Serializer.Deserialize(XmlStream);
            XmlStream.Close();
            return FlightList;
         }
         catch (Exception ex)
         {
            return null;
         }
      }
   }
}
