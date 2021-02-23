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
    public partial class HouseRent : MaterialSkin.Controls.MaterialForm
    {
        public HouseRent()
        {
            InitializeComponent();
            Controller controllerobj = new Controller();
            DataTable dt2 = controllerobj.getAreas();
            comboBox_Locations.DataSource = dt2;
            comboBox_Locations.DisplayMember = "Name";
            comboBox_Locations.ValueMember = "ID";
        }

        private void HouseRent_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox_Locations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            DataTable dt = controllerObj.ViewHouses(Convert.ToInt32(comboBox_Locations.SelectedValue));
            dataGridView_Houses.DataSource = dt;
            dataGridView_Houses.Refresh();
        }

        private void dataGridView_Houses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res= MessageBox.Show("Are you sure you want to confirm the rent of this house?", "Confirm Rent", MessageBoxButtons.YesNo);
            if (res==DialogResult.Yes)
            {
                int row = dataGridView_Houses.CurrentCell.RowIndex;
                int House = Convert.ToInt32(dataGridView_Houses.Rows[row].Cells[0].Value.ToString());
                FinalRent f = new FinalRent(House);
                f.Show();
            }
        }
    }
}
