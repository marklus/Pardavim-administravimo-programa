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
    public partial class DeletingStorehouse : Form
    {
        public DeletingStorehouse()
        {
            InitializeComponent();
        }

        private void DeletingStorehouse_Load(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int storeHouseID = int.Parse(textBoxStorehouseId.Text);
            string storehouseName = textBoxStorehouseName.Text;
            int counter = 0;
            Dictionary<int, string> output = new Dictionary<int, string>();
            MySqlDataReader outputStream = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE ID ='{storeHouseID}' AND pavadinimas ='{storehouseName}';");
            while (outputStream.Read())
            {
                counter++;
                Console.WriteLine((int)outputStream["ID"] + " " + outputStream["pavadinimas"]);
                output.Add((int)outputStream["ID"], outputStream["pavadinimas"].ToString());

                /*                counter++;
                Console.WriteLine((int)outputStream["ID"] + " " + outputStream["pavadinimas"]);
                output.Add((int)outputStream["ID"], outputStream["pavadinimas"].ToString());*/

            }
            //     outputStream = Database.Select($"DELETE * FROM dalysadmin.sandeliai WHERE ID ='{storeHouseID}' AND pavadinimas ='{storehouseName}';");
            Database.Close();
            if (counter > 0)
            {
                if (checkBoxDeleteParts.Checked && output.ElementAt(0).Value == storehouseName)
                {
                    outputStream = Database.Select($"DELETE FROM dalysadmin.sandeliai WHERE ID ='{storeHouseID}' AND pavadinimas ='{storehouseName}';");
                    outputStream = Database.Select($"DELETE FROM dalysadmin.dalys WHERE vidKo ='{storeHouseID}';");

                    popup newForm = new popup("Sandėlys ir jame buvusios dalys buvo sėkmingai pašalinti iš duomenų bazės.");
                    newForm.ShowDialog();
                }
                //output.ElementAt(0).Key == storeHouseID )
                else if (output.ElementAt(0).Value == storehouseName)
                {
                    outputStream = Database.Select($"DELETE FROM dalysadmin.sandeliai WHERE ID ='{storeHouseID}' AND pavadinimas ='{storehouseName}';");
                    popup newForm = new popup("Sandėlys buvo sėkmingai pašalintas iš duomenų bazės.");
                    /*//Console.WriteLine("pavyko");
                    this.Hide();
                    Main newForm = new Main();
                    newForm.ShowDialog();
                    this.Close();*/
                }

            }
            else if (counter == 0)
            {
                popup newForm = new popup("Prašau įveskite tinkamą sandėlio pavadinimą arba ID.");
                newForm.ShowDialog();
                Console.WriteLine($"counter = {counter}");
            }

        }

        private void checkBoxDeleteParts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
