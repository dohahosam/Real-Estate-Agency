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
    public partial class FinalRent : MaterialSkin.Controls.MaterialForm
    {
        int House;
        public FinalRent(int Housing)
        {
            InitializeComponent();
            House = Housing;
        }

        private void FinalRent_Load(object sender, EventArgs e)
        {

        }

        private void button_Rented_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();

            int r = controllerObj.rentHouse(House, dateTimePicker_StartDate.Value, textBox_User.Text, dateTimePicker_EndDate.Value, Convert.ToInt32(numericUpDown_Price.Value));
            if (r==0)
            {
                MessageBox.Show("This User does not exist, enter a valid Username");
            }
            else
            {
                controllerObj.houseAvailability(House);
                MessageBox.Show("House Rented Successfully");
            }
        }
    }
}
