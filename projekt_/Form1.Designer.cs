namespace projekt_
{
    partial class Form1
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
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(68, 109);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRooms.Size = new System.Drawing.Size(197, 56);
            this.btnRooms.TabIndex = 0;
            this.btnRooms.Text = "Szobák";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(281, 109);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(188, 56);
            this.btnGuest.TabIndex = 1;
            this.btnGuest.Text = "Vendégek";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(485, 109);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(195, 56);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "Foglalások";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(442, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(238, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(68, 215);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(238, 41);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Statisztika";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnRooms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStats;
    }
}

