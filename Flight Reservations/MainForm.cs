using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationGui
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void lnl_Asg1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         CreateFilesForm asg1Form = new CreateFilesForm();
         asg1Form.Show();
         this.Hide();
      }

      private void lnl_Asg2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         FlightRequestForm asg2Form = new FlightRequestForm();
         asg2Form.Show();
         this.Hide();
      }
   }
}
