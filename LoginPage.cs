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
    public partial class LoginPage : MaterialSkin.Controls.MaterialForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            char p;
            Controller controllerObj = new Controller();
            object privilege = controllerObj.login(textBox_Username.Text, textBox_Password.Text);
            if (privilege == null)
            {
                p = ' ';
            }
            else p= Convert.ToChar(privilege);
            this.Hide();

            if (p != ' ')
            {
                if (p == 'M')
                {
                    Manager f = new Manager(textBox_Username.Text);
                    f.Show();
                }
                if (p == 'A')
                {
                    Agent f = new Agent();
                    f.Show();
                }
                if (p == 'C')
                {
                    Customer f = new Customer(textBox_Username.Text);
                    f.Show();
                }
                textBox_Password.Clear();
                textBox_Username.Clear();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
        }
    }
}
