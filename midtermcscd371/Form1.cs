using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midtermcscd371
{
    public partial class Form1 : Form
    {
        private FileWatcher watcher;

        public Form1()
        {
            InitializeComponent();
            this.cb_fileExtention.Items.AddRange(Extensions.FileExtensions);
            this.lstv_log.Columns.Add("Time", 200, HorizontalAlignment.Left);
            this.lstv_log.Columns.Add("Name", 300, HorizontalAlignment.Left);
            this.lstv_log.Columns.Add("Path", 300, HorizontalAlignment.Left);
            this.lstv_log.Columns.Add("Change Type", 100, HorizontalAlignment.Left);
            this.lstv_log.Columns.Add("Extension", 100, HorizontalAlignment.Left);
            watcher = new FileWatcher(this.lstv_log);
        }//end Form1 Ctor

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (isStartValid())
            {
                this.btn_start.Enabled = false;
                string path = this.txtb_path.Text;
                string extension = "";

                if (cb_fileExtention.SelectedItem == null)
                {
                    extension = cb_fileExtention.Text;
                }//end if

                else
                {
                    extension = this.cb_fileExtention.SelectedItem.ToString();
                }//end else

                watcher.Run(extention: extension, path: path);

                this.cb_fileExtention.BackColor = Color.White;
                this.txtb_path.BackColor = Color.White;
            }//end if
        }//end btn_start_click

        private void btn_stop_Click(object sender, EventArgs e)
        {
            watcher.stop();
            this.btn_start.Enabled = true;
        }//end btn_stop_click

        private bool isStartValid()
        {
            bool valid = true;
            string path = this.txtb_path.Text;

            if (path == "" || path == null )
            {

                this.txtb_path.Text = "ERROR: Enter a valid path";
                this.txtb_path.BackColor = Color.Yellow;
                valid = false;

            }//end if

            return valid;
        }//end isStartValid

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_queryDatabase_Click(object sender, EventArgs e)
        {
            Form2 query = new Form2();
            query.Show();
        }

        private void button_writeToDatabase_Click(object sender, EventArgs e)
        {
            if (watcher != null)
            {
                watcher.WriteToDatabase();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.ShowDialog();
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 query = new Form2();
            query.ShowDialog();
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (watcher != null)
            {
                watcher.WriteToDatabase();
            }
        }

        
    }
}
