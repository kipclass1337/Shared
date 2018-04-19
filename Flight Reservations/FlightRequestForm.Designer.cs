namespace FlightReservationGui
{
   partial class FlightRequestForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lstResults = new System.Windows.Forms.ListBox();
         this.btnCreateFlightRequest = new System.Windows.Forms.Button();
         this.btnSearch = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lstResults
         // 
         this.lstResults.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lstResults.FormattingEnabled = true;
         this.lstResults.ItemHeight = 17;
         this.lstResults.Location = new System.Drawing.Point(12, 110);
         this.lstResults.Name = "lstResults";
         this.lstResults.Size = new System.Drawing.Size(425, 276);
         this.lstResults.TabIndex = 6;
         // 
         // btnCreateFlightRequest
         // 
         this.btnCreateFlightRequest.Location = new System.Drawing.Point(12, 12);
         this.btnCreateFlightRequest.Name = "btnCreateFlightRequest";
         this.btnCreateFlightRequest.Size = new System.Drawing.Size(216, 35);
         this.btnCreateFlightRequest.TabIndex = 7;
         this.btnCreateFlightRequest.Text = "Create Flight Requests";
         this.btnCreateFlightRequest.UseVisualStyleBackColor = true;
         this.btnCreateFlightRequest.Click += new System.EventHandler(this.btnCreateFlightRequest_Click);
         // 
         // btnSearch
         // 
         this.btnSearch.Location = new System.Drawing.Point(314, 69);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(123, 35);
         this.btnSearch.TabIndex = 8;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = true;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(9, 80);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(274, 13);
         this.label1.TabIndex = 9;
         this.label1.Text = "Select a request from the list and click the Search button";
         // 
         // FlightRequestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(449, 405);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.btnCreateFlightRequest);
         this.Controls.Add(this.lstResults);
         this.Name = "FlightRequestForm";
         this.Text = "FlightRequestForm";
         this.Load += new System.EventHandler(this.FlightRequestForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox lstResults;
      private System.Windows.Forms.Button btnCreateFlightRequest;
      private System.Windows.Forms.Button btnSearch;
      private System.Windows.Forms.Label label1;
   }
}