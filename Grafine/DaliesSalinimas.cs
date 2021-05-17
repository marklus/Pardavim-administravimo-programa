using System;
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
using System.IO;




namespace Grafine
{
    public partial class DaliesSalinimas : Form
    {
        public DaliesSalinimas()
        {
            InitializeComponent();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string code = textBoxCode.Text;
            int counter = 0;

            MySqlDataReader outputStreamParts = Database.Select($"SELECT * FROM dalysadmin.dalys WHERE vidKo ='{code}';");
            while (outputStreamParts.Read())
            {
                counter++;
            }
            if(counter < 1)
            {
                popup newForm = new popup("Tokia dalis neegzistuoja. \n" + "Patikrinkite vidinį kodą" );
                newForm.ShowDialog();
            }
            else if((int)outputStreamParts["kiekis"] > 0)
            {
                popup newForm = new popup("Dalies negalima pašalinti, kadangi jos kiekis nėra lygus 0. \n" + "Koreguokite dalies kiekį skiltyje Koreguoti dalį");
                newForm.ShowDialog();
            }
            else
            {
                outputStreamParts = Database.Select($"DELETE * FROM dalysadmin.dalys WHERE vidKo ='{code}';");
                popup newForm = new popup("Dalis buvo sėkmingai pašalinta.");
                newForm.ShowDialog();
            }
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
    }
}
