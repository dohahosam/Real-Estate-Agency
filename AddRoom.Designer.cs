namespace RSA
{
    partial class AddRoom
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
            this.label_RentDuration = new System.Windows.Forms.Label();
            this.numericUpDown_RentDuration = new System.Windows.Forms.NumericUpDown();
            this.label_NoOfBeds = new System.Windows.Forms.Label();
            this.numericUpDown_NoOfBeds = new System.Windows.Forms.NumericUpDown();
            this.label_NoOfRooms = new System.Windows.Forms.Label();
            this.numericUpDown_NoOfRooms = new System.Windows.Forms.NumericUpDown();
            this.textBox_Extra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox_Facilities = new System.Windows.Forms.CheckedListBox();
            this.comboBox_RentersGender = new System.Windows.Forms.ComboBox();
            this.label_RentersGender = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_ChooseArea = new System.Windows.Forms.Label();
            this.comboBox_Areas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_RNoOfBeds = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_RPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RentDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoOfBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoOfRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RNoOfBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label_RentDuration
            // 
            this.label_RentDuration.AutoSize = true;
            this.label_RentDuration.Location = new System.Drawing.Point(261, 145);
            this.label_RentDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RentDuration.Name = "label_RentDuration";
            this.label_RentDuration.Size = new System.Drawing.Size(167, 13);
            this.label_RentDuration.TabIndex = 57;
            this.label_RentDuration.Text = "Minumim Rent Duration In Months";
            this.label_RentDuration.Click += new System.EventHandler(this.label_RentDuration_Click);
            // 
            // numericUpDown_RentDuration
            // 
            this.numericUpDown_RentDuration.Location = new System.Drawing.Point(264, 167);
            this.numericUpDown_RentDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_RentDuration.Name = "numericUpDown_RentDuration";
            this.numericUpDown_RentDuration.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown_RentDuration.TabIndex = 56;
            this.numericUpDown_RentDuration.ValueChanged += new System.EventHandler(this.numericUpDown_RentDuration_ValueChanged);
            // 
            // label_NoOfBeds
            // 
            this.label_NoOfBeds.AutoSize = true;
            this.label_NoOfBeds.Location = new System.Drawing.Point(126, 145);
            this.label_NoOfBeds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NoOfBeds.Name = "label_NoOfBeds";
            this.label_NoOfBeds.Size = new System.Drawing.Size(85, 13);
            this.label_NoOfBeds.TabIndex = 55;
            this.label_NoOfBeds.Text = "Number Of Beds";
            this.label_NoOfBeds.Click += new System.EventHandler(this.label_NoOfBeds_Click);
            // 
            // numericUpDown_NoOfBeds
            // 
            this.numericUpDown_NoOfBeds.Location = new System.Drawing.Point(131, 167);
            this.numericUpDown_NoOfBeds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_NoOfBeds.Name = "numericUpDown_NoOfBeds";
            this.numericUpDown_NoOfBeds.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_NoOfBeds.TabIndex = 54;
            this.numericUpDown_NoOfBeds.ValueChanged += new System.EventHandler(this.numericUpDown_NoOfBeds_ValueChanged);
            // 
            // label_NoOfRooms
            // 
            this.label_NoOfRooms.AutoSize = true;
            this.label_NoOfRooms.Location = new System.Drawing.Point(12, 145);
            this.label_NoOfRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NoOfRooms.Name = "label_NoOfRooms";
            this.label_NoOfRooms.Size = new System.Drawing.Size(94, 13);
            this.label_NoOfRooms.TabIndex = 53;
            this.label_NoOfRooms.Text = "Number Of Rooms";
            this.label_NoOfRooms.Click += new System.EventHandler(this.label_NoOfRooms_Click);
            // 
            // numericUpDown_NoOfRooms
            // 
            this.numericUpDown_NoOfRooms.Location = new System.Drawing.Point(14, 167);
            this.numericUpDown_NoOfRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_NoOfRooms.Name = "numericUpDown_NoOfRooms";
            this.numericUpDown_NoOfRooms.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_NoOfRooms.TabIndex = 52;
            this.numericUpDown_NoOfRooms.ValueChanged += new System.EventHandler(this.numericUpDown_NoOfRooms_ValueChanged);
            // 
            // textBox_Extra
            // 
            this.textBox_Extra.Location = new System.Drawing.Point(175, 232);
            this.textBox_Extra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Extra.Name = "textBox_Extra";
            this.textBox_Extra.Size = new System.Drawing.Size(115, 20);
            this.textBox_Extra.TabIndex = 51;
            this.textBox_Extra.TextChanged += new System.EventHandler(this.textBox_Extra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Comment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkedListBox_Facilities
            // 
            this.checkedListBox_Facilities.FormattingEnabled = true;
            this.checkedListBox_Facilities.Items.AddRange(new object[] {
            "Furnished",
            "Natural Gas",
            "Internet Connection",
            "Air Conditioned"});
            this.checkedListBox_Facilities.Location = new System.Drawing.Point(8, 201);
            this.checkedListBox_Facilities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox_Facilities.Name = "checkedListBox_Facilities";
            this.checkedListBox_Facilities.Size = new System.Drawing.Size(124, 49);
            this.checkedListBox_Facilities.TabIndex = 47;
            this.checkedListBox_Facilities.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Facilities_SelectedIndexChanged);
            // 
            // comboBox_RentersGender
            // 
            this.comboBox_RentersGender.FormattingEnabled = true;
            this.comboBox_RentersGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox_RentersGender.Location = new System.Drawing.Point(224, 115);
            this.comboBox_RentersGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_RentersGender.Name = "comboBox_RentersGender";
            this.comboBox_RentersGender.Size = new System.Drawing.Size(94, 21);
            this.comboBox_RentersGender.TabIndex = 46;
            this.comboBox_RentersGender.SelectedIndexChanged += new System.EventHandler(this.comboBox_RentersGender_SelectedIndexChanged);
            // 
            // label_RentersGender
            // 
            this.label_RentersGender.AutoSize = true;
            this.label_RentersGender.Location = new System.Drawing.Point(221, 90);
            this.label_RentersGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RentersGender.Name = "label_RentersGender";
            this.label_RentersGender.Size = new System.Drawing.Size(82, 13);
            this.label_RentersGender.TabIndex = 45;
            this.label_RentersGender.Text = "Renters Gender";
            this.label_RentersGender.Click += new System.EventHandler(this.label_RentersGender_Click);
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(129, 115);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(68, 20);
            this.textBox_Address.TabIndex = 44;
            this.textBox_Address.TextChanged += new System.EventHandler(this.textBox_Address_TextChanged);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(126, 90);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(45, 13);
            this.label_Address.TabIndex = 43;
            this.label_Address.Text = "Address";
            this.label_Address.Click += new System.EventHandler(this.label_Address_Click);
            // 
            // label_ChooseArea
            // 
            this.label_ChooseArea.AutoSize = true;
            this.label_ChooseArea.Location = new System.Drawing.Point(11, 90);
            this.label_ChooseArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ChooseArea.Name = "label_ChooseArea";
            this.label_ChooseArea.Size = new System.Drawing.Size(68, 13);
            this.label_ChooseArea.TabIndex = 42;
            this.label_ChooseArea.Text = "Choose Area";
            this.label_ChooseArea.Click += new System.EventHandler(this.label_ChooseArea_Click);
            // 
            // comboBox_Areas
            // 
            this.comboBox_Areas.FormattingEnabled = true;
            this.comboBox_Areas.Location = new System.Drawing.Point(14, 113);
            this.comboBox_Areas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Areas.Name = "comboBox_Areas";
            this.comboBox_Areas.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Areas.TabIndex = 41;
            this.comboBox_Areas.SelectedIndexChanged += new System.EventHandler(this.comboBox_Areas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "House info";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 26);
            this.button1.TabIndex = 59;
            this.button1.Text = "Add Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Room Info";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Number Of Beds";
            // 
            // numericUpDown_RNoOfBeds
            // 
            this.numericUpDown_RNoOfBeds.Location = new System.Drawing.Point(16, 323);
            this.numericUpDown_RNoOfBeds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_RNoOfBeds.Name = "numericUpDown_RNoOfBeds";
            this.numericUpDown_RNoOfBeds.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_RNoOfBeds.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Room Price";
            // 
            // numericUpDown_RPrice
            // 
            this.numericUpDown_RPrice.Location = new System.Drawing.Point(175, 323);
            this.numericUpDown_RPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_RPrice.Name = "numericUpDown_RPrice";
            this.numericUpDown_RPrice.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_RPrice.TabIndex = 63;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_RPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_RNoOfBeds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_RentDuration);
            this.Controls.Add(this.numericUpDown_RentDuration);
            this.Controls.Add(this.label_NoOfBeds);
            this.Controls.Add(this.numericUpDown_NoOfBeds);
            this.Controls.Add(this.label_NoOfRooms);
            this.Controls.Add(this.numericUpDown_NoOfRooms);
            this.Controls.Add(this.textBox_Extra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox_Facilities);
            this.Controls.Add(this.comboBox_RentersGender);
            this.Controls.Add(this.label_RentersGender);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_ChooseArea);
            this.Controls.Add(this.comboBox_Areas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RentDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoOfBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoOfRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RNoOfBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_RentDuration;
        private System.Windows.Forms.NumericUpDown numericUpDown_RentDuration;
        private System.Windows.Forms.Label label_NoOfBeds;
        private System.Windows.Forms.NumericUpDown numericUpDown_NoOfBeds;
        private System.Windows.Forms.Label label_NoOfRooms;
        private System.Windows.Forms.NumericUpDown numericUpDown_NoOfRooms;
        private System.Windows.Forms.TextBox textBox_Extra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox_Facilities;
        private System.Windows.Forms.ComboBox comboBox_RentersGender;
        private System.Windows.Forms.Label label_RentersGender;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_ChooseArea;
        private System.Windows.Forms.ComboBox comboBox_Areas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_RNoOfBeds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_RPrice;
    }
}