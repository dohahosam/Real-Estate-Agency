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
    public partial class AddHouse1 : MaterialSkin.Controls.MaterialForm
    {
        string Username;
        public AddHouse1(string User)
        {
            
            
                InitializeComponent();
            Username = User;
            Controller controllerobj = new Controller();
            DataTable dt2 = controllerobj.getAreas();
            comboBox_Areas.DataSource = dt2;
            comboBox_Areas.DisplayMember = "Name";
            comboBox_Areas.ValueMember = "ID";
        }

        private void Addhouse1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_ChooseArea_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_AddHouse_Click(object sender, EventArgs e)
        {
            Controller controllerobj = new Controller();
            int HousingNo = controllerobj.CountHousing() +1 ;
            int AreaID = Convert.ToInt32(comboBox_Areas.SelectedValue);
            int Availibilty = 1;
            string Address = textBox_Address.Text;
            string OwnerUsername = Username;
            int Price = Convert.ToInt32(numericUpDown_Price.Value);
            int NoOfRooms = Convert.ToInt32(numericUpDown_NoOfRooms.Value);
            int NoOfBeds = Convert.ToInt32(numericUpDown_NoOfBeds.Value);
            int RentDuration = Convert.ToInt32(numericUpDown_RentDuration.Value);
            char RentersGender= ' ';  
            if (comboBox_RentersGender.GetItemText(comboBox_RentersGender.SelectedItem) == "Female") RentersGender = 'f';
            else if (comboBox_RentersGender.GetItemText(comboBox_RentersGender.SelectedItem) == "Male") RentersGender = 'm';
            int Furnished;
            if (checkedListBox_Facilities.GetItemChecked(0) == true) Furnished = 1;
            else Furnished = 0;
            int NaturalGas;
            if (checkedListBox_Facilities.GetItemChecked(1) == true) NaturalGas = 1;
            else NaturalGas = 0;
            int InternetConnection;
            if (checkedListBox_Facilities.GetItemChecked(2) == true) InternetConnection = 1;
            else InternetConnection = 0;
            int AirConditioned;
            if (checkedListBox_Facilities.GetItemChecked(3) == true) AirConditioned = 1;
            else AirConditioned = 0;
            string Extra = textBox_Extra.Text;
            string RentalType = "House";
            int Bla = controllerobj.insertHouse (HousingNo, OwnerUsername, AreaID, Availibilty, Address, RentersGender, Price, NoOfBeds, NoOfRooms, RentDuration, Furnished, RentalType, NaturalGas, InternetConnection, AirConditioned, Extra);




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_Price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_NoOfRooms_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Extra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
