using Grafine.Utils;
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

namespace Grafine
{
    public partial class PrekiuSarasas : Form
    {
        private string WarehouseCode;
        public PrekiuSarasas(string warehouseCode)
        {
            InitializeComponent();
            WarehouseCode = warehouseCode;
            GetContent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetContent()
        {
            PartClass partData;
            MySqlDataReader contentData = Database.Select($"SELECT * FROM sandeliai WHERE (vidKo='{WarehouseCode}' AND vartotojoID='{Database.GetUserID()}');");
            while(contentData.Read())
            {
                string allParts = contentData["prekes"].ToString();
                //Console.WriteLine(allParts);
                string[] partCodeAmounts = allParts.Split(new char[1] {';'}, StringSplitOptions.RemoveEmptyEntries);
                foreach(string s in partCodeAmounts)
                {
                    //Console.WriteLine(s);
                    int partID = Int32.Parse(s.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                    int amount = Int32.Parse(s.Split(new char[1] { ','}, StringSplitOptions.RemoveEmptyEntries)[1]);
                    partData = Database.ConvertFromWarehouseFormat(partID, amount, WarehouseCode);
                    //Console.WriteLine($"{partID} {amount}");
                    dataGridViewWarehouses.Rows.Add(partData.ID,
                        partData.Mark,
                        partData.Type,
                        partData.Year,
                        partData.Maker,
                        partData.Price,
                        partData.Amount,
                        partData.Code);
                }
            }
            Database.Close();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrekiuSarasas newForm = new PrekiuSarasas(WarehouseCode);
            newForm.ShowDialog();
            this.Close();
        }
    }
}
