using System;
using System.IO;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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

        private void katalogasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katalogas newForm = new Katalogas();
            newForm.ShowDialog();
            this.Close();
        }

        private void pridėtNaująSandėlįToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationStorehouse newForm = new RegistrationStorehouse();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
