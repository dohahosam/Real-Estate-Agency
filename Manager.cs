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
    public partial class Manager : MaterialSkin.Controls.MaterialForm
    {
        string Username;
        public Manager(string User)
        {
            InitializeComponent();
            Username = User;

        }

        private void button_AddEmp_Click(object sender, EventArgs e)
        {
            Form f = new Manager_AddEmployee();
            f.Show();
        }

        private void button_ViewEditEmp_Click(object sender, EventArgs e)
        {
            Form f = new ViewEditEmp();
            f.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
