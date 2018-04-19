namespace FlightReservationGui
{
   partial class MainForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.lnl_Asg1 = new System.Windows.Forms.LinkLabel();
         this.lnl_Asg2 = new System.Windows.Forms.LinkLabel();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(630, 166);
         this.label1.TabIndex = 0;
         this.label1.Text = "Flight Reservations 2.0";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lnl_Asg1
         // 
         this.lnl_Asg1.AutoSize = true;
         this.lnl_Asg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lnl_Asg1.Location = new System.Drawing.Point(19, 205);
         this.lnl_Asg1.Name = "lnl_Asg1";
         this.lnl_Asg1.Size = new System.Drawing.Size(442, 24);
         this.lnl_Asg1.TabIndex = 1;
         this.lnl_Asg1.TabStop = true;
         this.lnl_Asg1.Text = "Create and display the flights xml file (Assignment 1)";
         this.lnl_Asg1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnl_Asg1_LinkClicked);
         // 
         // lnl_Asg2
         // 
         this.lnl_Asg2.AutoSize = true;
         this.lnl_Asg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lnl_Asg2.Location = new System.Drawing.Point(19, 245);
         this.lnl_Asg2.Name = "lnl_Asg2";
         this.lnl_Asg2.Size = new System.Drawing.Size(273, 24);
         this.lnl_Asg2.TabIndex = 2;
         this.lnl_Asg2.TabStop = true;
         this.lnl_Asg2.Text = "Seach for flights (Assignment 2)";
         this.lnl_Asg2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnl_Asg2_LinkClicked);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(655, 337);
         this.Controls.Add(this.lnl_Asg2);
         this.Controls.Add(this.lnl_Asg1);
         this.Controls.Add(this.label1);
         this.Name = "MainForm";
         this.Text = "MainForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.LinkLabel lnl_Asg1;
      private System.Windows.Forms.LinkLabel lnl_Asg2;
   }
}