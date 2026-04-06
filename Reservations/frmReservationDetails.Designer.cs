namespace Hotel_Reservations_System
{
    partial class frmReservationDetails
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
            this.lblTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.ctrlReservationDetails1 = new Hotel_Reservations_System.ctrlReservationDetails();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(440, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 45);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Reservation Details";
            // 
            // ctrlReservationDetails1
            // 
            this.ctrlReservationDetails1.Location = new System.Drawing.Point(0, 60);
            this.ctrlReservationDetails1.Name = "ctrlReservationDetails1";
            this.ctrlReservationDetails1.Size = new System.Drawing.Size(1283, 584);
            this.ctrlReservationDetails1.TabIndex = 0;
            // 
            // frmReservationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1285, 656);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlReservationDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReservationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReservationDetails";
            this.Load += new System.EventHandler(this.frmReservationDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlReservationDetails ctrlReservationDetails1;
        private SiticoneNetFrameworkUI.SiticoneLabel lblTitle;
    }
}