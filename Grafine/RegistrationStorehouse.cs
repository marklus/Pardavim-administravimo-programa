using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Grafine.Utils;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafine
{
    public partial class RegistrationStorehouse : Form
    {
        public RegistrationStorehouse()
        {
            InitializeComponent();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            string storeHouseID = textBoxStorehouseId.Text;
            string storehouseName = textBoxStorehouseName.Text;
            string storehouseStock = textBoxStock.Text;
            string storehouseStockFree = textBoxStockFree.Text;

            int counter = 0;

            List<string> outputUsers = new List<string>();
            MySqlDataReader outputStreamUsers = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE pavadinimas ='{storehouseName}';");
            while (outputStreamUsers.Read())
            {
                counter++;
            }
            Database.Close();
            if (counter != 0)
            {
                popup newForm = new popup("Sandėlys su tokiu pavadinimu jau užregistruotas");
                newForm.ShowDialog();
            }
            else
            {
                Database.Insert($"INSERT INTO dalysadmin.sandeliai(ID, pavadinimas, laisvas_plotas, uzimtumas) VALUES('{storeHouseID}','{storehouseName}','{storehouseStockFree}','{storehouseStock}'); ");
                Database.Close();
                popup newForm = new popup("Sandėlį pavyko užregistruoti!");
                newForm.ShowDialog();
            }
        }

        private void labelSingIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login newForm = new Login();
            newForm.ShowDialog();
            this.Close();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
