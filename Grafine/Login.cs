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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 40);
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

        private void labelRegistration_MouseEnter(object sender, EventArgs e)
        {
            labelRegistration.ForeColor = Color.White;
        }

        private void labelRegistration_MouseLeave(object sender, EventArgs e)
        {
            labelRegistration.ForeColor = Color.Black;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            int counter = 0;
            List<Tuple<string, string, string>> output = new List<Tuple<string, string, string>>();
            MySqlDataReader outputStream = Database.Select($"SELECT * FROM dalysadmin.vartotojai WHERE vardas ='{userName}' AND slaptazodis ='{Database.Encrypt(password)}';");
            while (outputStream.Read())
            {
                counter++;
                //Console.WriteLine(outputStream["id"] + " " + outputStream["vardas"] + " " + outputStream["slaptazodis"]);
                output.Add(new Tuple<string, string, string>(outputStream["vardas"].ToString(), outputStream["slaptazodis"].ToString(), outputStream["id"].ToString()));


            }
            Database.Close();
            if (counter == 1)
            {
                if (output[0].Item1 == userName && output[0].Item2 == Database.Encrypt(password))
                {
                    //StreamWriter activate = new StreamWriter("logins.txt");
                    Database.Activate(userName, output[0].Item3);
                    //activate.WriteLine(userName);
                    //activate.WriteLine(output[0].Item3);
                    //activate.Close();

                    //Console.WriteLine("pavyko");
                    this.Hide();
                    Main newForm = new Main();
                    newForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    popup newForm = new popup("Neteisingas slaptažodis arba prisijungimo vardas.");
                    newForm.ShowDialog();
                    //Console.WriteLine("nepavyko");
                }
            }
            else if (counter == 0)
            {
                popup newForm = new popup("Prašau įveskite tinkamą vartotojo vardą ir slaptažodį.");
                newForm.ShowDialog();
                Console.WriteLine($"counter = {counter}");
            }
            else
            {
                popup newForm = new popup("Duplikuotos paskyros. Prašau susisiekite su administratoriumi.");
                newForm.ShowDialog();
                Console.WriteLine($"counter = {counter}");
            }
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration newForm = new Registration();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
