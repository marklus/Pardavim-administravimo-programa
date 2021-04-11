using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafine.Utils
{
    class Database
    {
        static private string server = "localhost";
        static private string database = "dalysadmin";
        static private string uid = "root";
        static private string password = "password";//meme
        static private string connstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        private string CurrentActiveUser = "";
        private string CurrentActivePassword = "";
        public static MySqlConnection connection;
        public static MySqlConnection Connect()
        {
            connection = new MySqlConnection(connstring);
            /*try
            {
                connection.Open();
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
            }*/
            connection.Open();
            return connection;
        }
        public void ActivateUser(string activeUser, string password)
        {
            Connect();
            CurrentActiveUser = activeUser;
            CurrentActivePassword = password;

        }

        //DML proto

        static public MySqlDataReader Select(string query)  //TODO
        {
            Connect();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader inputStream = cmd.ExecuteReader();
            /*while (inputStream.Read())
            {
                Console.WriteLine(inputStream["id"] + " " + inputStream["vardas"] + " " + inputStream["spalva"] + " " + inputStream["amzius"]);
            }*/
            return inputStream;
        }

        static public void Insert(string query)
        {
            Connect();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteReader();
            //MySqlDataReader inputStream = cmd.ExecuteReader();
        }

        static public void Delete(string query)
        {
            Connect();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteReader();
        }
        static public void Update(string query)
        {
            Connect();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteReader();
        }

        static public void Close()
        {
            connection.Close();
        }
    }
}