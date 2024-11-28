using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;

public class Server
{
    static string connectionstring = "Data Source=localhost;Initial Catalog=Users;User ID=sa;Password=120274Az#";

    public static void Main(string[] args)
    {
        int port = 2508;
        string IP = "127.0.0.1";

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint ipe = new IPEndPoint(IPAddress.Any, port);
        socket.Bind(ipe);
        socket.Listen();

        Console.WriteLine($"Server is listening on {IP}:{port}");

        while (true)
        {
            Socket client = socket.Accept();
            Console.WriteLine("Connect Successful");

            Thread thread = new Thread(() => HandleClient(client));
            thread.IsBackground = true;
            thread.Start();
        }
    }

    public static void HandleClient(Socket client)
    {
        try
        {
            byte[] receive = new byte[1024];
            int bytesRead = client.Receive(receive);
            string receivedMessage = Encoding.UTF8.GetString(receive, 0, bytesRead);

            string[] parts = receivedMessage.Split('|');
            if (parts.Length < 1)
            {
                Console.WriteLine("Invalid message format received.");
                return;
            }

            if (parts[0] == "LOGIN")
            {
                Login(client, parts);
            }
            else if (parts[0] == "REGISTER")
            {
                Register(client, parts);
            }
            else if (parts[0] == "PASSWORD_RESET")
            {
                PasswordReset(client, parts);
            }    
            else
            {
                Console.WriteLine("Invalid message type received.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in HandleClient: " + ex.Message);
        }
    }

    private static string HashPassword(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }

    public static void Login(Socket client, string[] parts)
    {
        try
        {
            if (parts.Length != 3)
            {
                string response = "Invalid message format for login.";
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                client.Send(responseBytes);
                return;
            }

            string receiveUsername = parts[1];
            string receivePassword = parts[2];

            Console.WriteLine("Received Username: " + receiveUsername);

            string hashedPassword = HashPassword(receivePassword); 

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", receiveUsername);
                cmd.Parameters.AddWithValue("@password", hashedPassword); 

                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    string username = datareader["Username"].ToString();
                    string email = datareader["Email"].ToString();
                    string fullname = datareader["Fullname"].ToString();
                    string birthday = datareader["Birthday"].ToString();

                    string response = $"Log in successful!|{username}|{email}|{fullname}|{birthday}";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    client.Send(responseBytes);
                    Console.WriteLine("Sent to client: " + response);
                }
                else
                {
                    string response = "Username or Password is Incorrect!";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    client.Send(responseBytes);
                    Console.WriteLine("Sent to client: " + response);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in Login: " + ex.Message);
        }
    }

    public static void Register(Socket client, string[] parts)
    {
        try
        {
            if (parts.Length != 6)
            {
                string response = "Invalid message format for registration.";
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                client.Send(responseBytes);
                return;
            }

            string receiveUsername = parts[1];
            string receivePassword = parts[2];
            string receiveEmail = parts[3];
            string receiveFullname = parts[4];
            string receiveBirthday = parts[5];

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", receiveUsername);

                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    string response = "Username already exists!";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    client.Send(responseBytes);
                    Console.WriteLine("Sent to client: " + response);
                }
                else
                {
                    datareader.Close();

                    string hashedPassword = HashPassword(receivePassword); 
                    string insertQuery = "INSERT INTO users (Username, Password, Email, Fullname, Birthday) VALUES (@username, @password, @Email, @Fullname, @Birthday)";
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, conn);
                    cmdInsert.Parameters.AddWithValue("@username", receiveUsername);
                    cmdInsert.Parameters.AddWithValue("@password", hashedPassword); 
                    cmdInsert.Parameters.AddWithValue("@Email", receiveEmail);
                    cmdInsert.Parameters.AddWithValue("@Fullname", receiveFullname);
                    cmdInsert.Parameters.AddWithValue("@Birthday", receiveBirthday);

                    cmdInsert.ExecuteNonQuery();

                    string response = "Registration successful!";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    client.Send(responseBytes);
                    Console.WriteLine("Sent to client: " + response);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in Register: " + ex.Message);
        }
    }

    public static void PasswordReset(Socket client, string[] parts)
    {
        try
        {
            if (parts.Length != 2)
            {
                string response = "Invalid message format for password reset.";
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                client.Send(responseBytes);
                return;
            }

            string receiveEmail = parts[1];

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", receiveEmail);

                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    // Generate a new random password
                    string newPassword = GenerateRandomPassword();

                    // Update the password in the dtb
                    datareader.Close();
                    string updateQuery = "UPDATE users SET Password = @Password WHERE Email = @Email";
                    SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn);
                    cmdUpdate.Parameters.AddWithValue("@Password", newPassword);
                    cmdUpdate.Parameters.AddWithValue("@Email", receiveEmail);
                    cmdUpdate.ExecuteNonQuery();

                    SendEmail(receiveEmail, newPassword);

                    string response = "Password reset successful! Check your email for the new password.";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    client.Send(responseBytes);
                }
                else
                {
                    string response = "Email not found!";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    client.Send(responseBytes);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in PasswordReset: " + ex.Message);
        }
    }

    private static string GenerateRandomPassword()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
        Random random = new Random();
        char[] password = new char[12];
        for (int i = 0; i < password.Length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }
        return new string(password);
    }

    private static void SendEmail(string email, string newPassword)
    {
        try
        {
            using (var client = new SmtpClient("smtp.gmail.com"))
            {
                client.Port = 587;
                client.Credentials = new NetworkCredential("nt106.gr11@gmail.com", "nsbt fmxj vzxz sgnj");
                client.EnableSsl = true;

                string subject = "Password Reset";
                string body = $"Your new password is: {newPassword}\nPlease change it after logging in.";

                client.Send("your-email@example.com", email, subject, body);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error sending email: " + ex.Message);
        }
    }
}
