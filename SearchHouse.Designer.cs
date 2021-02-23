namespace RSA
{
    partial class SearchHouse
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
            this.comboBox_Location = new System.Windows.Forms.ComboBox();
            this.dataGridView_Houses = new System.Windows.Forms.DataGridView();
            this.dataGridView_AgentsArea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Houses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AgentsArea)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Location
            // 
            this.comboBox_Location.FormattingEnabled = true;
            this.comboBox_Location.Location = new System.Drawing.Point(120, 165);
            this.comboBox_Location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Location.Name = "comboBox_Location";
            this.comboBox_Location.Size = new System.Drawing.Size(180, 28);
            this.comboBox_Location.TabIndex = 0;
            this.comboBox_Location.SelectedIndexChanged += new System.EventHandler(this.comboBox_Location_SelectedIndexChanged);
            // 
            // dataGridView_Houses
            // 
            this.dataGridView_Houses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Houses.Location = new System.Drawing.Point(120, 274);
            this.dataGridView_Houses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Houses.Name = "dataGridView_Houses";
            this.dataGridView_Houses.Size = new System.Drawing.Size(632, 366);
            this.dataGridView_Houses.TabIndex = 1;
            // 
            // dataGridView_AgentsArea
            // 
            this.dataGridView_AgentsArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AgentsArea.Location = new System.Drawing.Point(832, 334);
            this.dataGridView_AgentsArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_AgentsArea.Name = "dataGridView_AgentsArea";
            this.dataGridView_AgentsArea.Size = new System.Drawing.Size(360, 231);
            this.dataGridView_AgentsArea.TabIndex = 2;
            // 
            // SearchHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView_AgentsArea);
            this.Controls.Add(this.dataGridView_Houses);
            this.Controls.Add(this.comboBox_Location);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchHouse";
            this.Text = "SearchHouse";
            this.Load += new System.EventHandler(this.SearchHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Houses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AgentsArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Location;
        private System.Windows.Forms.DataGridView dataGridView_Houses;
        private System.Windows.Forms.DataGridView dataGridView_AgentsArea;
    }
}