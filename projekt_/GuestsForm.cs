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
                Guest selectedGuest =
    (Guest)dataGridView1.SelectedRows[0].DataBoundItem;

                hotel.Guests.Remove(selectedGuest);

                hotel.SaveAll();

                RefreshGrid();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            Guest selectedGuest =
                (Guest)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            txtId.Text =
                selectedGuest.Id.ToString();

            txtName.Text =
                selectedGuest.Name;

            txtPhone.Text =
                selectedGuest.Phone;

            txtEmail.Text =
                selectedGuest.Email;
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Előbb válassz ki egy vendéget!");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Guest selectedGuest =
                    (Guest)dataGridView1.SelectedRows[0].DataBoundItem;

                selectedGuest.Id =
                    int.Parse(txtId.Text);

                selectedGuest.Name =
                    txtName.Text;

                selectedGuest.Phone =
                    txtPhone.Text;

                selectedGuest.Email =
                    txtEmail.Text;

                hotel.SaveAll();

                RefreshGrid();

                MessageBox.Show("A vendég módosítva lett!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search =
    txtSearch.Text.ToLower();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource =
                hotel.Guests
                .Where(g =>
                    g.Name.ToLower().Contains(search)
                    ||
                    g.Email.ToLower().Contains(search)
                    ||
                    g.Phone.Contains(search))
                .ToList();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
