namespace RSA
{
    partial class Add
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
            this.label_RentAs = new System.Windows.Forms.Label();
            this.button_AsHouse = new System.Windows.Forms.Button();
            this.button_AsRooms = new System.Windows.Forms.Button();
            this.button_AsBeds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_RentAs
            // 
            this.label_RentAs.AutoSize = true;
            this.label_RentAs.Location = new System.Drawing.Point(173, 92);
            this.label_RentAs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RentAs.Name = "label_RentAs";
            this.label_RentAs.Size = new System.Drawing.Size(99, 13);
            this.label_RentAs.TabIndex = 0;
            this.label_RentAs.Text = "Rent your house as";
            this.label_RentAs.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_AsHouse
            // 
            this.button_AsHouse.Location = new System.Drawing.Point(176, 134);
            this.button_AsHouse.Margin = new System.Windows.Forms.Padding(2);
            this.button_AsHouse.Name = "button_AsHouse";
            this.button_AsHouse.Size = new System.Drawing.Size(107, 35);
            this.button_AsHouse.TabIndex = 1;
            this.button_AsHouse.Text = "House";
            this.button_AsHouse.UseVisualStyleBackColor = true;
            this.button_AsHouse.Click += new System.EventHandler(this.button_AsHouse_Click);
            // 
            // button_AsRooms
            // 
            this.button_AsRooms.Location = new System.Drawing.Point(176, 200);
            this.button_AsRooms.Margin = new System.Windows.Forms.Padding(2);
            this.button_AsRooms.Name = "button_AsRooms";
            this.button_AsRooms.Size = new System.Drawing.Size(107, 35);
            this.button_AsRooms.TabIndex = 2;
            this.button_AsRooms.Text = "Rooms";
            this.button_AsRooms.UseVisualStyleBackColor = true;
            this.button_AsRooms.Click += new System.EventHandler(this.button_AsRooms_Click);
            // 
            // button_AsBeds
            // 
            this.button_AsBeds.Location = new System.Drawing.Point(176, 272);
            this.button_AsBeds.Margin = new System.Windows.Forms.Padding(2);
            this.button_AsBeds.Name = "button_AsBeds";
            this.button_AsBeds.Size = new System.Drawing.Size(107, 35);
            this.button_AsBeds.TabIndex = 3;
            this.button_AsBeds.Text = "Beds";
            this.button_AsBeds.UseVisualStyleBackColor = true;
            this.button_AsBeds.Click += new System.EventHandler(this.button_AsBeds_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 352);
            this.Controls.Add(this.button_AsBeds);
            this.Controls.Add(this.button_AsRooms);
            this.Controls.Add(this.button_AsHouse);
            this.Controls.Add(this.label_RentAs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_RentAs;
        private System.Windows.Forms.Button button_AsHouse;
        private System.Windows.Forms.Button button_AsRooms;
        private System.Windows.Forms.Button button_AsBeds;
    }
}