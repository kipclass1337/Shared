namespace FlightReservationGui
{
    partial class CreateFilesForm
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
         this.btnCreateFlights = new System.Windows.Forms.Button();
         this.btnDisplayFlights = new System.Windows.Forms.Button();
         this.lblStatus = new System.Windows.Forms.Label();
         this.lstResults = new System.Windows.Forms.ListBox();
         this.btnSerialize = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnCreateFlights
         // 
         this.btnCreateFlights.Location = new System.Drawing.Point(12, 12);
         this.btnCreateFlights.Name = "btnCreateFlights";
         this.btnCreateFlights.Size = new System.Drawing.Size(276, 42);
         this.btnCreateFlights.TabIndex = 0;
         this.btnCreateFlights.Text = "Create the flights.xml file";
         this.btnCreateFlights.UseVisualStyleBackColor = true;
         this.btnCreateFlights.Click += new System.EventHandler(this.btnCreateFlights_Click);
         // 
         // btnDisplayFlights
         // 
         this.btnDisplayFlights.Location = new System.Drawing.Point(328, 12);
         this.btnDisplayFlights.Name = "btnDisplayFlights";
         this.btnDisplayFlights.Size = new System.Drawing.Size(276, 42);
         this.btnDisplayFlights.TabIndex = 2;
         this.btnDisplayFlights.Text = "Display the sample.xml file in a Web browser window";
         this.btnDisplayFlights.UseVisualStyleBackColor = true;
         this.btnDisplayFlights.Click += new System.EventHandler(this.btnDisplayFlights_Click);
         // 
         // lblStatus
         // 
         this.lblStatus.AutoSize = true;
         this.lblStatus.Location = new System.Drawing.Point(12, 433);
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size(181, 20);
         this.lblStatus.TabIndex = 4;
         this.lblStatus.Text = "(status of last operation)";
         // 
         // lstResults
         // 
         this.lstResults.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lstResults.FormattingEnabled = true;
         this.lstResults.ItemHeight = 17;
         this.lstResults.Location = new System.Drawing.Point(12, 152);
         this.lstResults.Name = "lstResults";
         this.lstResults.Size = new System.Drawing.Size(633, 259);
         this.lstResults.TabIndex = 5;
         // 
         // btnSerialize
         // 
         this.btnSerialize.Location = new System.Drawing.Point(12, 71);
         this.btnSerialize.Name = "btnSerialize";
         this.btnSerialize.Size = new System.Drawing.Size(364, 42);
         this.btnSerialize.TabIndex = 6;
         this.btnSerialize.Text = "Deserialize the flights xml file and display it below";
         this.btnSerialize.UseVisualStyleBackColor = true;
         this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
         // 
         // CreateFilesForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(657, 462);
         this.Controls.Add(this.btnSerialize);
         this.Controls.Add(this.lstResults);
         this.Controls.Add(this.lblStatus);
         this.Controls.Add(this.btnDisplayFlights);
         this.Controls.Add(this.btnCreateFlights);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "CreateFilesForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Flight Reservations 1.0";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateFilesForm_FormClosed);
         this.Load += new System.EventHandler(this.CreateFilesForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFlights;
        private System.Windows.Forms.Button btnDisplayFlights;
        private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.ListBox lstResults;
      private System.Windows.Forms.Button btnSerialize;
   }
}

