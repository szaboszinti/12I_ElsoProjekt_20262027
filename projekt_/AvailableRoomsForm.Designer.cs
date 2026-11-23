namespace projekt_
{
    partial class AvailableRoomsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblGuestCount = new System.Windows.Forms.Label();
            this.txtGuestCount = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(640, 400);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(200, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 15);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "A megadott időszakban szabad szobák:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(48, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Érkezés";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(12, 33);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(170, 23);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(12, 70);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(51, 15);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Távozás";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(12, 88);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(170, 23);
            this.dtpTo.TabIndex = 3;
            // 
            // lblGuestCount
            // 
            this.lblGuestCount.AutoSize = true;
            this.lblGuestCount.Location = new System.Drawing.Point(12, 125);
            this.lblGuestCount.Name = "lblGuestCount";
            this.lblGuestCount.Size = new System.Drawing.Size(88, 15);
            this.lblGuestCount.TabIndex = 4;
            this.lblGuestCount.Text = "Vendégek száma";
            // 
            // txtGuestCount
            // 
            this.txtGuestCount.Location = new System.Drawing.Point(12, 143);
            this.txtGuestCount.Name = "txtGuestCount";
            this.txtGuestCount.Size = new System.Drawing.Size(170, 23);
            this.txtGuestCount.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 190);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Keresés";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AvailableRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 466);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtGuestCount);
            this.Controls.Add(this.lblGuestCount);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AvailableRoomsForm";
            this.Text = "Szabad szobák";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblGuestCount;
        private System.Windows.Forms.TextBox txtGuestCount;
        private System.Windows.Forms.Button btnSearch;
    }
}
