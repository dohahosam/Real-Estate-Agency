using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace RSA
{
    
    public partial class Rent : MaterialSkin.Controls.MaterialForm
    {
        Controller controllerObj;
        public Rent()
        {
            InitializeComponent();
            
        }
    

        private void Rent_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_House_Click(object sender, EventArgs e)
        {
            SearchHouse f = new SearchHouse();
            f.Show();
        }
    }
}
