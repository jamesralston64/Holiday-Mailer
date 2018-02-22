using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using System.Collections;

namespace midtermcscd371
{
    class FileWatcher
    {
        private static string[] LIST = { ".sqlite", ".sqlite-journal", "Debug" };

        private string extension;
        private FileSystemWatcher watcher;
        private ListView listView;

        public FileWatcher(ListView view)
        {
            listView = view;
        }

        public void Run(string extention, string path)
        {
            watcher = new FileSystemWatcher();
            extension = extention;

            watcher.Path = path;
            watcher.IncludeSubdirectories = true;
            watcher.Filter = "";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // initialize the database
            initDB();

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        public void WriteToDatabase()
        {
            ArrayList records = new ArrayList();
            foreach (ListViewItem itemRow in listView.Items)
            {

                IEnumerator e = itemRow.SubItems.GetEnumerator();
                string[] row = new string[5];
                bool hasNext = true;
                int i = 0;

                while (hasNext = e.MoveNext())
                {
                    ListViewSubItem sub = (ListViewSubItem)e.Current;
                    row[i] = sub.Text;
                    i++;
                }

                records.Add(row);

            }

            foreach (string[] record in records)
            {
                InsertRecord(record: record);
            }

            if (listView.InvokeRequired)
            {
                listView.Invoke(new MethodInvoker(delegate {
                    listView.Items.Clear();
                }));
            }
            else
            {
                listView.Items.Clear();
            }
        }

        public void stop()
        {
            if (watcher != null)
            {
                watcher.EnableRaisingEvents = false;
            }
        }

        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e)
        {

            if (isValidFile(e.FullPath))
            {
                string time = DateTime.Now.ToString();
                WriteOut(source, e, time);
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            if (isValidFile(e.FullPath))
            {
                string time = DateTime.Now.ToString();
                WriteOut(source, e, time);
            }
        }

        private void WriteOut(object source, FileSystemEventArgs e, string time)
        {
            if (listView.Items.Count >= 1000)
            {
                WriteToDatabase();
            }

            string ext = Path.GetExtension(e.FullPath);

            if (ext == "")
            {
                ext = "none";
            }


            string[] row = { e.Name, e.FullPath, e.ChangeType.ToString(), ext };
            var listViewItem = new ListViewItem(time);
            listViewItem.SubItems.AddRange(row);


            if (listView.InvokeRequired)
            {
                listView.Invoke(new MethodInvoker(delegate {
                    listView.Items.Add(listViewItem);
                }));
            }

            else
            {
                listView.Items.Add(listViewItem);
            }

        }

        private static void InsertRecord(string[] record)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(String.Format(
                    "Data Source={0}; Version=3;",
                    Database.DatabaseName));

                conn.Open();

                string q2 = String.Format("INSERT INTO {0} (time, name, path, change, extension) values ('{1}', '{2}', '{3}', '{4}', '{5}')", Database.TableName,
                    record[0],
                    record[1],
                    record[2],
                    record[3],
                    record[4]);
                SQLiteCommand c2 = new SQLiteCommand(q2, conn);
                c2.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception)
            {

                throw;
            }
        }

        private static void initDB()
        {
            if (!File.Exists(Database.DatabaseName))
            {
                SQLiteConnection.CreateFile(Database.DatabaseName);
            }

            SQLiteConnection conn = new SQLiteConnection(String.Format("Data Source={0}; Version=3;", Database.DatabaseName));
            try
            {
                conn.Open();
                string q = String.Format("CREATE TABLE IF NOT EXISTS {0} (time VARCHAR(100), name VARCHAR(100), path VARCHAR(100), change VARCHAR(100), extension VARCHAR(100))", Database.TableName);
                SQLiteCommand c = new SQLiteCommand(q, conn);
                c.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw;
            }

            finally
            {
                conn.Close();
            }

        }

        private bool isValidFile(string path)
        {
            if (!path.EndsWith(extension) && !path.EndsWith(extension.ToLower()))
            {
                return false;
            }

            foreach (string e in LIST)
            {

                if (path.EndsWith(e))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
