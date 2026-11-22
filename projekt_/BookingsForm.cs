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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                cmbGuest.SelectedValue =
                    hotel.Bookings[index].GuestId;

                cmbRoom.SelectedValue =
                    hotel.Bookings[index].RoomNumber;

                dtpCheckIn.Value =
                    hotel.Bookings[index].CheckIn;

                dtpCheckOut.Value =
                    hotel.Bookings[index].CheckOut;

                txtGuestCount.Text =
                    hotel.Bookings[index].GuestCount.ToString();
            }
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Válassz ki egy foglalást!");
                return;
            }

            int index =
                dataGridView1.SelectedRows[0].Index;

            int roomNumber =
                Convert.ToInt32(cmbRoom.SelectedValue);

            DateTime from =
                dtpCheckIn.Value;

            DateTime to =
                dtpCheckOut.Value;

            if (from >= to)
            {
                MessageBox.Show(
                    "A távozás dátuma nem lehet korábbi vagy azonos!");
                return;
            }

            Room room =
                hotel.Rooms.Find(r =>
                    r.RoomNumber == roomNumber);

            int guestCount =
                Convert.ToInt32(txtGuestCount.Text);

            if (guestCount > room.Capacity)
            {
                MessageBox.Show(
                    "Túl sok vendég a kiválasztott szobához!");
                return;
            }

            hotel.Bookings[index].GuestId =
                Convert.ToInt32(cmbGuest.SelectedValue);

            hotel.Bookings[index].RoomNumber =
                roomNumber;

            hotel.Bookings[index].CheckIn =
                from;

            hotel.Bookings[index].CheckOut =
                to;

            hotel.Bookings[index].GuestCount =
                guestCount;

            hotel.Bookings[index].TotalPrice =
                hotel.CalculatePrice(room, from, to);

            hotel.SaveAll();

            RefreshGrid();

            MessageBox.Show("Foglalás módosítva!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtSearchBooking.Text, out id))
            {
                MessageBox.Show("Adj meg egy számot!");
                return;
            }

            dataGridView1.DataSource = null;

            dataGridView1.DataSource =
                hotel.Bookings
                .Where(b => b.Id == id)
                .ToList();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
