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
    public partial class Rating : MaterialSkin.Controls.MaterialForm
    {
        string CustomerUser;
        string AgentUser;

        public Rating(string CustomerUsername, string AgentUsername)
        {
            InitializeComponent();
            CustomerUser = CustomerUsername;
            AgentUser = AgentUsername;
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int rate = Convert.ToInt32(comboBox_Rate.Text);
            string now = DateTime.Now.ToString("YYYY-MM-DD");

            int r = controllerObj.ratingAgent(CustomerUser, AgentUser, rate, now);
            if (r == 1)
            {
                MessageBox.Show("Success");
            }
            else 
            {
                MessageBox.Show("Fail!");
            }
            int sumrate = Convert.ToInt32(controllerObj.rateSum(AgentUser)) + rate;
            int ratecount = Convert.ToInt32(controllerObj.rateSum(AgentUser)) + 1;
            double AvgRating = sumrate / ratecount;
            int res = controllerObj.CalAvgRating(AgentUser, AvgRating);

            if (res == 1)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail!");
            }
        }

        private void Rating_Load(object sender, EventArgs e)
        {

        }
    }
}
