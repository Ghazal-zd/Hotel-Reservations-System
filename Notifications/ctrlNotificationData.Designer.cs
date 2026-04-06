namespace Hotel_Reservations_System
{
    partial class ctrlNotificationData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblContent = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lblCreatedAt = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pnlStyle = new Guna.UI2.WinForms.Guna2Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.picIcon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCreatedAt, 1, 2);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // picIcon
            // 
            this.picIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Image = global::Hotel_Reservations_System.Properties.Resources.warningIcon;
            this.picIcon.ImageRotate = 0F;
            this.picIcon.Location = new System.Drawing.Point(7, 7);
            this.picIcon.Name = "picIcon";
            this.tableLayoutPanel1.SetRowSpan(this.picIcon, 2);
            this.picIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picIcon.Size = new System.Drawing.Size(34, 32);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            this.picIcon.UseTransparentBackground = true;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(47, 4);
            this.lblContent.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(115, 23);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "siticoneLabel1";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedAt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCreatedAt.Location = new System.Drawing.Point(47, 42);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(364, 20);
            this.lblCreatedAt.TabIndex = 2;
            this.lblCreatedAt.Text = "2/2/2026 00:00";
            this.lblCreatedAt.Click += new System.EventHandler(this.lblCreatedAt_Click_1);
            // 
            // pnlStyle
            // 
            this.pnlStyle.AutoRoundedCorners = true;
            this.pnlStyle.BackColor = System.Drawing.Color.Transparent;
            this.pnlStyle.BorderColor = System.Drawing.Color.Transparent;
            this.pnlStyle.CustomBorderColor = System.Drawing.Color.Transparent;
            this.pnlStyle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlStyle.Location = new System.Drawing.Point(0, 0);
            this.pnlStyle.Name = "pnlStyle";
            this.pnlStyle.Size = new System.Drawing.Size(12, 76);
            this.pnlStyle.TabIndex = 37;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ctrlNotificationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlStyle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlNotificationData";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(532, 79);
            this.Load += new System.EventHandler(this.ctrlNotificationData_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picIcon;
        private SiticoneNetFrameworkUI.SiticoneLabel lblContent;
        private Guna.UI2.WinForms.Guna2Panel pnlStyle;
        private SiticoneNetFrameworkUI.SiticoneLabel lblCreatedAt;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
