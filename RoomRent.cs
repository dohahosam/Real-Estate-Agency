using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class RoomRent : MaterialSkin.Controls.MaterialForm
    {
        public RoomRent()
        {
            InitializeComponent();
            Controller controllerobj = new Controller();
            DataTable dt2 = controllerobj.getAreas();
            comboBox_Locations.DataSource = dt2;
            comboBox_Locations.DisplayMember = "Name";
            comboBox_Locations.ValueMember = "ID";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Locations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            DataTable dt = controllerObj.ViewRooms(Convert.ToInt32(comboBox_Locations.SelectedValue));
            dataGridView_Rooms.DataSource = dt;
            dataGridView_Rooms.Refresh();
        }

        private void dataGridView_Rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to confirm the rent of this Room?", "Confirm Rent", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                int row = dataGridView_Rooms.CurrentCell.RowIndex;
                int House = Convert.ToInt32(dataGridView_Rooms.Rows[row].Cells[16].Value.ToString());
                int Room = Convert.ToInt32(dataGridView_Rooms.Rows[row].Cells[17].Value.ToString());

                FinalRentRoom f = new FinalRentRoom(House, Room);
                f.Show();
            }
        }
    }
}
