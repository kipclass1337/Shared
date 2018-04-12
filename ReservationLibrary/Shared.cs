using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReservationLibrary
{
   class Shared
   {
      //Move deserialize here and use public static method to call it
      private FlightFactory FlightFactory;
      //private string filepath = "../../flights.xml";
      public static List<Flight> FlightList;


      public List<Flight> Deserialize(string FilePath)
      {
         try
         {
            Shared.FlightList = new List<Flight>();
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

      public List<Flight> GetList(String filepath)
      {
         FlightFactory = new FlightFactory();
         FlightList = FlightFactory.Deserialize(filepath);
         return FlightList;
      }
   }
}
