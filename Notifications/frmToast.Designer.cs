namespace Hotel_Reservations_System
{
    partial class frmToast
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
            this.ctrlNotificationData1 = new Hotel_Reservations_System.ctrlNotificationData();
            this.SuspendLayout();
            // 
            // ctrlNotificationData1
            // 
            this.ctrlNotificationData1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlNotificationData1.BackColor = System.Drawing.Color.MistyRose;
            this.ctrlNotificationData1.ForeColor = System.Drawing.Color.Maroon;
            this.ctrlNotificationData1.Location = new System.Drawing.Point(1, 2);
            this.ctrlNotificationData1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlNotificationData1.Name = "ctrlNotificationData1";
            this.ctrlNotificationData1.NotificationType = HRS_BusinessLayer.clsNotification.enNotificationType.Error;
            this.ctrlNotificationData1.Padding = new System.Windows.Forms.Padding(8);
            this.ctrlNotificationData1.Size = new System.Drawing.Size(511, 92);
            this.ctrlNotificationData1.TabIndex = 0;
            // 
            // frmToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 97);
            this.Controls.Add(this.ctrlNotificationData1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmToast";
            this.Text = "Reservation System";
            this.Load += new System.EventHandler(this.frmToast_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlNotificationData ctrlNotificationData1;
    }
}