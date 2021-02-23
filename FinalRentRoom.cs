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
    public partial class FinalRentRoom : MaterialSkin.Controls.MaterialForm
    {
        int Room;
        int House;
        public FinalRentRoom(int house, int room)
        {
            InitializeComponent();
            House = house;
            Room = room;
        }

        private void button_Rented_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();

            int r = controllerObj.rentRoom(House, Room, dateTimePicker_StartDate.Value, dateTimePicker_EndDate.Value, textBox_Username.Text,  Convert.ToInt32(numericUpDown_Price.Value));

            if (r == 0)
            {
                MessageBox.Show("This User does not exist, enter a valid Username");
            }
            else
            {
                controllerObj.roomAvailability(House, Room);
                MessageBox.Show("Room Rented Successfully");
            }
        }
    }
}
