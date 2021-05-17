using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Grafine.Utils;

namespace Grafine
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            GetContent();
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

        private void katalogasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katalogas newForm = new Katalogas();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();
        }
        private void GetContent()
        {
            MySqlDataReader outputStreamParts = Database.Select($"SELECT * FROM dalysadmin.uzsakymai WHERE (uzsakovo_ID = '{Database.GetUserID()}' OR  pardavejo_ID ='{Database.GetUserID()}');");
            while(outputStreamParts.Read())
            {
                int ID = (int)outputStreamParts["id"];
                int partID = Int32.Parse(outputStreamParts["prekes_ID"].ToString());
                string type = "";
                string buyerName = Database.GetUsername(Int32.Parse(outputStreamParts["uzsakovo_ID"].ToString()));
                string sellerName = Database.GetUsername(Int32.Parse(outputStreamParts["pardavejo_ID"].ToString()));
                DateTime date = DateTime.Parse(outputStreamParts["data"].ToString());
                int amount = (int)outputStreamParts["kiekis"];
                string partData = Database.GetGlobalPartByID(partID);
                if(Int32.Parse(outputStreamParts["uzsakovo_ID"].ToString()) == Database.GetUserID())
                {
                    type = "Pirkimas";
                }
                else
                {
                    type = "Pardavimas";
                }
                dataGridViewContent.Rows.Add(ID,
                            date.ToString(),
                            buyerName,
                            sellerName,
                            partData,
                            amount,
                            type);
            }
            Database.Close();
        }

        private void dataGridViewContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
