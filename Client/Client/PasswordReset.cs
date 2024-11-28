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

namespace Client
{
    public partial class PasswordReset : Form
    {
        public PasswordReset()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.");
                return;
            }

            string resetMessage = $"PASSWORD_RESET|{email}";
            SendMessageToServer(resetMessage);
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

                        MessageBox.Show(response);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }
    }
}
