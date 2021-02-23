namespace RSA
{
    partial class Agent
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
            this.button_HouseRent = new System.Windows.Forms.Button();
            this.button_RoomRent = new System.Windows.Forms.Button();
            this.button_BedRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_HouseRent
            // 
            this.button_HouseRent.Location = new System.Drawing.Point(12, 140);
            this.button_HouseRent.Name = "button_HouseRent";
            this.button_HouseRent.Size = new System.Drawing.Size(75, 23);
            this.button_HouseRent.TabIndex = 0;
            this.button_HouseRent.Text = "House";
            this.button_HouseRent.UseVisualStyleBackColor = true;
            this.button_HouseRent.Click += new System.EventHandler(this.button_HouseRent_Click);
            // 
            // button_RoomRent
            // 
            this.button_RoomRent.Location = new System.Drawing.Point(143, 140);
            this.button_RoomRent.Name = "button_RoomRent";
            this.button_RoomRent.Size = new System.Drawing.Size(75, 23);
            this.button_RoomRent.TabIndex = 1;
            this.button_RoomRent.Text = "Room";
            this.button_RoomRent.UseVisualStyleBackColor = true;
            this.button_RoomRent.Click += new System.EventHandler(this.button_RoomRent_Click);
            // 
            // button_BedRent
            // 
            this.button_BedRent.Location = new System.Drawing.Point(263, 140);
            this.button_BedRent.Name = "button_BedRent";
            this.button_BedRent.Size = new System.Drawing.Size(75, 23);
            this.button_BedRent.TabIndex = 2;
            this.button_BedRent.Text = "Bed";
            this.button_BedRent.UseVisualStyleBackColor = true;
            // 
            // Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 253);
            this.Controls.Add(this.button_BedRent);
            this.Controls.Add(this.button_RoomRent);
            this.Controls.Add(this.button_HouseRent);
            this.Name = "Agent";
            this.Text = "Agent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_HouseRent;
        private System.Windows.Forms.Button button_RoomRent;
        private System.Windows.Forms.Button button_BedRent;
    }
}