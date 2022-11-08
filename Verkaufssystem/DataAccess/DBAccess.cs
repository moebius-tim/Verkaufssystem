using System;
using Model;
using MySql.Data.MySqlClient;

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


        public bool SaveSchuh(Schuh s)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(@"SERVER = localhost;DATABASE=verkaufssystem;UID=root;PASSWORD=login;");

                con.Open();

                string insert = $@"INSERT INTO `verkaufssystem`.`tblschuh` 
                                    (`sID`, `schuhname`, `beschreibung`, `preis`, `fidmarke`, `farbe`) 
                                   VALUES (' ', '{s.Name}', '{s.Beschreibung}', '{s.Preis}', '{s.FidMarke}', '{s.Farbe}');"; // Statt string Bsp.: 'text' -> {t.AnzahlWdh}

                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }

    //        https://csharp-hilfe.de/csharp-mit-sql-verbinden/
}

