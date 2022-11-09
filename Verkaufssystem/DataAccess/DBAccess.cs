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
                                   VALUES (' ', '{s.Name}', '{s.Beschreibung}', '{s.Preis}', '{s.FidMarke}', '{s.Farbe}');";

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = insert;
                cmd.Connection = con;

                MySqlDataReader reader = cmd.ExecuteReader();

                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool CheckLoginData(Login l)
        {
            bool loginIsMatching = false;

            try
            {
                MySqlConnection con = new MySqlConnection(@"SERVER = localhost;DATABASE=verkaufssystem;UID=root;PASSWORD=login;");

                con.Open();

                string select = $@"SELECT `email`, `passwort` FROM `verkaufssystem`.`tblkundenlogin`;";

                // Zeilenweise auslesen ( Schleife )
                // in jedem Zeilendurchgang abgleichen, ob werte '{l.email}' und '{l.passwort}' gefunden wurden

                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = select;
                cmd.Connection = con;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reader.GetValue(0).ToString();
                    reader.GetValue(1).ToString();

                    if ( l.Email.Equals(reader.GetString(0) )
                      && l.Passwort.Equals(reader.GetString(1))
                       )
                    {
                        loginIsMatching = true;
                        //status message einbauen
                    }
                    else
                    {
                        loginIsMatching = false;
                        //status message einabauen
                    }
                }

                return loginIsMatching;
            }
            catch (Exception)
            {
                return loginIsMatching;
                throw;
            }
        }
    }
}

