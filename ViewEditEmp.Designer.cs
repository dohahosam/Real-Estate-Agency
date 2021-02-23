namespace RSA
{
    partial class ViewEditEmp
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
            this.textBox_SearchEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Location = new System.Windows.Forms.ComboBox();
            this.dataGridView_Employees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_SearchEmp
            // 
            this.textBox_SearchEmp.Location = new System.Drawing.Point(63, 70);
            this.textBox_SearchEmp.Name = "textBox_SearchEmp";
            this.textBox_SearchEmp.Size = new System.Drawing.Size(100, 20);
            this.textBox_SearchEmp.TabIndex = 2;
            this.textBox_SearchEmp.TextChanged += new System.EventHandler(this.textBox_SearchEmp_TextChanged);
            this.textBox_SearchEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SearchEmp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by location";
            // 
            // comboBox_Location
            // 
            this.comboBox_Location.FormattingEnabled = true;
            this.comboBox_Location.Location = new System.Drawing.Point(327, 69);
            this.comboBox_Location.Name = "comboBox_Location";
            this.comboBox_Location.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Location.TabIndex = 5;
            // 
            // dataGridView_Employees
            // 
            this.dataGridView_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employees.Location = new System.Drawing.Point(15, 118);
            this.dataGridView_Employees.Name = "dataGridView_Employees";
            this.dataGridView_Employees.Size = new System.Drawing.Size(739, 251);
            this.dataGridView_Employees.TabIndex = 6;
            this.dataGridView_Employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Employees_CellClick);
            this.dataGridView_Employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Employees_CellContentClick);
            // 
            // ViewEditEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Employees);
            this.Controls.Add(this.comboBox_Location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SearchEmp);
            this.Name = "ViewEditEmp";
            this.Text = "ViewEditEmp";
            this.Load += new System.EventHandler(this.ViewEditEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_SearchEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Location;
        private System.Windows.Forms.DataGridView dataGridView_Employees;
    }
}