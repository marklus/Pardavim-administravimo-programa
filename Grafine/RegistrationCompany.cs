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
    public partial class RegistrationCompany : Form
    {
        public RegistrationCompany()
        {
            InitializeComponent();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            string companyName = textBoxCompName.Text;
            string companyCode = textBoxCompID.Text;
            string storeHouseID = textBoxStorehouseId.Text;

            int counter = 0;

            List<string> outputUsers = new List<string>();
            MySqlDataReader outputStreamUsers = Database.Select($"SELECT * FROM dalysadmin.imones WHERE pavadinimas ='{companyName}';");
            while (outputStreamUsers.Read())
            {
                counter++;
            }
            Database.Close();
            if (counter != 0)
            {
                popup newForm = new popup("Nurodyta įmonė jau užregistruota");
                newForm.ShowDialog();
            }
            else
            {
                Database.Insert($"INSERT INTO dalysadmin.imones(pavadinimas, san_ID, vidKo) VALUES('{companyName}','{storeHouseID}','{companyCode}'); ");
                Database.Close();
                popup newForm = new popup("Pavyko registruoti!");
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

        private void RegistrationCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
