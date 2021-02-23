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
    public partial class Manager_AddEmployee : MaterialSkin.Controls.MaterialForm
    {
        public Manager_AddEmployee()
        {
            InitializeComponent();
            Controller controllerobj = new Controller();
            DataTable dt = controllerobj.getPrivilege();
            comboBox_Privilege.DataSource = dt;
            comboBox_Privilege.DisplayMember = "Role";
            comboBox_Privilege.ValueMember = "Privilige";
            DataTable dt1 = controllerobj.getManager();
            comboBox_ManagerUser.DataSource = dt1;
            comboBox_ManagerUser.DisplayMember = "Username";
            DataTable dt2 = controllerobj.getAreas();
            checkedListBox_Area.DataSource = dt2;
            checkedListBox_Area.DisplayMember = "Name";
            checkedListBox_Area.ValueMember = "ID";

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            
            char gender=' ';
            if (comboBox_Gender.GetItemText(comboBox_Gender.SelectedItem) == "Female") gender = 'f';
            else if (comboBox_Gender.GetItemText(comboBox_Gender.SelectedItem) == "Male") gender = 'm';

            int ssn = Convert.ToInt32(textBox_SSN.Text);
            int phone= Convert.ToInt32(textBox_Phone.Text);
            int salary = Convert.ToInt32(numericUpDown_Salary.Value);
            char minit = Convert.ToChar(textBox_Minit.Text);
            char privilege = Convert.ToChar(comboBox_Privilege.SelectedValue);
            int AreaID= Convert.ToInt32(checkedListBox_Area.SelectedValue);

            //char Gender = Convert.ToChar(comboBox_Gender.SelectedItem);

            Controller controllerobj = new Controller();


            if (privilege == 'A')
            {
                int res = controllerobj.InsertEmp(textBox_Username.Text, textBox_Email.Text, maskedTextBox_Password.Text, privilege, ssn, 0, textBox_Fname.Text, minit, textBox_Lname.Text, gender, dateTimePicker_Bdate.Value, phone, salary, comboBox_ManagerUser.Text);
                int r = controllerobj.insertAreaAgent(textBox_Username.Text, AreaID);

                MessageBox.Show(res + " row is added in User and Employee Tables\n" + r + " row inserted in AgentArea");
            }
            else if (privilege == 'M')
            {
                
                    int res = controllerobj.InsertEmp(textBox_Username.Text, textBox_Email.Text, maskedTextBox_Password.Text, privilege, ssn, 0, textBox_Fname.Text, minit, textBox_Lname.Text, gender, dateTimePicker_Bdate.Value, phone, salary, comboBox_ManagerUser.Text);
                    MessageBox.Show("row is added in User and Employee Tables");
                    int r = controllerobj.insertAreaManager(textBox_Username.Text, AreaID);
                    MessageBox.Show(res + " row is added in User and Employee Tables\n" + r + " row inserted in AgentManager");

                
            }
            else
            {
                MessageBox.Show("customer cannot be added here");
            }
            
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_SSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only Enter Numbers");
            }
        }

        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
                MessageBox.Show("Only Enter Numbers");
            }
        }

        private void Manager_AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox_Area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
