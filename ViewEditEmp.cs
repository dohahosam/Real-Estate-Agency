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
    public partial class ViewEditEmp : Form
    {
        public ViewEditEmp()
        {
            Controller controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.getAreas();
            comboBox_Location.DataSource = dt;
            comboBox_Location.DisplayMember = "name";
            comboBox_Location.ValueMember = "ID";

        }

        private void textBox_SearchEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controller controllerObj = new Controller();
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dt = controllerObj.getOneEmployee(textBox_SearchEmp.Text);
                if (dt == null)
                {
                    MessageBox.Show("this user does not exist enter a valid one"); 
                }
                else
                {
                    dataGridView_Employees.DataSource = dt;
                    dataGridView_Employees.Refresh();
                }
                   
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView_Employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controller contollerObj = new Controller();
            int row = dataGridView_Employees.CurrentCell.RowIndex;
            DialogResult res=MessageBox.Show("Do you want to delete this Employee??", "WARNING!", MessageBoxButtons.YesNo);
            if (res== DialogResult.Yes)
            {


                int r = contollerObj.delEmployee(dataGridView_Employees.Rows[row].Cells[0].Value.ToString());
                if (r == 0)
                {
                    MessageBox.Show("the User your deleting is included as a manager in other relation, update that.");
                }
                else { MessageBox.Show("User Deleted successfully"); }


            }
        }

        private void dataGridView_Employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewEditEmp_Load(object sender, EventArgs e)
        {

        }

        private void textBox_SearchEmp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
