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
    public partial class RoomsForm : Form
    {
        Hotel hotel;
        public RoomsForm(Hotel h)
        {
            InitializeComponent();
            hotel = h;
            RefreshGrid();

        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = hotel.Rooms.ToList();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.RoomNumber = int.Parse(txtRoomNumber.Text);
            room.RoomType = txtRoomType.Text;
            room.Capacity = int.Parse(txtCapacity.Text);
            room.PricePerNight = int.Parse(txtPricePerNight.Text);
            room.IsActive = chkActive.Checked;
            room.Equipment = txtEquipment.Text;
            hotel.Rooms.Add(room);
            RefreshGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                hotel.Rooms.RemoveAt(index);
                RefreshGrid();
            }
        }

       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Előbb válassz ki egy szobát!");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                hotel.Rooms[index].RoomNumber =
                    int.Parse(txtRoomNumber.Text);

                hotel.Rooms[index].RoomType =
                    txtRoomType.Text;

                hotel.Rooms[index].Capacity =
                    int.Parse(txtCapacity.Text);

                hotel.Rooms[index].PricePerNight =
                    int.Parse(txtPricePerNight.Text);

                hotel.Rooms[index].IsActive =
                    chkActive.Checked;
                hotel.Rooms[index].Equipment =
                    txtEquipment.Text;

                hotel.SaveAll();

                RefreshGrid();

                MessageBox.Show("A szoba módosítva lett!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if(dataGridView1.Rows[e.RowIndex].DataBoundItem == null)
                return;

            Room selectedRoom =
                (Room)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            txtRoomNumber.Text =
                selectedRoom.RoomNumber.ToString();

            txtRoomType.Text =
                selectedRoom.RoomType;

            txtCapacity.Text =
                selectedRoom.Capacity.ToString();

            txtPricePerNight.Text =
                selectedRoom.PricePerNight.ToString();

            chkActive.Checked =
                selectedRoom.IsActive;

            txtEquipment.Text =
                selectedRoom.Equipment;
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string search =
                txtSearch.Text.ToLower();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource =
                hotel.Rooms
                .Where(r =>
                 r.RoomType.ToLower().Contains(search)
        ||
                    r.RoomNumber.ToString().Contains(search)
        ||
                    (r.Equipment ?? "").ToLower().Contains(search))
                        .ToList();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
