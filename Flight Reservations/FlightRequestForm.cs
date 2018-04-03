using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservationLibrary;

namespace FlightReservationGui
{
   public partial class FlightRequestForm : Form
   {

      ReservationFactory reservationFactory;
      List<FlightRequest> flightRequestList;
      String filepath = @"../../flights.xml";
      String fileMatchPath = @"../../matchingFlights.xml";

      public FlightRequestForm()
      {
         InitializeComponent();
      }

      private void btnCreateFlightRequest_Click(object sender, EventArgs e)
      {
         flightRequestList = reservationFactory.CreateFlightRequest(filepath);
         lstResults.DataSource = flightRequestList;
      }

      private void btnSearch_Click(object sender, EventArgs e)
      {
         FlightRequest fr = new FlightRequest();
         fr = flightRequestList[lstResults.SelectedIndex];
         reservationFactory.Search(fr.DateAndTime, fr.OrigAirport, fr.DestAirport, fileMatchPath);

         BrowserForm frm = new BrowserForm();
         frm.URL = "matchingFlights.xml";
         frm.ShowDialog();
      }

      private void FlightRequestForm_Load(object sender, EventArgs e)
      {
         reservationFactory = new ReservationFactory();
         flightRequestList = new List<FlightRequest>();
      }
   }
}
