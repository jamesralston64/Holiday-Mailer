using System;

namespace midtermcscd371
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttp_txtb_fileExtention = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_queryDatabase = new System.Windows.Forms.Button();
            this.cb_fileExtention = new System.Windows.Forms.ComboBox();
            this.txtb_path = new System.Windows.Forms.TextBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.button_writeToDatabase = new System.Windows.Forms.Button();
            this.lstv_log = new System.Windows.Forms.ListView();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_fileExtention = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem,
            this.writeToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.writeToolStripMenuItem.Text = "Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_queryDatabase);
            this.panel1.Controls.Add(this.cb_fileExtention);
            this.panel1.Controls.Add(this.txtb_path);
            this.panel1.Controls.Add(this.lbl_path);
            this.panel1.Controls.Add(this.button_writeToDatabase);
            this.panel1.Controls.Add(this.lstv_log);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.lbl_fileExtention);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 545);
            this.panel1.TabIndex = 1;
            // 
            // button_queryDatabase
            // 
            this.button_queryDatabase.Location = new System.Drawing.Point(491, 485);
            this.button_queryDatabase.Name = "button_queryDatabase";
            this.button_queryDatabase.Size = new System.Drawing.Size(173, 23);
            this.button_queryDatabase.TabIndex = 17;
            this.button_queryDatabase.Text = "Query Database";
            this.button_queryDatabase.UseVisualStyleBackColor = true;
            this.button_queryDatabase.Click += new System.EventHandler(this.button_queryDatabase_Click);
            // 
            // cb_fileExtention
            // 
            this.cb_fileExtention.FormattingEnabled = true;
            this.cb_fileExtention.Location = new System.Drawing.Point(29, 41);
            this.cb_fileExtention.Name = "cb_fileExtention";
            this.cb_fileExtention.Size = new System.Drawing.Size(178, 21);
            this.cb_fileExtention.TabIndex = 16;
            // 
            // txtb_path
            // 
            this.txtb_path.Location = new System.Drawing.Point(401, 42);
            this.txtb_path.Name = "txtb_path";
            this.txtb_path.Size = new System.Drawing.Size(405, 20);
            this.txtb_path.TabIndex = 15;
            this.txtb_path.Text = "C:\\";
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(398, 25);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(204, 13);
            this.lbl_path.TabIndex = 14;
            this.lbl_path.Text = "Enter The Directory You Want To Monitor";
            // 
            // button_writeToDatabase
            // 
            this.button_writeToDatabase.Location = new System.Drawing.Point(312, 485);
            this.button_writeToDatabase.Name = "button_writeToDatabase";
            this.button_writeToDatabase.Size = new System.Drawing.Size(173, 23);
            this.button_writeToDatabase.TabIndex = 13;
            this.button_writeToDatabase.Text = "Write to Database";
            this.button_writeToDatabase.UseVisualStyleBackColor = true;
            this.button_writeToDatabase.Click += new System.EventHandler(this.button_writeToDatabase_Click);
            // 
            // lstv_log
            // 
            this.lstv_log.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstv_log.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstv_log.GridLines = true;
            this.lstv_log.Location = new System.Drawing.Point(12, 181);
            this.lstv_log.Name = "lstv_log";
            this.lstv_log.Size = new System.Drawing.Size(974, 298);
            this.lstv_log.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstv_log.TabIndex = 12;
            this.lstv_log.UseCompatibleStateImageBehavior = false;
            this.lstv_log.View = System.Windows.Forms.View.Details;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.BackgroundImage")));
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_stop.Location = new System.Drawing.Point(608, 68);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(198, 58);
            this.btn_stop.TabIndex = 11;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Location = new System.Drawing.Point(401, 68);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(201, 58);
            this.btn_start.TabIndex = 10;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_fileExtention
            // 
            this.lbl_fileExtention.AutoSize = true;
            this.lbl_fileExtention.Location = new System.Drawing.Point(26, 25);
            this.lbl_fileExtention.Name = "lbl_fileExtention";
            this.lbl_fileExtention.Size = new System.Drawing.Size(175, 13);
            this.lbl_fileExtention.TabIndex = 9;
            this.lbl_fileExtention.Text = "Choose A File Extension To Monitor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttp_txtb_fileExtention;
        private EventHandler label1_Click;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_fileExtention;
        private System.Windows.Forms.TextBox txtb_path;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Button button_writeToDatabase;
        private System.Windows.Forms.ListView lstv_log;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_fileExtention;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button_queryDatabase;
    }
}

