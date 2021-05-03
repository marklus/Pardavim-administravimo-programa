using System;
using MySql.Data.MySqlClient;
using Grafine.Utils;
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
    
    public partial class Katalogo_pridejimas : Form
    {
        
        public Katalogo_pridejimas()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            

            if(textBoxCode.Text == "")
            {
                popup newForm = new popup("Prašau sugeneruokite kodą.");
                newForm.ShowDialog();
            }
            else
            {
                string mark = textBoxMark.Text;
                string type = textBoxType.Text;
                int year = Int32.Parse(textBoxYear.Text);
                string maker = textBoxMaker.Text;
                int price = Int32.Parse(textBoxPrice.Text);
                int amount = Int32.Parse(textBoxAmount.Text);
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
                Database.Close();
                if (counter != 0)
                {
                    popup newForm = new popup("Ši dalis jau egzistuoja.");
                    newForm.ShowDialog();
                }
                else
                {
                    Database.Insert($"INSERT INTO dalysadmin.dalys(marke, tipas, gamybos_metai, gamintojas, kaina, vidKo) VALUES('{mark}','{type}','{year}','{maker}','{price}','{code}'); ");
                    popup newForm = new popup("Dalis pridėta.");
                    newForm.ShowDialog();
                }
            }
           

        }
        
        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaker_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = Database.GenerateCode();
        }
    }
}
