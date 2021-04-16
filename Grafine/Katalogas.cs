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
    public partial class Katalogas : Form
    {
        public Katalogas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//add new part
        {
            AddNewParts newForm = new AddNewParts();
            newForm.ShowDialog();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
