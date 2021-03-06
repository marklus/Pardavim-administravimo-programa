﻿using Grafine.Utils;
using MySql.Data.MySqlClient;
using System;
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
    public partial class SandelysModifikacija : Form
    {
        private string Warehouse;
        private int Space;
        private string Code;
        public SandelysModifikacija(string warehouse, int space, string code)
        {
            Space = space;
            Warehouse = warehouse;
            Code = code;
            
            InitializeComponent();

            textBoxStorehouseName.Text = Warehouse;
            numericUpDownSpace.Value = Space;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string newName = textBoxStorehouseName.Text;
            int freeSpace = (int)numericUpDownSpace.Value;
            int counter = 0;
            MySqlDataReader outputStreamWarehouses = Database.Select($"SELECT * FROM dalysadmin.sandelys WHERE vidKo ='{Code}';");
            while (outputStreamWarehouses.Read())
            {
                counter++;
                
            }
            if (counter != 1)
            {
                popup newForm = new popup("Sandelys nerastas.");
                newForm.ShowDialog();
            }
            else
            {
                Database.Update($"UPDATE dalysadmin.sandeliai SET pavadinimas ='{newName}', laisvas_plotas ='{freeSpace}' WHERE vidKo ='{Code}';");
                Database.Close();
                popup newForm = new popup("Dalis rasta ir koreguota.");
                newForm.ShowDialog();
            }
            Database.Close();
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
    }
}
