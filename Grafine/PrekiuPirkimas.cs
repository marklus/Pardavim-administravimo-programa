using System;
using Grafine.Utils;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Grafine
{
    public partial class PrekiuPirkimas : Form
    {
        private int ID;
        public PrekiuPirkimas(int id)
        {
            InitializeComponent();
            GetWarehouses();
            this.ID = id;                       //prekes ID
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Console.Write(comboBoxWarehouse.SelectedIndex);
            string warehouse = comboBoxWarehouse.SelectedItem.ToString();
            int amount = (int)numericUpDownAmount.Value;
            string parts = "";
            //string part = Database.ConvertToWarehouseFormat(ID, Mark, Type, Year, Maker, Price, amount, Code);
            MySqlDataReader outputStreamWarehouses = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE (vartotojoID='{Database.GetUserID()}' AND pavadinimas='{warehouse}');");
            while(outputStreamWarehouses.Read())
            {
                parts += outputStreamWarehouses["prekes"];

            }
            parts += $"{ID},{amount};";
            Database.Close();
            Database.Update($"UPDATE dalysadmin.sandeliai SET prekes = '{parts}' WHERE (vartotojoID = '{Database.GetUserID()}' AND pavadinimas='{warehouse}');");
            MessageBox.Show("Pirkimas pavyko!");
            Database.Close();
        }
        private void GetWarehouses()
        {
            string userID = Database.GetUserID();
            MySqlDataReader outputStreamWarehouses = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE vartotojoID='{userID}';");
            while (outputStreamWarehouses.Read())
            {
                Console.WriteLine(outputStreamWarehouses["pavadinimas"].ToString());
                comboBoxWarehouse.Items.Add(outputStreamWarehouses["pavadinimas"].ToString());
            }
            Database.Close();
        }
    }
}
