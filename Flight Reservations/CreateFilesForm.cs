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
   public partial class CreateFilesForm : Form
   {
      FlightFactory flightFactory;
      List<Flight> flightList;
      string filepath = "../../flights.xml";

      public CreateFilesForm()
      {
         InitializeComponent();
      }

      private void btnDisplayFlights_Click(object sender, EventArgs e)
      {
         BrowserForm frm = new BrowserForm();
         frm.URL = "flights.xml";
         frm.ShowDialog();
      }

      private void btnCreateFlights_Click(object sender, EventArgs e)
      {
         //testing
         flightFactory.CreateFlightData();
         bool result = flightFactory.Serialize(filepath);
         lblStatus.Text = result.ToString();
      }

      private void CreateFilesForm_Load(object sender, EventArgs e)
      {
         flightFactory = new FlightFactory();
      }

      private void btnSerialize_Click(object sender, EventArgs e)
      {
         flightList = flightFactory.Deserialize(filepath);
         if (flightList != null)
         {
            foreach (Flight f in flightList)
            {
               lstResults.Items.Add(f.ToString());
            }
         }
      }

      private void CreateFilesForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         MainForm mainForm = new MainForm();
         mainForm.Show();
      }
   }
}
