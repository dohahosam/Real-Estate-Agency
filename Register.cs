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
    public partial class Register : MaterialSkin.Controls.MaterialForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
           char gender = ' ';
            if (comboBox_Gender.GetItemText(comboBox_Gender.SelectedItem) == "Female") gender = 'f';
            else if (comboBox_Gender.GetItemText(comboBox_Gender.SelectedItem) == "Male") gender = 'm';
                       
            char privilege = 'c';
            char minit = Convert.ToChar(textBox_Minit.Text);
            int phone = Convert.ToInt32(textBox_PhoneNumber.Text);

            Controller controllerobj = new Controller();
            int res = controllerobj.AddNewCustomer(textBox_Username.Text, textBox_Email.Text, textBox_Password.Text, privilege, textBox_FName.Text, minit, textBox_LName.Text, gender, dateTimePicker_Birthday.Value, phone);
            MessageBox.Show("Register");
        }
    }
}
