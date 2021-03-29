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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void labelSingIn_MouseEnter(object sender, EventArgs e)
        {
            labelSingIn.ForeColor = Color.White;

        }

        private void labelSingIn_MouseLeave(object sender, EventArgs e)
        {
            labelSingIn.ForeColor = Color.Black;
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

       
    }
}
