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
    public partial class AddNewParts : Form
    {
        public AddNewParts()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string markė = textMarkė.Text;
            string price = textPrice.Text;
            string type = textType.Text;
            string yearMade = textYearMade.Text;
            string yearCar = textYearCar.Text;
            string trademark = textBoxTrademark.Text;
            string storehouseName = textStorehouseName.Text;

            int counter = 0;

            List<string> outputUsers = new List<string>();
            MySqlDataReader outputStreamUsers = Database.Select($"SELECT * FROM dalysadmin.sandėliai WHERE pavadinimas ='{storehouseName}';");
            while (outputStreamUsers.Read())
            {
                counter++;
            }
            Database.Close();
            if (counter == 0)
            {
                popup newForm = new popup("Sandėlys su tokiu pavadinimu neužregistruotas, įrašykite sandėlį kuris jau yra užregistruotas");
                newForm.ShowDialog();
            }
            else
            {
                Database.Insert($"INSERT INTO dalysadmin.dalys( markė, kaina, mašinų_dalies_tipas, gamybos_metai, mašinos_metai, prekinis_ženklas, pavadinimas) VALUES('{markė}','{price}','{type}','{yearMade}','{yearCar}','{trademark}','{storehouseName}'); ");
                Database.Close();
                popup newForm = new popup("Dalį pavyko įdėti!");
                newForm.ShowDialog();
                counter = 0;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katalogas newForm = new Katalogas();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
