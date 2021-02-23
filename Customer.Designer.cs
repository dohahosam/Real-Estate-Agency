namespace RSA
{
    partial class Customer
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
            this.button_Rate = new System.Windows.Forms.Button();
            this.button_Rent = new System.Windows.Forms.Button();
            this.button_AddAppartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Rate
            // 
            this.button_Rate.FlatAppearance.BorderSize = 5;
            this.button_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rate.Location = new System.Drawing.Point(356, 149);
            this.button_Rate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Rate.Name = "button_Rate";
            this.button_Rate.Size = new System.Drawing.Size(357, 117);
            this.button_Rate.TabIndex = 0;
            this.button_Rate.Text = "Rate Agent";
            this.button_Rate.UseVisualStyleBackColor = true;
            this.button_Rate.Click += new System.EventHandler(this.button_Rate_Click);
            // 
            // button_Rent
            // 
            this.button_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rent.Location = new System.Drawing.Point(356, 372);
            this.button_Rent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Rent.Name = "button_Rent";
            this.button_Rent.Size = new System.Drawing.Size(357, 117);
            this.button_Rent.TabIndex = 1;
            this.button_Rent.Text = "Rent";
            this.button_Rent.UseVisualStyleBackColor = true;
            this.button_Rent.Click += new System.EventHandler(this.button_Rent_Click);
            // 
            // button_AddAppartment
            // 
            this.button_AddAppartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddAppartment.Location = new System.Drawing.Point(356, 582);
            this.button_AddAppartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddAppartment.Name = "button_AddAppartment";
            this.button_AddAppartment.Size = new System.Drawing.Size(357, 114);
            this.button_AddAppartment.TabIndex = 2;
            this.button_AddAppartment.Text = "Add Appartment";
            this.button_AddAppartment.UseVisualStyleBackColor = true;
            this.button_AddAppartment.Click += new System.EventHandler(this.button_AddAppartment_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 715);
            this.Controls.Add(this.button_AddAppartment);
            this.Controls.Add(this.button_Rent);
            this.Controls.Add(this.button_Rate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Rate;
        private System.Windows.Forms.Button button_Rent;
        private System.Windows.Forms.Button button_AddAppartment;
    }
}