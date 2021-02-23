namespace RSA
{
    partial class RoomRent
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
            this.label_Location = new System.Windows.Forms.Label();
            this.comboBox_Locations = new System.Windows.Forms.ComboBox();
            this.dataGridView_Rooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.BackColor = System.Drawing.SystemColors.Control;
            this.label_Location.Location = new System.Drawing.Point(121, 102);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(87, 13);
            this.label_Location.TabIndex = 1;
            this.label_Location.Text = "Choose Location";
            this.label_Location.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_Locations
            // 
            this.comboBox_Locations.FormattingEnabled = true;
            this.comboBox_Locations.Location = new System.Drawing.Point(124, 139);
            this.comboBox_Locations.Name = "comboBox_Locations";
            this.comboBox_Locations.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Locations.TabIndex = 2;
            this.comboBox_Locations.SelectedIndexChanged += new System.EventHandler(this.comboBox_Locations_SelectedIndexChanged);
            // 
            // dataGridView_Rooms
            // 
            this.dataGridView_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rooms.Location = new System.Drawing.Point(329, 182);
            this.dataGridView_Rooms.Name = "dataGridView_Rooms";
            this.dataGridView_Rooms.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_Rooms.TabIndex = 3;
            this.dataGridView_Rooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Rooms_CellContentClick);
            // 
            // RoomRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Rooms);
            this.Controls.Add(this.comboBox_Locations);
            this.Controls.Add(this.label_Location);
            this.Name = "RoomRent";
            this.Text = "RoomRent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.ComboBox comboBox_Locations;
        private System.Windows.Forms.DataGridView dataGridView_Rooms;
    }
}