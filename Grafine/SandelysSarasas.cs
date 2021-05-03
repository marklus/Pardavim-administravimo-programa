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
    public partial class SandelysSarasas : Form
    {
        public SandelysSarasas()
        {
            InitializeComponent();
            GetContent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetContent()
        {
            string userID = Database.GetUserID();
            MySqlDataReader contentData = Database.Select($"SELECT * FROM sandeliai WHERE vartotojoID={userID};");
            while (contentData.Read())
            {
                dataGridViewWarehouses.Rows.Add((int)contentData["id"],
                                                    contentData["pavadinimas"],
                                                    contentData["vidKo"],
                                                    (int)contentData["uzimtumas"],
                                                    (int)contentData["laisvas_plotas"],
                                                    "Žiūrėti",
                                                    "Šalinti",
                                                    "Modifikuoti");
            }
            Database.Close();
        }

        private void dataGridViewWarehouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridViewWarehouses.Rows[e.RowIndex].Cells[0].Value;
            string name = dataGridViewWarehouses.Rows[e.RowIndex].Cells[1].Value.ToString();
            string code = dataGridViewWarehouses.Rows[e.RowIndex].Cells[2].Value.ToString();
            int taken = (int)dataGridViewWarehouses.Rows[e.RowIndex].Cells[3].Value;
            int free = (int)dataGridViewWarehouses.Rows[e.RowIndex].Cells[4].Value;

            if(e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if (dataGridViewWarehouses.Columns[e.ColumnIndex].Name == "ColumnDelete")
                {
                    if (MessageBox.Show("Ar jūs esate tikri, jog norite panaikinti šitą įrašą?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Database.Delete($"DELETE FROM dalysadmin.sandeliai WHERE id={id}");
                        InitializeComponent();
                        GetContent();
                    }
                }
                else if (dataGridViewWarehouses.Columns[e.ColumnIndex].Name == "ColumnList")
                {
                    PrekiuSarasas newForm = new PrekiuSarasas(dataGridViewWarehouses.Rows[e.RowIndex].Cells[2].Value.ToString());
                    newForm.Show();

                }
                else if (dataGridViewWarehouses.Columns[e.ColumnIndex].Name == "ColumnModify")
                {
                    
                    SandelysModifikacija newForm = new SandelysModifikacija(name, free, code);
                    newForm.Show();

                }
            }
           
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            SandelysSarasas newForm = new SandelysSarasas();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
