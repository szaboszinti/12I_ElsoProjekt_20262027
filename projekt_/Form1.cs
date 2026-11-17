using System;
using System.Windows.Forms;

namespace projekt_
{
    public partial class Form1 : Form
    {
        Hotel hotel = new Hotel();

        public Form1()
        {
            InitializeComponent();
            hotel.LoadAll(); // Betölti az adatokat a fájlokból
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Itt majd megjelenítheted az adatokat, pl. szobák listája
            // Példa: DataGridView feltöltése
            // dataGridView1.DataSource = hotel.Rooms;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hotel.SaveAll(); // Mentés fájlba
            MessageBox.Show("Adatok elmentve!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomsForm rf = new RoomsForm(hotel);
            rf.Show();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            hotel.SaveAll(); // Mentés fájlba
            MessageBox.Show("Adatok elmentve!");
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            GuestsForm gf = new GuestsForm(hotel);
            gf.Show();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingsForm bf = new BookingsForm(hotel);
            bf.Show();
        }
    }
}
