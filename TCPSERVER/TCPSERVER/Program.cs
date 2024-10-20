using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

public class Server
{
    static string connectionstring = "Data Source=NamAnh\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";
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

            Thread thread = new Thread(() => Login(client));

            Thread threadregisrter = new Thread(() => Register(client));

            thread.IsBackground = true;
            thread.Start();

        }
    }

    public static void Login(Socket client)
    {
        try
        {
            byte[] recieve = new byte[1024];
            int bytesRead;
            while ((bytesRead = client.Receive(recieve)) > 0)
            {
                string recieveUsername = Encoding.UTF8.GetString(recieve, 0, bytesRead);
                Console.WriteLine("Recieve Username ");
                string recievePassword = Encoding.UTF8.GetString(recieve, 0, bytesRead);
                Console.WriteLine("Recieve Password");

                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();

                string query = "SELECT * " +
                               "FROM users " +
                               "WHERE Username = '" + recieveUsername + "' AND " + "Password = '" + recievePassword + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    string response = "Log in successful!";
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

        }
    }

    public static void Register(Socket client)
    {

        byte[] recieve = new byte[1024];
        int bytesRead;
        SqlConnection conn = new SqlConnection(connectionstring);
        conn.Open();
        while ((bytesRead = client.Receive(recieve)) > 0)
        {
            string recieveUsername = Encoding.UTF8.GetString(recieve, 0, bytesRead);

            string recievePassword = Encoding.UTF8.GetString(recieve, 0, bytesRead);

            string recieveEmail = Encoding.UTF8.GetString(recieve, 0, bytesRead);

            string recieveFullname = Encoding.UTF8.GetString(recieve, 0, bytesRead);

            string recieveBirthday = Encoding.UTF8.GetString(recieve, 0, bytesRead);
            string query = "SELECT * " +
                            "FROM users " +
                            "WHERE Username = '" + recieveUsername + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                string response = "Username already exist";
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                client.Send(responseBytes);
                Console.WriteLine("Sent to client: " + response);
            }
            else
            {

                string insert = "INSERT INTO users(Username,Password,Email,Fullname,Birthday) " +
                                "VALUES ('" + recieveUsername + "', '" + recievePassword + "', '" + recieveEmail + "', '" + recieveFullname + "', '" + recieveBirthday + "'" + ");";
                SqlCommand cmdinsert = new SqlCommand(insert, conn);
                cmdinsert.CommandText = query;
                cmdinsert.ExecuteNonQuery();
            }

        }

    }

}
