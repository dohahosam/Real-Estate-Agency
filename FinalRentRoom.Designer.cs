namespace RSA
{
    partial class FinalRentRoom
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
            this.label_EnterUsername = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.button_Rented = new System.Windows.Forms.Button();
            this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // label_EnterUsername
            // 
            this.label_EnterUsername.AutoSize = true;
            this.label_EnterUsername.Location = new System.Drawing.Point(48, 98);
            this.label_EnterUsername.Name = "label_EnterUsername";
            this.label_EnterUsername.Size = new System.Drawing.Size(142, 13);
            this.label_EnterUsername.TabIndex = 0;
            this.label_EnterUsername.Text = "Enter username for customer";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(243, 98);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_Username.TabIndex = 1;
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(308, 192);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_StartDate.TabIndex = 2;
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(569, 192);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_EndDate.TabIndex = 3;
            // 
            // button_Rented
            // 
            this.button_Rented.Location = new System.Drawing.Point(346, 293);
            this.button_Rented.Name = "button_Rented";
            this.button_Rented.Size = new System.Drawing.Size(75, 23);
            this.button_Rented.TabIndex = 4;
            this.button_Rented.Text = "Rent";
            this.button_Rented.UseVisualStyleBackColor = true;
            this.button_Rented.Click += new System.EventHandler(this.button_Rented_Click);
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Price.Location = new System.Drawing.Point(70, 192);
            this.numericUpDown_Price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_Price.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Price.TabIndex = 5;
            this.numericUpDown_Price.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // FinalRentRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown_Price);
            this.Controls.Add(this.button_Rented);
            this.Controls.Add(this.dateTimePicker_EndDate);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_EnterUsername);
            this.Name = "FinalRentRoom";
            this.Text = "FinalRentRoom";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_EnterUsername;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.Button button_Rented;
        private System.Windows.Forms.NumericUpDown numericUpDown_Price;
    }
}