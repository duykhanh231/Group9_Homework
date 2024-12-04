using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;


namespace Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string pass = tbPass.Text;

            string hashedPass = HashPassword(pass);

            string loginMessage = $"LOGIN|{username}|{hashedPass}";
            SendMessageToServer(loginMessage);

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

        private async void SendMessageToServer(string message)
        {
            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 2508))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        await stream.WriteAsync(data, 0, data.Length);

                        byte[] responseData = new byte[256];
                        int bytes = await stream.ReadAsync(responseData, 0, responseData.Length);
                        string response = Encoding.UTF8.GetString(responseData, 0, bytes);

                        if (response.StartsWith("Log in successful!"))
                        {
                            string[] responseParts = response.Split('|');

                            if (responseParts.Length == 5)
                            {
                                ProfileForm profile = new ProfileForm();
                                profile.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid response format from server.");
                            }
                        }
                        else
                        {
                            MessageBox.Show(response);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void btnPasswordReset_Click(object sender, EventArgs e)
        {
            PasswordReset resetForm = new PasswordReset();
            resetForm.Show();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
