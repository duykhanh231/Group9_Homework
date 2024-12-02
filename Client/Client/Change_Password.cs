using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Net.Sockets;

namespace Client
{
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            string old_password = tb_oldpassword.Text;
            string new_password = tb_newpassword.Text;
            string confirm_password = tb_confirmpassword.Text;

            if ( new_password != confirm_password )
            {
                MessageBox.Show("New password and confirm password are different!");
            }

            if (string.IsNullOrEmpty(old_password))
            {
                MessageBox.Show("Please enter your old password!");
            }

            if (CheckPassword(new_password) == false)
            {
                MessageBox.Show("Your new password must have 8-16 characters and at least 1 special character");
            }

            //string hashed_old_password = HashPassword(old_password);
            //string hashed_new_password = HashPassword(new_password);
            //string hashed_confirm_password = HashPassword(confirm_password);

            string change_password_Message = $"CHANGE_PASSWORD|{old_password}|{new_password}|{confirm_password}";
            SendMessageToServer(change_password_Message);
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

        public bool CheckPassword(string password)
        {
            return Regex.IsMatch(password, "^[a-zA-Z0-9]{8,16}{!@#&%}$");
        }

    }
}
