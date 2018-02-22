namespace midtermcscd371
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_submit_query = new System.Windows.Forms.Button();
            this.comboBox_extention = new System.Windows.Forms.ComboBox();
            this.label_query = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 489);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(878, 489);
            this.dataGridView.TabIndex = 0;
            // 
            // button_submit_query
            // 
            this.button_submit_query.Location = new System.Drawing.Point(197, 54);
            this.button_submit_query.Name = "button_submit_query";
            this.button_submit_query.Size = new System.Drawing.Size(75, 23);
            this.button_submit_query.TabIndex = 1;
            this.button_submit_query.Text = "Submit";
            this.button_submit_query.UseVisualStyleBackColor = true;
            this.button_submit_query.Click += new System.EventHandler(this.button_submit_query_Click);
            // 
            // comboBox_extention
            // 
            this.comboBox_extention.FormattingEnabled = true;
            this.comboBox_extention.Location = new System.Drawing.Point(12, 56);
            this.comboBox_extention.Name = "comboBox_extention";
            this.comboBox_extention.Size = new System.Drawing.Size(152, 21);
            this.comboBox_extention.TabIndex = 2;
            // 
            // label_query
            // 
            this.label_query.AutoSize = true;
            this.label_query.Location = new System.Drawing.Point(9, 24);
            this.label_query.Name = "label_query";
            this.label_query.Size = new System.Drawing.Size(247, 13);
            this.label_query.TabIndex = 3;
            this.label_query.Text = "Extension Query:     (Empty = ALL files in database)";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(288, 54);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 587);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label_query);
            this.Controls.Add(this.comboBox_extention);
            this.Controls.Add(this.button_submit_query);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_submit_query;
        private System.Windows.Forms.ComboBox comboBox_extention;
        private System.Windows.Forms.Label label_query;
        private System.Windows.Forms.Button btn_clear;
    }
}