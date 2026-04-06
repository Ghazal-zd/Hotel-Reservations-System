namespace Hotel_Reservations_System
{
    partial class frmCustomerDetails
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ctrlCustomerDataWithFilter1 = new Hotel_Reservations_System.ctrlCustomerDataWithFilter();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(105, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.lblTitle.Size = new System.Drawing.Size(468, 47);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Customer Details";
            // 
            // ctrlCustomerDataWithFilter1
            // 
            this.ctrlCustomerDataWithFilter1.FilterEnabled = true;
            this.ctrlCustomerDataWithFilter1.Location = new System.Drawing.Point(-1, 82);
            this.ctrlCustomerDataWithFilter1.Name = "ctrlCustomerDataWithFilter1";
            this.ctrlCustomerDataWithFilter1.ShowAddPerson = true;
            this.ctrlCustomerDataWithFilter1.Size = new System.Drawing.Size(581, 552);
            this.ctrlCustomerDataWithFilter1.TabIndex = 9;
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 641);
            this.Controls.Add(this.ctrlCustomerDataWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerDetails";
            this.Load += new System.EventHandler(this.frmCustomerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private ctrlCustomerDataWithFilter ctrlCustomerDataWithFilter1;
    }
}