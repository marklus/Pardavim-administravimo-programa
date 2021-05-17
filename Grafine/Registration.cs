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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            textBoxCompID.Text = Database.GenerateCode();
        }


        private void labelSingIn_MouseEnter(object sender, EventArgs e)
        {
            labelSingIn.ForeColor = Color.White;

        }

        private void labelSingIn_MouseLeave(object sender, EventArgs e)
        {
            labelSingIn.ForeColor = Color.Black;
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            string companyName = textBoxCompName.Text;
            string companyCode = textBoxCompID.Text;
            string email = textBoxEmail.Text;
            string username = textBoxUsrName.Text;
            string password = Database.Encrypt(textBoxPsw.Text);
            string confirm = Database.Encrypt(textBoxCnfPsw.Text);
            string phone = textBoxTel.Text;
            int counter = 0;
            Dictionary<string, string> outputCompanies = new Dictionary<string, string>();

            if (password == confirm)
            {
                MySqlDataReader outputStreamCompany = Database.Select($"SELECT * FROM dalysadmin.imones WHERE pavadinimas ='{companyName}' AND vidKo = '{companyCode}';");
                while (outputStreamCompany.Read())
                {
                    counter++;
                    Console.WriteLine(outputStreamCompany["id"] + " " + outputStreamCompany["pavadinimas"] + " " + outputStreamCompany["vidKo"]);
                    outputCompanies.Add(outputStreamCompany["pavadinimas"].ToString(), outputStreamCompany["vidKo"].ToString());
                }
                Database.Close();
                if (counter == 0)
                {
                    
                    if (MessageBox.Show("Jūsų nurodyta įmonė nerasta. Ar norite pridėti naują įmonę su įvestais duomenimis?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Database.Insert($"INSERT INTO dalysadmin.imones(pavadinimas, san_ID, vidKo) VALUES('{companyName}','UNUSED','{companyCode}');");
                        popup newForm = new popup("Įmonė įregistruota. Galite testi vartotojo paskyros registraciją.");
                        newForm.ShowDialog();
                    }
                }
                else if (counter == 1)
                {
                    //Console.WriteLine("imone rasta");
                    counter = 0;
                    List<string> outputUsers = new List<string>();
                    MySqlDataReader outputStreamUsers = Database.Select($"SELECT * FROM dalysadmin.vartotojai WHERE vardas ='{username}';");
                    while (outputStreamUsers.Read())
                    {
                        counter++;
                        //outputUsers.Add(outputStreamCompany["vardas"].ToString());
                    }
                    Database.Close();
                    if (counter != 0)
                    {
                        popup newForm = new popup("Nurodytas vartotojas jau egzistuoja.");
                        newForm.ShowDialog();
                        //Console.WriteLine("toks vartotojas jau egzistuoja");
                    }
                    else
                    {
                        Database.Insert($"INSERT INTO dalysadmin.vartotojai(vardas, slaptazodis, telNr, elPastas, imonesPavad) VALUES('{username}','{password}','{phone}','{email}','{companyName}'); ");

                        //Console.WriteLine("pavyko registruoti");
                        Database.Close();
                        popup newForm = new popup("Pavyko registruoti!");
                        newForm.ShowDialog();
                    }
                }
                else
                {
                    popup newForm = new popup("imoniu per daug! susisiekite su administratoriumi.");
                    newForm.ShowDialog();
                    //Console.WriteLine("imoniu per daug! susisiekite su administratoriumi");
                }
            }
            else
            {
                popup newForm = new popup("Slaptažodžiai nesutampa.");
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

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string code = Database.GenerateCode();
            if (!Database.CodeExists("imones", code))
            {
                textBoxCompID.Text = code;
            }
            else
            {
                buttonGenerate_Click(sender, e);
            }
            
        }
    }
}
