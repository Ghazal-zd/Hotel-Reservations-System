namespace Hotel_Reservations_System
{
    partial class frmNotifications
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
            this.lblUnreadCount = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.listViewNotifications = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblUnreadCount
            // 
            this.lblUnreadCount.BackColor = System.Drawing.Color.Transparent;
            this.lblUnreadCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnreadCount.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblUnreadCount.Location = new System.Drawing.Point(36, 9);
            this.lblUnreadCount.Name = "lblUnreadCount";
            this.lblUnreadCount.Size = new System.Drawing.Size(214, 41);
            this.lblUnreadCount.TabIndex = 2;
            this.lblUnreadCount.Text = "0";
            // 
            // listViewNotifications
            // 
            this.listViewNotifications.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listViewNotifications.HideSelection = false;
            this.listViewNotifications.Location = new System.Drawing.Point(36, 53);
            this.listViewNotifications.Name = "listViewNotifications";
            this.listViewNotifications.Size = new System.Drawing.Size(781, 599);
            this.listViewNotifications.TabIndex = 3;
            this.listViewNotifications.UseCompatibleStateImageBehavior = false;
            this.listViewNotifications.View = System.Windows.Forms.View.Details;
            this.listViewNotifications.SelectedIndexChanged += new System.EventHandler(this.listViewNotifications_SelectedIndexChanged);
            // 
            // frmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(852, 692);
            this.Controls.Add(this.listViewNotifications);
            this.Controls.Add(this.lblUnreadCount);
            this.Name = "frmNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotifications";
            this.Load += new System.EventHandler(this.frmNotifications_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private SiticoneNetFrameworkUI.SiticoneLabel lblUnreadCount;
        private System.Windows.Forms.ListView listViewNotifications;
    }
}