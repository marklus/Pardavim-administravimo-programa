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
    public partial class SandelysRegistracija : Form
    {
        public SandelysRegistracija()
        {
            InitializeComponent();
            textBoxCode.Text = Database.GenerateCode();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            //string storeHouseID = textBoxStorehouseId.Text;
            string storehouseName = textBoxStorehouseName.Text;
            //string storehouseStock = textBoxStock.Text;
            string storehouseStockFree = textBoxStockFree.Text;
            string internalCode = textBoxCode.Text;

            int counter = 0;

            //List<string> outputUsers = new List<string>();
            MySqlDataReader outputStreamWarehouses1 = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE pavadinimas ='{storehouseName}';");
            while (outputStreamWarehouses1.Read())
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
                Console.WriteLine("E");
                counter = 0;
                MySqlDataReader outputStreamWarehouses2 = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE vidKo ='{internalCode}';");
                
                while (outputStreamWarehouses2.Read())
                {
                    counter++;
                }
                Database.Close();

                if(counter != 0)
                {
                    popup newForm = new popup("Sandėlys su tokiu vidiniu kodu jau užregistruotas");
                    newForm.ShowDialog();
                }
                else 
                {
                    Database.Insert($"INSERT INTO dalysadmin.sandeliai(prekes, pavadinimas, laisvas_plotas, uzimtumas, vidKo, vartotojoID) " +
                        $"VALUES('', '{storehouseName}','{storehouseStockFree}', 0, '{internalCode}', '{Database.GetUserID()}'); ");
                    Database.Close();
                    popup newForm = new popup("Sandėlį pavyko užregistruoti!");
                    newForm.ShowDialog();
                }
                
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

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = Database.GenerateCode();
        }
    }
}
