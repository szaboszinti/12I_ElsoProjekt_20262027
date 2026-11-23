namespace projekt_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAvailableRooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(60, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Szobák";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnGuest.Location = new System.Drawing.Point(60, 104);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(309, 61);
            this.btnGuest.TabIndex = 1;
            this.btnGuest.Text = "Vendégek";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnBookings.Location = new System.Drawing.Point(60, 182);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(309, 61);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "Foglalások";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnStats.Location = new System.Drawing.Point(60, 260);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(309, 61);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Statisztika";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSave.Location = new System.Drawing.Point(60, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(309, 61);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnAvailableRooms
            // 
            this.btnAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAvailableRooms.Location = new System.Drawing.Point(60, 426);
            this.btnAvailableRooms.Name = "btnAvailableRooms";
            this.btnAvailableRooms.Size = new System.Drawing.Size(309, 61);
            this.btnAvailableRooms.TabIndex = 5;
            this.btnAvailableRooms.Text = "Szabad szobák";
            this.btnAvailableRooms.UseVisualStyleBackColor = true;
            this.btnAvailableRooms.Click += new System.EventHandler(this.btnAvailableRooms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 529);
            this.Controls.Add(this.btnAvailableRooms);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAvailableRooms;
    }
}