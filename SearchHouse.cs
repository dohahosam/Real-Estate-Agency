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
    public partial class SearchHouse : MaterialSkin.Controls.MaterialForm
    {
        public SearchHouse()
        {
            InitializeComponent();
            Controller controllerobj = new Controller();
            DataTable dt2 = controllerobj.getAreas();
            comboBox_Location.DataSource = dt2;
            comboBox_Location.DisplayMember = "Name";
            comboBox_Location.ValueMember = "ID";
        }

        private void comboBox_Location_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            DataTable dt = controllerObj.ViewHouses(Convert.ToInt32(comboBox_Location.SelectedValue));
            dataGridView_Houses.DataSource = dt;
            dataGridView_Houses.Refresh();
            DataTable dt2 = controllerObj.agentPhone(Convert.ToInt32(comboBox_Location.SelectedValue));
            dataGridView_AgentsArea.DataSource = dt2;
            dataGridView_AgentsArea.Refresh();
        }

        private void SearchHouse_Load(object sender, EventArgs e)
        {

        }
    }
}
