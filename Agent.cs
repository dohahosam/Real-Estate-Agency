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
    public partial class Agent : MaterialSkin.Controls.MaterialForm
    {
        public Agent()
        {
            InitializeComponent();
        }

        private void button_HouseRent_Click(object sender, EventArgs e)
        {
            HouseRent f = new HouseRent();
            f.Show();
        }

        private void button_RoomRent_Click(object sender, EventArgs e)
        {
            RoomRent f = new RoomRent();
            f.Show();
        }
    }
}
