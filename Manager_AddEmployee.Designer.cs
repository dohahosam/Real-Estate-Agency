namespace RSA
{
    partial class Manager_AddEmployee
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
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_Privilege = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Salary = new System.Windows.Forms.NumericUpDown();
            this.textBox_Lname = new System.Windows.Forms.TextBox();
            this.textBox_Minit = new System.Windows.Forms.TextBox();
            this.textBox_SSN = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Bdate = new System.Windows.Forms.DateTimePicker();
            this.textBox_Fname = new System.Windows.Forms.TextBox();
            this.button_AddEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_ManagerUser = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkedListBox_Area = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(25, 111);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_Username.TabIndex = 0;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            this.textBox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Username_KeyPress);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(164, 111);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 1;
            // 
            // maskedTextBox_Password
            // 
            this.maskedTextBox_Password.Location = new System.Drawing.Point(315, 111);
            this.maskedTextBox_Password.Name = "maskedTextBox_Password";
            this.maskedTextBox_Password.PasswordChar = '*';
            this.maskedTextBox_Password.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Password.TabIndex = 3;
            // 
            // comboBox_Privilege
            // 
            this.comboBox_Privilege.FormattingEnabled = true;
            this.comboBox_Privilege.Items.AddRange(new object[] {
            "a",
            "m"});
            this.comboBox_Privilege.Location = new System.Drawing.Point(441, 110);
            this.comboBox_Privilege.Name = "comboBox_Privilege";
            this.comboBox_Privilege.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Privilege.TabIndex = 4;
            this.comboBox_Privilege.Text = "Role";
            // 
            // numericUpDown_Salary
            // 
            this.numericUpDown_Salary.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_Salary.Location = new System.Drawing.Point(539, 153);
            this.numericUpDown_Salary.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown_Salary.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Salary.Name = "numericUpDown_Salary";
            this.numericUpDown_Salary.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Salary.TabIndex = 5;
            this.numericUpDown_Salary.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBox_Lname
            // 
            this.textBox_Lname.Location = new System.Drawing.Point(390, 152);
            this.textBox_Lname.Name = "textBox_Lname";
            this.textBox_Lname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Lname.TabIndex = 6;
            // 
            // textBox_Minit
            // 
            this.textBox_Minit.Location = new System.Drawing.Point(315, 151);
            this.textBox_Minit.MaxLength = 1;
            this.textBox_Minit.Name = "textBox_Minit";
            this.textBox_Minit.Size = new System.Drawing.Size(26, 20);
            this.textBox_Minit.TabIndex = 7;
            // 
            // textBox_SSN
            // 
            this.textBox_SSN.Location = new System.Drawing.Point(25, 151);
            this.textBox_SSN.Name = "textBox_SSN";
            this.textBox_SSN.Size = new System.Drawing.Size(100, 20);
            this.textBox_SSN.TabIndex = 8;
            this.textBox_SSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SSN_KeyPress);
            // 
            // dateTimePicker_Bdate
            // 
            this.dateTimePicker_Bdate.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_Bdate.Location = new System.Drawing.Point(165, 198);
            this.dateTimePicker_Bdate.Name = "dateTimePicker_Bdate";
            this.dateTimePicker_Bdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Bdate.TabIndex = 9;
            // 
            // textBox_Fname
            // 
            this.textBox_Fname.Location = new System.Drawing.Point(164, 151);
            this.textBox_Fname.Name = "textBox_Fname";
            this.textBox_Fname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Fname.TabIndex = 10;
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.Location = new System.Drawing.Point(675, 137);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(116, 35);
            this.button_AddEmployee.TabIndex = 12;
            this.button_AddEmployee.Text = "Add Employee";
            this.button_AddEmployee.UseVisualStyleBackColor = true;
            this.button_AddEmployee.Click += new System.EventHandler(this.button_AddEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "E-mail Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "SSN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Minit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Birthdate ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox_Gender.Location = new System.Drawing.Point(25, 198);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Gender.TabIndex = 24;
            this.comboBox_Gender.Text = "Gender";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(390, 201);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Phone.TabIndex = 26;
            this.textBox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(536, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Manager Username";
            // 
            // comboBox_ManagerUser
            // 
            this.comboBox_ManagerUser.FormattingEnabled = true;
            this.comboBox_ManagerUser.Location = new System.Drawing.Point(539, 201);
            this.comboBox_ManagerUser.Name = "comboBox_ManagerUser";
            this.comboBox_ManagerUser.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ManagerUser.TabIndex = 28;
            this.comboBox_ManagerUser.Text = "Manager Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Role";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Gender";
            // 
            // checkedListBox_Area
            // 
            this.checkedListBox_Area.FormattingEnabled = true;
            this.checkedListBox_Area.Location = new System.Drawing.Point(26, 242);
            this.checkedListBox_Area.Name = "checkedListBox_Area";
            this.checkedListBox_Area.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_Area.TabIndex = 30;
            this.checkedListBox_Area.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Area_SelectedIndexChanged);
            // 
            // Manager_AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox_Area);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox_ManagerUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddEmployee);
            this.Controls.Add(this.textBox_Fname);
            this.Controls.Add(this.dateTimePicker_Bdate);
            this.Controls.Add(this.textBox_SSN);
            this.Controls.Add(this.textBox_Minit);
            this.Controls.Add(this.textBox_Lname);
            this.Controls.Add(this.numericUpDown_Salary);
            this.Controls.Add(this.comboBox_Privilege);
            this.Controls.Add(this.maskedTextBox_Password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Username);
            this.Name = "Manager_AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.Manager_AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Password;
        private System.Windows.Forms.ComboBox comboBox_Privilege;
        private System.Windows.Forms.NumericUpDown numericUpDown_Salary;
        private System.Windows.Forms.TextBox textBox_Lname;
        private System.Windows.Forms.TextBox textBox_Minit;
        private System.Windows.Forms.TextBox textBox_SSN;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Bdate;
        private System.Windows.Forms.TextBox textBox_Fname;
        private System.Windows.Forms.Button button_AddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_ManagerUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox checkedListBox_Area;
    }
}