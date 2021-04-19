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
            string kazkas = "kazkas";
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


<<<<<<< HEAD
        private void labelRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration newForm = new Registration();
            newForm.ShowDialog();
            this.Close();
        }

        private void label2RegistrationCompany_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationCompany newForm = new RegistrationCompany();
            newForm.ShowDialog();
            this.Close();
        }

        private void label2RegistrationCompany_MouseEnter(object sender, EventArgs e)
        {
            label2RegistrationCompany.ForeColor = Color.White;
        }

        private void label2RegistrationCompany_MouseLeave(object sender, EventArgs e)
        {
            label2RegistrationCompany.ForeColor = Color.Black;
        }
=======
>>>>>>> parent of f41674f (Merge pull request #5 from tomacatx2/main)
    }
}
