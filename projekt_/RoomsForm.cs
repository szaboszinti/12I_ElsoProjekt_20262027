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
            dataGridView1.DataSource = hotel.Rooms;
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
    }
}
