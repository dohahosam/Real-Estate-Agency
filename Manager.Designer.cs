namespace RSA
{
    partial class Manager
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
            this.button_AddEmp = new System.Windows.Forms.Button();
            this.button_ViewEditEmp = new System.Windows.Forms.Button();
            this.button_ViewHousing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AddEmp
            // 
            this.button_AddEmp.Location = new System.Drawing.Point(265, 71);
            this.button_AddEmp.Name = "button_AddEmp";
            this.button_AddEmp.Size = new System.Drawing.Size(209, 64);
            this.button_AddEmp.TabIndex = 0;
            this.button_AddEmp.Text = "Add Employee";
            this.button_AddEmp.UseVisualStyleBackColor = true;
            this.button_AddEmp.Click += new System.EventHandler(this.button_AddEmp_Click);
            // 
            // button_ViewEditEmp
            // 
            this.button_ViewEditEmp.Location = new System.Drawing.Point(265, 207);
            this.button_ViewEditEmp.Name = "button_ViewEditEmp";
            this.button_ViewEditEmp.Size = new System.Drawing.Size(209, 70);
            this.button_ViewEditEmp.TabIndex = 1;
            this.button_ViewEditEmp.Text = "View and Edit Employee";
            this.button_ViewEditEmp.UseVisualStyleBackColor = true;
            this.button_ViewEditEmp.Click += new System.EventHandler(this.button_ViewEditEmp_Click);
            // 
            // button_ViewHousing
            // 
            this.button_ViewHousing.Location = new System.Drawing.Point(265, 367);
            this.button_ViewHousing.Name = "button_ViewHousing";
            this.button_ViewHousing.Size = new System.Drawing.Size(209, 67);
            this.button_ViewHousing.TabIndex = 2;
            this.button_ViewHousing.Text = "View Housings";
            this.button_ViewHousing.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ViewHousing);
            this.Controls.Add(this.button_ViewEditEmp);
            this.Controls.Add(this.button_AddEmp);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddEmp;
        private System.Windows.Forms.Button button_ViewEditEmp;
        private System.Windows.Forms.Button button_ViewHousing;
    }
}