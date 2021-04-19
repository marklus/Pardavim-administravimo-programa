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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of f41674f (Merge pull request #5 from tomacatx2/main)
=======
>>>>>>> parent of b175713 (Pridėtas sandėlių kūrimas  bei mašinos dalių pridėjimas bei keletas gryžimo funkcijų bei patikrų)
=======
>>>>>>> parent of b175713 (Pridėtas sandėlių kūrimas  bei mašinos dalių pridėjimas bei keletas gryžimo funkcijų bei patikrų)
=======
>>>>>>> parent of b175713 (Pridėtas sandėlių kūrimas  bei mašinos dalių pridėjimas bei keletas gryžimo funkcijų bei patikrų)
=======
>>>>>>> parent of b175713 (Pridėtas sandėlių kūrimas  bei mašinos dalių pridėjimas bei keletas gryžimo funkcijų bei patikrų)
    }
}
