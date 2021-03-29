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
    public partial class popup : Form
    {
        public popup(string error)
        {
            InitializeComponent();
            label1.Text = error;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

