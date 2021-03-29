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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 40);
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

        private void labelRegistration_MouseEnter(object sender, EventArgs e)
        {
            labelRegistration.ForeColor = Color.White;
        }

        private void labelRegistration_MouseLeave(object sender, EventArgs e)
        {
            labelRegistration.ForeColor = Color.Black;
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}
