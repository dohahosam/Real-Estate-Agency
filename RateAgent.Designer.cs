namespace RSA
{
    partial class RateAgent
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
            this.textBox_PhoneNo = new System.Windows.Forms.TextBox();
            this.button_RateAgent = new System.Windows.Forms.Button();
            this.dataGridView_Agent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Agent)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_PhoneNo
            // 
            this.textBox_PhoneNo.Location = new System.Drawing.Point(187, 140);
            this.textBox_PhoneNo.Name = "textBox_PhoneNo";
            this.textBox_PhoneNo.Size = new System.Drawing.Size(125, 20);
            this.textBox_PhoneNo.TabIndex = 0;
            this.textBox_PhoneNo.Text = "10";
            this.textBox_PhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PhoneNo_KeyPress);
            // 
            // button_RateAgent
            // 
            this.button_RateAgent.Location = new System.Drawing.Point(371, 137);
            this.button_RateAgent.Name = "button_RateAgent";
            this.button_RateAgent.Size = new System.Drawing.Size(120, 23);
            this.button_RateAgent.TabIndex = 1;
            this.button_RateAgent.Text = "Rate Agent";
            this.button_RateAgent.UseVisualStyleBackColor = true;
            this.button_RateAgent.Click += new System.EventHandler(this.button_RateAgent_Click);
            // 
            // dataGridView_Agent
            // 
            this.dataGridView_Agent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Agent.Location = new System.Drawing.Point(187, 185);
            this.dataGridView_Agent.Name = "dataGridView_Agent";
            this.dataGridView_Agent.Size = new System.Drawing.Size(444, 146);
            this.dataGridView_Agent.TabIndex = 2;
            this.dataGridView_Agent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Agent_CellContentClick);
            // 
            // RateAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Agent);
            this.Controls.Add(this.button_RateAgent);
            this.Controls.Add(this.textBox_PhoneNo);
            this.Name = "RateAgent";
            this.Text = "RateAgent";
            this.Load += new System.EventHandler(this.RateAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Agent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_PhoneNo;
        private System.Windows.Forms.Button button_RateAgent;
        private System.Windows.Forms.DataGridView dataGridView_Agent;
    }
}