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
    public partial class AvailableRoomsForm : Form
    {
        Hotel hotel;
        public AvailableRoomsForm(Hotel h)
        {
            InitializeComponent();
            hotel = h;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int guestCount;

            if (!int.TryParse(txtGuestCount.Text, out guestCount))
            {
                MessageBox.Show("Adj meg egy számot!");
                return;
            }

            if (dtpFrom.Value >= dtpTo.Value)
            {
                MessageBox.Show("Hibás dátumok!");
                return;
            }

            dataGridView1.DataSource = null;

            dataGridView1.DataSource =
                hotel.GetAvailableRooms(
                    dtpFrom.Value,
                    dtpTo.Value,
                    guestCount);
        }
    }
}

    

