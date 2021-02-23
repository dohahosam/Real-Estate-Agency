namespace RSA
{
    partial class HouseRent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Locations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Houses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Houses)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Locations
            // 
            this.comboBox_Locations.FormattingEnabled = true;
            this.comboBox_Locations.Location = new System.Drawing.Point(107, 107);
            this.comboBox_Locations.Name = "comboBox_Locations";
            this.comboBox_Locations.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Locations.TabIndex = 1;
            this.comboBox_Locations.SelectedIndexChanged += new System.EventHandler(this.comboBox_Locations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // dataGridView_Houses
            // 
            this.dataGridView_Houses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Houses.Location = new System.Drawing.Point(107, 154);
            this.dataGridView_Houses.Name = "dataGridView_Houses";
            this.dataGridView_Houses.Size = new System.Drawing.Size(542, 225);
            this.dataGridView_Houses.TabIndex = 3;
            this.dataGridView_Houses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Houses_CellContentClick);
            // 
            // HouseRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Houses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Locations);
            this.Name = "HouseRent";
            this.Text = "HouseRent";
            this.Load += new System.EventHandler(this.HouseRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Houses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Locations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Houses;
    }
}