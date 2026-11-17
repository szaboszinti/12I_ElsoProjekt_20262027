using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_
{
    public partial class BookingsForm : Form
    {
        Hotel hotel;
        public BookingsForm(Hotel h)
        {
            InitializeComponent();
            hotel = h;

            FillComboBoxes();
            RefreshGrid();
        }

        private void FillComboBoxes()
        {
            cmbGuest.DataSource = null;
            cmbGuest.DataSource = hotel.Guests;
            cmbGuest.DisplayMember = "Name";
            cmbGuest.ValueMember = "Id";

            cmbRoom.DataSource = null;
            cmbRoom.DataSource = hotel.Rooms;
            cmbRoom.DisplayMember = "RoomNumber";
            cmbRoom.ValueMember = "RoomNumber";
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = hotel.Bookings;
        }
            

        private void btnAddBooking_Click_1(object sender, EventArgs e)
        {
            int roomNumber =
                Convert.ToInt32(cmbRoom.SelectedValue);

            DateTime from =
                dtpCheckIn.Value;

            DateTime to =
                dtpCheckOut.Value;

            if (from >= to)
            {
                MessageBox.Show("A távozás dátuma későbbi kell legyen mint az érkezés!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGuestCount.Text))
            {
                MessageBox.Show("Add meg a vendégek számát!");
                return;
            }

            if (!hotel.IsRoomAvailable(roomNumber, from, to))
            {
                MessageBox.Show("A szoba már foglalt!");
                return;
            }

            Room room =
                hotel.Rooms.Find(r =>
                    r.RoomNumber == roomNumber);

            int guestCount = Convert.ToInt32(txtGuestCount.Text);

            if (guestCount > room.Capacity)
            {
                MessageBox.Show("Túl sok vendég ehhez a szobához!");
                return;
            }
            if (guestCount <= 0)
            {
                MessageBox.Show("Legalább 1 vendéget meg kell adni!");
                return;
            }


            Booking booking = new Booking();

            booking.Id = hotel.Bookings.Count + 1;
            booking.GuestId =
                Convert.ToInt32(cmbGuest.SelectedValue);

            booking.RoomNumber = roomNumber;
            booking.CheckIn = from;
            booking.CheckOut = to;

            booking.GuestCount =
                Convert.ToInt32(txtGuestCount.Text);

            booking.Status = "Aktív";

            booking.TotalPrice =
                hotel.CalculatePrice(room, from, to);

            hotel.Bookings.Add(booking);

            hotel.SaveAll();

            RefreshGrid();

            MessageBox.Show("Foglalás sikeresen létrehozva!");
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Biztosan törölni szeretnéd a kiválasztott foglalást?",
                    "Törlés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int index = dataGridView1.SelectedRows[0].Index;

                    hotel.Bookings.RemoveAt(index);

                    hotel.SaveAll();

                    RefreshGrid();

                    MessageBox.Show("A foglalás sikeresen törölve.");
                }
            }
            else
            {
                MessageBox.Show("Előbb válassz ki egy foglalást!");
            }
        }
    }
}
