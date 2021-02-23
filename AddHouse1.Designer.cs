namespace RSA
{
    partial class AddHouse1
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
            this.textBox_Extra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox_Facilities = new System.Windows.Forms.CheckedListBox();
            this.comboBox_RentersGender = new System.Windows.Forms.ComboBox();
            this.label_RentersGender = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_ChooseArea = new System.Windows.Forms.Label();
            this.comboBox_Areas = new System.Windows.Forms.ComboBox();
            this.label_NoOfRooms = new System.Windows.Forms.Label();
            this.numericUpDown_NoOfRooms = new System.Windows.Forms.NumericUpDown();
            this.label_NoOfBeds = new System.Windows.Forms.Label();
            this.numericUpDown_NoOfBeds = new System.Windows.Forms.NumericUpDown();
            this.label_RentDuration = new System.Windows.Forms.Label();
            this.numericUpDown_RentDuration = new System.Windows.Forms.NumericUpDown();
            this.button_AddHouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoOfRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoOfBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RentDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Extra
            // 
            this.textBox_Extra.Location = new System.Drawing.Point(192, 226);
            this.textBox_Extra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Extra.Name = "textBox_Extra";
            this.textBox_Extra.Size = new System.Drawing.Size(115, 20);
            this.textBox_Extra.TabIndex = 32;
            this.textBox_Extra.TextChanged += new System.EventHandler(this.textBox_Extra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Price";
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.Location = new System.Drawing.Point(29, 161);
            this.numericUpDown_Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Price.TabIndex = 29;
            this.numericUpDown_Price.ValueChanged += new System.EventHandler(this.numericUpDown_Price_ValueChanged);
            // 
            // checkedListBox_Facilities
            // 
            this.checkedListBox_Facilities.FormattingEnabled = true;
            this.checkedListBox_Facilities.Items.AddRange(new object[] {
            "Furnished",
            "Natural Gas",
            "Internet Connection",
            "Air Conditioned"});
            this.checkedListBox_Facilities.Location = new System.Drawing.Point(29, 205);
            this.checkedListBox_Facilities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox_Facilities.Name = "checkedListBox_Facilities";
            this.checkedListBox_Facilities.Size = new System.Drawing.Size(124, 49);
            this.checkedListBox_Facilities.TabIndex = 28;
            this.checkedListBox_Facilities.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // comboBox_RentersGender
            // 
            this.comboBox_RentersGender.FormattingEnabled = true;
            this.comboBox_RentersGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox_RentersGender.Location = new System.Drawing.Point(361, 99);
            this.comboBox_RentersGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_RentersGender.Name = "comboBox_RentersGender";
            this.comboBox_RentersGender.Size = new System.Drawing.Size(94, 21);
            this.comboBox_RentersGender.TabIndex = 27;
            this.comboBox_RentersGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_RentersGender
            // 
            this.label_RentersGender.AutoSize = true;
            this.label_RentersGender.Location = new System.Drawing.Point(369, 75);
            this.label_RentersGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RentersGender.Name = "label_RentersGender";
            this.label_RentersGender.Size = new System.Drawing.Size(82, 13);
            this.label_RentersGender.TabIndex = 26;
            this.label_RentersGender.Text = "Renters Gender";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(200, 98);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(92, 20);
            this.textBox_Address.TabIndex = 25;
            this.textBox_Address.TextChanged += new System.EventHandler(this.textBox_Address_TextChanged);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(228, 75);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(45, 13);
            this.label_Address.TabIndex = 24;
            this.label_Address.Text = "Address";
            // 
            // label_ChooseArea
            // 
            this.label_ChooseArea.AutoSize = true;
            this.label_ChooseArea.Location = new System.Drawing.Point(26, 75);
            this.label_ChooseArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ChooseArea.Name = "label_ChooseArea";
            this.label_ChooseArea.Size = new System.Drawing.Size(68, 13);
            this.label_ChooseArea.TabIndex = 23;
            this.label_ChooseArea.Text = "Choose Area";
            this.label_ChooseArea.Click += new System.EventHandler(this.label_ChooseArea_Click);
            // 
            // comboBox_Areas
            // 
            this.comboBox_Areas.FormattingEnabled = true;
            this.comboBox_Areas.Location = new System.Drawing.Point(29, 98);
            this.comboBox_Areas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Areas.Name = "comboBox_Areas";
            this.comboBox_Areas.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Areas.TabIndex = 22;
            this.comboBox_Areas.SelectedIndexChanged += new System.EventHandler(this.comboBox_Areas_SelectedIndexChanged);
            // 
            // label_NoOfRooms
            // 
            this.label_NoOfRooms.AutoSize = true;
            this.label_NoOfRooms.Location = new System.Drawing.Point(208, 138);
            this.label_NoOfRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NoOfRooms.Name = "label_NoOfRooms";
            this.label_NoOfRooms.Size = new System.Drawing.Size(94, 13);
            this.label_NoOfRooms.TabIndex = 34;
            this.label_NoOfRooms.Text = "Number Of Rooms";
            // 
            // numericUpDown_NoOfRooms
            // 
            this.numericUpDown_NoOfRooms.Location = new System.Drawing.Point(210, 161);
            this.numericUpDown_NoOfRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_NoOfRooms.Name = "numericUpDown_NoOfRooms";
            this.numericUpDown_NoOfRooms.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_NoOfRooms.TabIndex = 33;
            this.numericUpDown_NoOfRooms.ValueChanged += new System.EventHandler(this.numericUpDown_NoOfRooms_ValueChanged);
            // 
            // label_NoOfBeds
            // 
            this.label_NoOfBeds.AutoSize = true;
            this.label_NoOfBeds.Location = new System.Drawing.Point(369, 138);
            this.label_NoOfBeds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NoOfBeds.Name = "label_NoOfBeds";
            this.label_NoOfBeds.Size = new System.Drawing.Size(85, 13);
            this.label_NoOfBeds.TabIndex = 38;
            this.label_NoOfBeds.Text = "Number Of Beds";
            // 
            // numericUpDown_NoOfBeds
            // 
            this.numericUpDown_NoOfBeds.Location = new System.Drawing.Point(372, 161);
            this.numericUpDown_NoOfBeds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_NoOfBeds.Name = "numericUpDown_NoOfBeds";
            this.numericUpDown_NoOfBeds.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_NoOfBeds.TabIndex = 37;
            this.numericUpDown_NoOfBeds.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label_RentDuration
            // 
            this.label_RentDuration.AutoSize = true;
            this.label_RentDuration.Location = new System.Drawing.Point(336, 205);
            this.label_RentDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RentDuration.Name = "label_RentDuration";
            this.label_RentDuration.Size = new System.Drawing.Size(167, 13);
            this.label_RentDuration.TabIndex = 40;
            this.label_RentDuration.Text = "Minumim Rent Duration In Months";
            // 
            // numericUpDown_RentDuration
            // 
            this.numericUpDown_RentDuration.Location = new System.Drawing.Point(360, 227);
            this.numericUpDown_RentDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_RentDuration.Name = "numericUpDown_RentDuration";
            this.numericUpDown_RentDuration.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown_RentDuration.TabIndex = 39;
            // 
            // button_AddHouse
            // 
            this.button_AddHouse.Location = new System.Drawing.Point(200, 293);
            this.button_AddHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_AddHouse.Name = "button_AddHouse";
            this.button_AddHouse.Size = new System.Drawing.Size(119, 36);
            this.button_AddHouse.TabIndex = 41;
            this.button_AddHouse.Text = "Add";
            this.button_AddHouse.UseVisualStyleBackColor = true;
            this.button_AddHouse.Click += new System.EventHandler(this.button_AddHouse_Click);
            // 
            // AddHouse1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 347);
            this.Controls.Add(this.button_AddHouse);
            this.Controls.Add(this.label_RentDuration);
            this.Controls.Add(this.numericUpDown_RentDuration);
            this.Controls.Add(this.label_NoOfBeds);
            this.Controls.Add(this.numericUpDown_NoOfBeds);
            this.Controls.Add(this.label_NoOfRooms);
            this.Controls.Add(this.numericUpDown_NoOfRooms);
            this.Controls.Add(this.textBox_Extra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Price);
            this.Controls.Add(this.checkedListBox_Facilities);
            this.Controls.Add(this.comboBox_RentersGender);
            this.Controls.Add(this.label_RentersGender);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_ChooseArea);
            this.Controls.Add(this.comboBox_Areas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddHouse1";
            this.Text = "Addhouse1";
            this.Load += new System.EventHandler(this.Addhouse1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoOfRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoOfBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RentDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Extra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Price;
        private System.Windows.Forms.CheckedListBox checkedListBox_Facilities;
        private System.Windows.Forms.ComboBox comboBox_RentersGender;
        private System.Windows.Forms.Label label_RentersGender;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_ChooseArea;
        private System.Windows.Forms.ComboBox comboBox_Areas;
        private System.Windows.Forms.Label label_NoOfRooms;
        private System.Windows.Forms.NumericUpDown numericUpDown_NoOfRooms;
        private System.Windows.Forms.Label label_NoOfBeds;
        private System.Windows.Forms.NumericUpDown numericUpDown_NoOfBeds;
        private System.Windows.Forms.Label label_RentDuration;
        private System.Windows.Forms.NumericUpDown numericUpDown_RentDuration;
        private System.Windows.Forms.Button button_AddHouse;
    }
}