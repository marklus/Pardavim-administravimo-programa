using System;
using Grafine.Utils;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Grafine
{
    public partial class Katalogas : Form
    {
        public Katalogas(int code = 0, string target = "", string item = "")
        {
            InitializeComponent();
            comboBoxFilter.Items.Add("tipas");
            comboBoxFilter.Items.Add("marke");
            comboBoxFilter.Items.Add("gamintojas");
            comboBoxFilter.Items.Add("gamybos+metai");
            comboBoxFilter.Items.Add("kaina");
            
            if (code == 0)
            {
                GetContent();
            }
            else
            {
                Filter(target, item);
            }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Katalogo_pridejimas newForm = new Katalogo_pridejimas();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katalogas newForm = new Katalogas();
            newForm.ShowDialog();
            this.Close();
        }
        private void GetContent()
        {
            MySqlDataReader outputStreamWarehouses = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE vartotojoID != '{Database.GetUserID()}';");
            List<string> warehouses = new List<string>();
            while (outputStreamWarehouses.Read())
            {
                
                warehouses.Add(outputStreamWarehouses["vidKo"].ToString());

                /*dataGridViewContent.Rows.Add(
                    (int)outputStreamParts["id"],
                    outputStreamParts["marke"].ToString(),
                    outputStreamParts["tipas"].ToString(),
                    (int)outputStreamParts["gamybos_metai"],
                    outputStreamParts["gamintojas"].ToString(),
                    (int)outputStreamParts["kaina"],
                    "",//kiekis todo
                    outputStreamParts["vidKo"],
                    "Pirkti"
                    );*/
                
            }
            Database.Close();
            
            foreach(string code in warehouses)
            {
                MySqlDataReader outputStreamParts = Database.Select($"SELECT * FROM dalysadmin.sandeliai WHERE vidKo = '{code}';");
                while (outputStreamParts.Read())
                {
                    string allParts = outputStreamParts["prekes"].ToString();
                    string[] partCodeAmounts = allParts.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string warehouseCode in partCodeAmounts)
                    {
                        //Console.WriteLine(s);
                        PartClass partData;
                        int partID = Int32.Parse(warehouseCode.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                        int amount = Int32.Parse(warehouseCode.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                        partData = Database.ConvertFromWarehouseFormat(partID, amount, code);
                        //Console.WriteLine($"{partID} {amount}");
                        dataGridViewContent.Rows.Add(partData.ID,
                            code,
                            partData.Mark,
                            partData.Type,
                            partData.Year,
                            partData.Maker,
                            partData.Price,
                            partData.Amount,
                            partData.Code,
                            Database.GetUsername(Int32.Parse(outputStreamParts["vartotojoID"].ToString())),
                            "Pirkti");
                    }
                }
                Database.Close();
            }
        }
        private void FormatList()
        {
            int counter = 0;
            MySqlDataReader outputStreamParts = Database.Select($"SELECT * FROM dalysadmin.dalys;");

            while (outputStreamParts.Read())
            {
                counter++;
            }
            Database.Close();
            Tuple<string, string, int, string, int, string>[] PartsTuple = new Tuple<string, string, int, string, int, string>[counter];
            int iterator = 0;
            MySqlDataReader outputStreamParts2 = Database.Select($"SELECT * FROM dalysadmin.dalys;");
            Console.WriteLine(counter);
            while (outputStreamParts2.Read())
            {
                Console.WriteLine(iterator);
                var part = Tuple.Create(outputStreamParts2["marke"].ToString(),
                    outputStreamParts2["tipas"].ToString(),
                    (int)outputStreamParts2["gamybos_metai"],
                    outputStreamParts2["gamintojas"].ToString(),
                    (int)outputStreamParts2["kaina"],
                    outputStreamParts2["vidKo"].ToString());
                PartsTuple[iterator] = part;
                iterator++;
            }
            Database.Close();
            for (int i = 0; i < iterator; i++)
            {
                //textBoxList.Text += $"{PartsTuple[i].Item1} {PartsTuple[i].Item2} {PartsTuple[i].Item3.ToString()} {PartsTuple[i].Item4} {PartsTuple[i].Item5.ToString()} {PartsTuple[i].Item6.ToString()}";
                //textBoxList.Text += System.Environment.NewLine;
            }

        } //deprecated

        private void button1_Click(object sender, EventArgs e)
        {
            Katalogo_koregavimas newForm = new Katalogo_koregavimas();
            newForm.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            SandelysSarasas newForm = new SandelysSarasas();
            newForm.Show();
        }

        private void createStorehouse_Click_1(object sender, EventArgs e)
        {
            SandelysRegistracija newForm = new SandelysRegistracija();
            newForm.Show();
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int id = (int)dataGridViewContent.Rows[e.RowIndex].Cells[0].Value;
                string warehouseID = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (dataGridViewContent.Columns[e.ColumnIndex].Name == "ColumnBuy")
                {
                    PrekiuPirkimas newForm = new PrekiuPirkimas(id, warehouseID);
                    newForm.Show();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string target = comboBoxFilter.SelectedItem.ToString();
            string item = textBoxFilter.Text;

            this.Hide();
            Katalogas newForm = new Katalogas(1, target, item);
            newForm.ShowDialog();
            this.Close();

        }

        private void Filter(string target, string item)
        {
            MySqlDataReader outputStreamParts = Database.Select($"SELECT * FROM dalysadmin.dalys WHERE ({target} = '{item}');");

            while (outputStreamParts.Read())
            {
                dataGridViewContent.Rows.Add(
                    (int)outputStreamParts["id"],
                    outputStreamParts["marke"].ToString(),
                    outputStreamParts["tipas"].ToString(),
                    (int)outputStreamParts["gamybos_metai"],
                    outputStreamParts["gamintojas"].ToString(),
                    (int)outputStreamParts["kaina"],
                    "",//kiekis todo
                    outputStreamParts["vidKo"],
                    "Pirkti"
                    );

            }
            Database.Close();
        }

        private void deleteStorehouse_Click(object sender, EventArgs e)
        {
            
            SandelysSarasas newForm = new SandelysSarasas();
            newForm.Show();
            
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
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();

        }

        private void pardavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pirkimaiToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}

