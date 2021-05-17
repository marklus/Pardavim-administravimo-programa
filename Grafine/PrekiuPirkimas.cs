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
using System.IO;

namespace Grafine
{
    public partial class PrekiuPirkimas : Form
    {
        private int ID;
        private string SellerWarehouseCode;
        public PrekiuPirkimas(int partId, string warehouseCode)
        {
            InitializeComponent();
            GetWarehouses();
            this.ID = partId;
            this.SellerWarehouseCode = warehouseCode;                   //prekes ID
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            //Console.Write(comboBoxWarehouse.SelectedIndex);
            string warehouse = comboBoxWarehouse.SelectedItem.ToString();
            int amount = (int)numericUpDownAmount.Value;
            string parts = "";
            int takenSpace = 0;
            int maxSpace = 0;
            int freeSpace = 0;
            //string part = Database.ConvertToWarehouseFormat(ID, Mark, Type, Year, Maker, Price, amount, Code);
            MySqlDataReader outputStreamWarehouses = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE (vartotojoID='{Database.GetUserID()}' AND pavadinimas='{warehouse}');");
            while(outputStreamWarehouses.Read())
            {
                parts += outputStreamWarehouses["prekes"];
                takenSpace = (int)outputStreamWarehouses["uzimtumas"];
                maxSpace = (int)outputStreamWarehouses["uzimtumas"] + (int)outputStreamWarehouses["laisvas_plotas"];
                freeSpace = (int)outputStreamWarehouses["laisvas_plotas"];

            }
            takenSpace += amount;
            int takenSpaceFree = freeSpace - amount;
            parts += $"{ID},{amount};";

            Database.Close();
            if(amount < freeSpace)
            {

                if (UpdateSourceDatabase())
                { 
                    Database.Update($"UPDATE dalysadmin.sandeliai SET prekes = '{parts}', uzimtumas ='{takenSpace}', laisvas_plotas ='{takenSpaceFree}' WHERE (vartotojoID = '{Database.GetUserID()}' AND pavadinimas='{warehouse}');");
                    MessageBox.Show("Pirkimas pavyko!");
                    comboBoxWarehouse_SelectedIndexChanged(sender, e);
                    Database.Close();
                }
                
            }
            else 
            {
                MessageBox.Show("Sandelyje nėra vietos jūsų nurodytam kiekiui!");
            }
            
            
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

        private bool UpdateSourceDatabase()
        {
            Console.WriteLine("start " + SellerWarehouseCode);
            MySqlDataReader outputStreamWarehouses = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE (vidKo = '{SellerWarehouseCode}');");
            int amount = (int)numericUpDownAmount.Value;
            string parts = "";
            int takenSpace = 0;
            int maxSpace = 0;
            int freeSpace = 0;
            string newParts = "";
            string newPart = "";
            while (outputStreamWarehouses.Read())
            {
                Console.WriteLine(outputStreamWarehouses["pavadinimas"].ToString());
                string allParts = outputStreamWarehouses["prekes"].ToString();
                takenSpace = (int)outputStreamWarehouses["uzimtumas"];
                freeSpace = (int)outputStreamWarehouses["laisvas_plotas"];
                string[] partCodeAmounts = allParts.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach(string warehouseCode in partCodeAmounts)
                {
                    PartClass partData;
                    int partID = Int32.Parse(warehouseCode.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                    int sourceAmount = Int32.Parse(warehouseCode.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                    Console.WriteLine($"{partID} {ID}");
                    if (partID != ID)
                    {
                        newParts += warehouseCode + ";";
                        Console.WriteLine("e");
                    }
                    else if(partID == ID && (sourceAmount - amount < 0))
                    {
                        Console.WriteLine("g");
                        MessageBox.Show("Pardavėjo sandelyje nėra jūsų nurodytam kiekio prekių!");
                        return false;
                    }
                    else 
                    {
                        Console.WriteLine("f");
                        newPart = $"{partID},{sourceAmount - amount};";
                        newParts += newPart;
                        freeSpace += amount;
                        takenSpace -= amount;
                        Database.Update($"UPDATE dalysadmin.sandeliai SET prekes='{newParts}', uzimtumas ='{takenSpace}', laisvas_plotas ='{freeSpace}' WHERE (vidKo = '{SellerWarehouseCode}');");
                        return true;
                    }
                }


            }
            Database.Close();
            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string warehouse = comboBoxWarehouse.SelectedItem.ToString();
            MySqlDataReader outputStreamWarehouses = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE (vartotojoID='{Database.GetUserID()}' AND pavadinimas='{warehouse}');");
            int freeSpace =0;
            int takenSpace =0;
            while (outputStreamWarehouses.Read())
            {
                takenSpace = (int)outputStreamWarehouses["uzimtumas"];
                freeSpace = (int)outputStreamWarehouses["laisvas_plotas"];
            }
            Database.Close();
            textBoxFree.Text = freeSpace.ToString();
            textBoxTaken.Text = takenSpace.ToString();

        }
        private void UpdateFields()
        {

        }

        private void informacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informacija newForm = new Informacija();
            newForm.ShowDialog();
            this.Close();

        }

        private void atsijungtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter clear = new StreamWriter("logins.txt");
            clear.Close();

            this.Hide();
            Login newForm = new Login();
            newForm.ShowDialog();
            this.Close();

        }

        private void pradinisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();

        }

        private void katalogasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katalogas newForm = new Katalogas();
            newForm.ShowDialog();
            this.Close();

        }
    }
}
