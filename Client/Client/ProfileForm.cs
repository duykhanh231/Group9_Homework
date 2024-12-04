using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
        }

        public ProfileForm(string username, string email, string fullname, string birthday)
        {
            InitializeComponent();

            tbUsername.Text = username;
            tbEmail.Text = email;
            tbName.Text = fullname;
            tbBirth.Text = birthday;
        }

        private void tbBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Change_Password change_Password = new Change_Password();
            change_Password.Show();
        }
    }
}
