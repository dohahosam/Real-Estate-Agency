namespace RSA
{
    partial class Rent
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
            this.button_House = new System.Windows.Forms.Button();
            this.button_Room = new System.Windows.Forms.Button();
            this.button_Bed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_House
            // 
            this.button_House.Location = new System.Drawing.Point(28, 158);
            this.button_House.Name = "button_House";
            this.button_House.Size = new System.Drawing.Size(167, 40);
            this.button_House.TabIndex = 0;
            this.button_House.Text = "House";
            this.button_House.UseVisualStyleBackColor = true;
            this.button_House.Click += new System.EventHandler(this.button_House_Click);
            // 
            // button_Room
            // 
            this.button_Room.Location = new System.Drawing.Point(321, 158);
            this.button_Room.Name = "button_Room";
            this.button_Room.Size = new System.Drawing.Size(189, 40);
            this.button_Room.TabIndex = 1;
            this.button_Room.Text = "Room";
            this.button_Room.UseVisualStyleBackColor = true;
            // 
            // button_Bed
            // 
            this.button_Bed.Location = new System.Drawing.Point(627, 158);
            this.button_Bed.Name = "button_Bed";
            this.button_Bed.Size = new System.Drawing.Size(161, 40);
            this.button_Bed.TabIndex = 2;
            this.button_Bed.Text = "Bed";
            this.button_Bed.UseVisualStyleBackColor = true;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Bed);
            this.Controls.Add(this.button_Room);
            this.Controls.Add(this.button_House);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_House;
        private System.Windows.Forms.Button button_Room;
        private System.Windows.Forms.Button button_Bed;
    }
}