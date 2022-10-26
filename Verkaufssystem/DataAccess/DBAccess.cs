using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class DBAccess
    {
        private static DBAccess _me;
        private DBAccess()
        {

        }

        public static DBAccess GetObject()
        {
            if (_me == null)
            {
                _me = new DBAccess();
                return _me;
            }
            else
            {
                return _me;
            }
        }

        public string ConnectionStringDB { get; set; }


        public void SaveSchuh(Schuh s)
        {

        }

    //   public string connectionString = @"Data Source=Verkaufssystem; Initial Catalog=Verkaufssystem; User ID=root; Password=";
    //
    //   SqlConnection connection = new SqlConnection(connectionString);
    //
    //   connection.open();
    //        https://csharp-hilfe.de/csharp-mit-sql-verbinden/
    //   connection.close();
    }
}
