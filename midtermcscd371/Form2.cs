using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midtermcscd371
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            this.comboBox_extention.Items.Add("All Files (*)");
            this.comboBox_extention.Items.AddRange(Extensions.FileExtensions);

            try
            {
                UpdateDataGrid(GetConnection(), String.Format("SELECT * FROM {0}", Database.TableName));
            }

            catch (SQLiteException)
            {
                // Pass if the database has not been created yet.
                // This will be fixed on the first write occurance.
            }

        }

        private void UpdateDataGrid(SQLiteConnection con, string sql)
        {
            DataSet dataSet = new DataSet();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con);
            dataAdapter.Fill(dataSet);
            this.dataGridView.DataSource = dataSet.Tables[0].DefaultView;
        }

        private SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(String.Format("Data Source={0}; Version=3;", Database.DatabaseName));
            return conn;
        }

        private void button_submit_query_Click(object sender, EventArgs e)
        {
            string ext = "";
            if (this.comboBox_extention.SelectedItem == null)
            {
                ext = this.comboBox_extention.Text;
            }

            else
            {
                ext = this.comboBox_extention.SelectedItem.ToString();
                ext = "." + ext.ToLower();
            }

            string q = "";
            if (ext == ".all files (*)")
            {
                q = String.Format("SELECT * FROM {0}", Database.TableName);
            }
            else
            {
                q = String.Format("SELECT * FROM {0} WHERE {1}.extension = '{2}'", Database.TableName, Database.TableName, ext);
            }

            UpdateDataGrid(GetConnection(), q);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
