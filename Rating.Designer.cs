namespace RSA
{
    partial class Rating
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
            this.comboBox_Rate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Rate
            // 
            this.comboBox_Rate.FormattingEnabled = true;
            this.comboBox_Rate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_Rate.Location = new System.Drawing.Point(77, 86);
            this.comboBox_Rate.Name = "comboBox_Rate";
            this.comboBox_Rate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Rate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rate your agent";
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(99, 122);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(75, 23);
            this.button_Enter.TabIndex = 2;
            this.button_Enter.Text = "Enter";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 151);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Rate);
            this.Name = "Rating";
            this.Text = "Rating";
            this.Load += new System.EventHandler(this.Rating_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Enter;
    }
}