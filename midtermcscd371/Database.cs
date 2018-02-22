using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermcscd371
{
    class Database
    {
        private static string DATABASE_NAME = "FileWatcherDB.sqlite";
        private static string TABLE = "fileLog";

        public static string DatabaseName
        {
            get { return DATABASE_NAME; }
        }

        public static string TableName
        {
            get { return TABLE; }
        }
    }
}
