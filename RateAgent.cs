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
    

    public partial class RateAgent : MaterialSkin.Controls.MaterialForm
    {
        string CustomerUser;
        public RateAgent(string User)
        {
            InitializeComponent();
            CustomerUser = User;
            
        }

        private void textBox_PhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                    e.Handled = true;
                    MessageBox.Show("Only Enter Numbers");
            }
           

        }

        private void button_RateAgent_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            DataTable dt = controllerObj.agentByPhone(Convert.ToInt32(textBox_PhoneNo.Text));
           
            if (dt == null)
            {
                MessageBox.Show("this user does not exist enter a valid one");
            }
            else
            {
                dataGridView_Agent.DataSource = dt;
                dataGridView_Agent.Refresh();
            }
                    
        }

        private void dataGridView_Agent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Controller contollerObj = new Controller();
            int row = dataGridView_Agent.CurrentCell.RowIndex;

            DialogResult res = MessageBox.Show("Do you want to rate this Employee??", "Rating", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                string AgentUser = dataGridView_Agent.Rows[row].Cells[0].Value.ToString();
                Rating f = new Rating(CustomerUser, AgentUser);
                f.Show();
                
            }
            

        }

        private void RateAgent_Load(object sender, EventArgs e)
        {

        }
    }
}
