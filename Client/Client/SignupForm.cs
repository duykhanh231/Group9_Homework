using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Client
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string pass = tbPass.Text;
            string cfmPass = tbCfmPass.Text;
            string email = tbEmail.Text;
            string name = tbName.Text;
            DateTime birth = dtpBirth.Value;

            if (pass != cfmPass)
            {
                MessageBox.Show("Password and Password Confirmation are not match.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid Email.");
                return;
            }

            string hashedPass = HashPassword(pass);

            string regMessage = $"REGISTER|{username}|{hashedPass}|{email}|{name}|{birth.ToString()}";
            SendMessageToServer(regMessage);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private string HashPassword(string pass)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void SendMessageToServer(string message)
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 2508);
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                byte[] responseData = new byte[256];
                int bytes = stream.Read(responseData, 0, responseData.Length);
                string response = Encoding.UTF8.GetString(responseData, 0, bytes);

                MessageBox.Show(response);

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
