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

namespace Grafine
{
    public partial class Katalogo_salinimas : Form
    {
        public Katalogo_salinimas()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string code = textBoxCode.Text;
            int counter = 0;
            MySqlDataReader outputStreamParts = Database.Select($"SELECT * FROM dalysadmin.dalys WHERE vidKo ='{code}'");
            Dictionary<string, string> outputParts = new Dictionary<string, string>();
            while (outputStreamParts.Read())
            {
                counter++;
                Console.WriteLine(outputStreamParts["id"] + " " + outputStreamParts["marke"] + " " + outputStreamParts["vidKo"]);
                outputParts.Add(outputStreamParts["id"].ToString(), outputStreamParts["vidKo"].ToString());
            }

            if(counter == 0)
            {
                popup newForm = new popup("Dalis nerasta.");
                newForm.ShowDialog();
            }
            else
            {
                Database.Delete($"DELETE FROM dalysadmin.dalys WHERE vidKo = '{code}';");
                Database.Close();
                popup newForm = new popup("Dalis pašalinta.");
                newForm.ShowDialog();
            }
        }
    }
}
