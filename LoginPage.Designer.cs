namespace RSA
{
    partial class LoginPage
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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.materialLabel_Username = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_Password = new MaterialSkin.Controls.MaterialLabel();
            this.button_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(255, 185);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(148, 26);
            this.textBox_Username.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(255, 300);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(148, 26);
            this.textBox_Password.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(255, 368);
            this.button_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(112, 35);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // materialLabel_Username
            // 
            this.materialLabel_Username.AutoSize = true;
            this.materialLabel_Username.Depth = 0;
            this.materialLabel_Username.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_Username.Location = new System.Drawing.Point(44, 186);
            this.materialLabel_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_Username.Name = "materialLabel_Username";
            this.materialLabel_Username.Size = new System.Drawing.Size(111, 27);
            this.materialLabel_Username.TabIndex = 3;
            this.materialLabel_Username.Text = "Username";
            // 
            // materialLabel_Password
            // 
            this.materialLabel_Password.AutoSize = true;
            this.materialLabel_Password.Depth = 0;
            this.materialLabel_Password.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_Password.Location = new System.Drawing.Point(44, 302);
            this.materialLabel_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_Password.Name = "materialLabel_Password";
            this.materialLabel_Password.Size = new System.Drawing.Size(109, 27);
            this.materialLabel_Password.TabIndex = 4;
            this.materialLabel_Password.Text = "Password";
            this.materialLabel_Password.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(255, 443);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(112, 47);
            this.button_Register.TabIndex = 5;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 543);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.materialLabel_Password);
            this.Controls.Add(this.materialLabel_Username);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private MaterialSkin.Controls.MaterialLabel materialLabel_Username;
        private MaterialSkin.Controls.MaterialLabel materialLabel_Password;
        private System.Windows.Forms.Button button_Register;
    }
}