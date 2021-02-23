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
    public partial class Add : MaterialSkin.Controls.MaterialForm
    {
        string Username;
        public Add(string User)
        {
            InitializeComponent();
            Username = User;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button_AsHouse_Click(object sender, EventArgs e)
        {
            Form f = new AddHouse1(Username);
            f.Show();
        }

        private void button_AsRooms_Click(object sender, EventArgs e)
        {
            Form f = new AddRoom(Username);
            f.Show();
        }

        private void button_AsBeds_Click(object sender, EventArgs e)
        {
            Form f = new AddBed(Username);
            f.Show();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
