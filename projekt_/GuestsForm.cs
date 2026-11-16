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
    public partial class GuestsForm : Form
    {
        Hotel hotel;
        public GuestsForm(Hotel h)
        {
            InitializeComponent();
            hotel = h;
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = hotel.Guests;
        }

        private void GuestsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            guest.Id = int.Parse(txtId.Text);
            guest.Name = txtName.Text;
            guest.Phone = txtPhone.Text;
            guest.Email = txtEmail.Text;
            hotel.Guests.Add(guest);
            hotel.SaveAll();
            RefreshGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                hotel.Guests.RemoveAt(index);
                hotel.SaveAll();
                RefreshGrid();
            }
        }
    }
}
