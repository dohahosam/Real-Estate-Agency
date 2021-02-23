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
    public partial class Customer : MaterialSkin.Controls.MaterialForm
    {
        String Username;
        public Customer(string User)
        {
            InitializeComponent();
            Username = User;
        }

        private void button_Rent_Click(object sender, EventArgs e)
        {
            Form f = new Rent();
            f.Show();
        }

       

        private void Customer_Load(object sender, EventArgs e)
        {
        }

        private void button_AddAppartment_Click(object sender, EventArgs e)
        {
            Form f = new Add(Username);
            f.Show();

        }

        private void button_Rate_Click(object sender, EventArgs e)
        {
            RateAgent f = new RateAgent(Username);
            f.Show();
        }
    }
}
