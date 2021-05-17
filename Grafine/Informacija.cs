using System;
using System.IO;
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

namespace Grafine
{
    public partial class Informacija : Form
    {
        public Informacija()
        {
            InitializeComponent();
            GetContent();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhoneNumber.Text;
            string company = textBoxCompanyName.Text;
            string oldpass = textBoxOldPass.Text;

            StreamReader input = new StreamReader("logins.txt");
            string usernameInternal = input.ReadLine();
            input.Close();
            Console.WriteLine(usernameInternal);
            if (oldpass != null && oldpass != "")
            {
                Database.Update($"UPDATE dalysadmin.vartotojai SET vardas='{username}', elPastas='{email}', telNr = '{phone}', imonesPavad = '{company}' WHERE vardas='{usernameInternal}' AND slaptazodis = '{Database.Encrypt(oldpass)}';");
                Database.Close();

                StreamWriter clear = new StreamWriter("logins.txt");
                clear.Close();

                this.Hide();
                Login newForm = new Login();
                newForm.ShowDialog();
                this.Close();
            }
            else
            {
                popup newForm = new popup("Įveskite savo slaptažodį.");
                newForm.ShowDialog();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newPass = textBoxNewPass.Text;
            string newPassConf = textBoxNewPassConfirm.Text;
            string oldpass = textBoxOldPass.Text;

            StreamReader input = new StreamReader("logins.txt");
            string usernameInternal = input.ReadLine();
            input.Close();

            if (newPass == newPassConf)
            {
                Database.Update($"UPDATE dalysadmin.vartotojai SET slaptazodis = '{Database.Encrypt(newPass)}' WHERE vardas='{usernameInternal}' AND slaptazodis = '{Database.Encrypt(oldpass)}';");

                StreamWriter clear = new StreamWriter("logins.txt");
                clear.Close();

                this.Hide();
                Login newForm = new Login();
                newForm.ShowDialog();
                this.Close();
            }
            else
            {
                popup newForm = new popup("Nauji slaptažodžiai nesutampa.");
                newForm.ShowDialog();
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader details = new StreamReader("logins.txt");
            string username = details.ReadLine();
            details.Close();

            Database.Delete($"DELETE FROM dalysadmin.vartotojai WHERE vardas = '{username}';");
            Database.Close();

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
        private void GetContent()
        {
            MySqlDataReader outputStreamUserdata = Database.Select($"SELECT * FROM dalysadmin.vartotojai WHERE id='{Database.GetUserID()}'");

            while(outputStreamUserdata.Read())
            {
                textBoxCompanyName.Text = outputStreamUserdata["imonesPavad"].ToString();
                textBoxEmail.Text = outputStreamUserdata["elPastas"].ToString();
                textBoxPhoneNumber.Text = outputStreamUserdata["telNr"].ToString();
                textBoxUserName.Text = outputStreamUserdata["vardas"].ToString();
            }

            outputStreamUserdata.Close();
        }
    }
}
