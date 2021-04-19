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
    public partial class Katalogas : Form
    {
        public Katalogas()
        {
            InitializeComponent();
            FormatList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Katalogo_pridejimas newForm = new Katalogo_pridejimas();
            newForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxList.Text = "";
            FormatList();
        }
        private void FormatList()
        {
            int counter = 0;
            MySqlDataReader outputStreamParts = Database.Select($"SELECT * FROM dalysadmin.dalys;");

            while (outputStreamParts.Read())
            {
                counter++;
            }
            Database.Close();
            Tuple<string, string, int, string, int, string>[] PartsTuple = new Tuple<string, string, int, string, int, string>[counter];
            int iterator = 0;
            MySqlDataReader outputStreamParts2 = Database.Select($"SELECT * FROM dalysadmin.dalys;");
            Console.WriteLine(counter);
            while (outputStreamParts2.Read())
            {
                Console.WriteLine(iterator);
                var part = Tuple.Create(outputStreamParts2["marke"].ToString(),
                    outputStreamParts2["tipas"].ToString(),
                    (int)outputStreamParts2["gamybos_metai"],
                    outputStreamParts2["gamintojas"].ToString(),
                    (int)outputStreamParts2["kaina"],
                    outputStreamParts2["vidKo"].ToString());
                PartsTuple[iterator] = part;
                iterator++;
            }
            Database.Close();
            for (int i = 0; i < iterator; i++)
            {
                textBoxList.Text += $"{PartsTuple[i].Item1} {PartsTuple[i].Item2} {PartsTuple[i].Item3.ToString()} {PartsTuple[i].Item4} {PartsTuple[i].Item5.ToString()} {PartsTuple[i].Item6.ToString()}";
                textBoxList.Text += System.Environment.NewLine;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Katalogo_koregavimas newForm = new Katalogo_koregavimas();
            newForm.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Katalogo_salinimas newForm = new Katalogo_salinimas();
            newForm.ShowDialog();
        }
    }
}

