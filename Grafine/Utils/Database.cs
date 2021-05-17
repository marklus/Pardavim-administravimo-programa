using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Grafine.Utils
{
    class Database
    {
        private static Random rand = new Random();
        private static char[] library = { 'a', 'b', 'c', 'd', 'f', 'g' };
        static string fileName = "logins.txt";
        protected static string hash = "f0xle@rn.l";
        //static FileStream Logins = new FileStream(fileName, FileMode.Open);

        static private string server = "94.244.85.38";
        static private string database = "dalysadmin";
        static private string uid = "root";
        static private string password = "password";
        private static string port = "3306";
        static private string connstring = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};";
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

        public static string GenerateCode()
        {
            var code = new StringBuilder();
            code.Append(CodeString(5));
            code.Append(CodeInt(1000, 9999));
            return code.ToString();
        }
        private static string CodeString(int length, bool lowerCase = false)
        {
            StringBuilder code = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                code.Append(library[rand.Next(0, library.Length - 1)]);
            }
            return code.ToString();
        }
        private static string CodeInt(int min, int max)
        {
            string e = rand.Next(min, max).ToString();
            return e;
        }

        public static string GetUsername()
        {
            string ret = "";
            using (StreamReader Logins = new StreamReader(fileName))
            {
                ret = Logins.ReadLine();
            }
            //Logins.Close();
            return ret;
        }

        public static int GetUserID()
        {
            string ret = "";
            using (StreamReader Logins = new StreamReader(fileName))
            {
                Logins.ReadLine();
                ret = Logins.ReadLine();
            }
            //LoginsRead.Close();
            return Int32.Parse(ret);
        }
        public static void Activate(string userName, string ID)
        {
            using (StreamWriter Logins = new StreamWriter(fileName))
            {
                Logins.WriteLine(userName);
                Logins.WriteLine(ID);
            }
            //LoginsWrite.Close();
        }

        public static string ConvertToWarehouseFormat(int id, string mark, string type, int year, string maker, int price, int amount, string code)
        {
            string ret = $"{id},{mark},{type},{year},{maker},{price},{amount},{code}";
            return ret;
        }

        public static PartClass ConvertFromWarehouseFormat(int id, int amount, string warehouseCode)
        {
            PartClass partData = new PartClass();

            MySqlDataReader outputStreamParts = Database.Select($"SELECT * FROM dalysadmin.dalys WHERE ID='{id}';");

            while(outputStreamParts.Read())
            {
                partData = new PartClass(id,
                    outputStreamParts["marke"].ToString(),
                    outputStreamParts["tipas"].ToString(),
                    (int)outputStreamParts["gamybos_metai"],
                    outputStreamParts["gamintojas"].ToString(),
                    (int)outputStreamParts["kaina"],
                    amount,
                    outputStreamParts["vidKo"].ToString());
            }

            outputStreamParts.Close();
            return partData;
        }
        public static bool CodeExists(string targetTable, string code)
        {
            bool exists = false;
            int counter = 0;
            MySqlDataReader outputStream = Database.Select($"SELECT * FROM dalysadmin.{targetTable} WHERE vidKo ='{code}'");
            while(outputStream.Read())
            {
                counter++;
            }
            if(counter != 0)
            {
                exists = true;
            }
            else 
            {
                exists = false;
            }
            return exists;
        }
        public static string GetUsername(int userID)
        {
            string username = "";
            MySqlDataReader outputStream = Database.Select($"SELECT * FROM dalysadmin.vartotojai WHERE id ='{userID}';");
            while(outputStream.Read())
            {
                username = outputStream["vardas"].ToString();
            }
            outputStream.Close();
            return username;
        }
        public static string GetUserCodeByID(int userID)
        {
            string userCode = Database.Select($"SELECT * FROM dalysadmin.vartotojai WHERE id ='{userID}';")["vidKo"].ToString();
            //Console.WriteLine(userCode);
            Close();
            return "";
        }
        public static string GetUserIDByName(string userName)
        {
            string userCode = "";
            MySqlDataReader outputStream = Database.Select($"SELECT * FROM dalysadmin.vartotojai WHERE vardas ='{userName}';");
            while(outputStream.Read())
            {
                userCode = outputStream["id"].ToString();
            }
            Console.WriteLine(userCode);
            Close();
            return userCode;
        }

        public static string Encrypt(string value)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(value);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = key,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        public static string Decrypt(string value)
        {
            byte[] data = Convert.FromBase64String(value);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = key,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
        public static string GetGlobalPartByID(int partID)
        {
            MySqlDataReader parts = Database.Select($"SELECT * FROM dalysadmin.dalys WHERE id ='{partID}';");
            string partData = "";
            while(parts.Read())
            {
                partData = $"{parts["marke"].ToString()}, {parts["tipas"].ToString()}, {parts["gamybos_metai"].ToString()}, {parts["gamintojas"].ToString()}, kaina:{parts["kaina"].ToString()}";
            }

            parts.Close();
            return partData;
        }
    }
}